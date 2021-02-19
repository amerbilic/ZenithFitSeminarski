using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class ClientService : IClientService
    {
        private readonly ZenithFitDatabaseContext _context;
        private readonly IMapper _mapper;

        public ClientService(ZenithFitDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Clients Authenticate(string username, string password)
        {
            var client = _context.Clients.FirstOrDefault(x => x.ClientUsername == username);

            if (client != null)
            {
                var newHash = GenerateHash(client.PasswordSalt, password);

                if (newHash == client.PasswordHash)
                {

                    return _mapper.Map<Model.Clients>(client);


                }
            }
            return null;
        }

        public List<Model.Clients> Get(ClientsSearchRequest search)
        {
            var query = _context.Clients.AsQueryable();
            var orderquery = _context.Orders.AsQueryable();
            var ratingsquery = _context.Ratings.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.ClientName))
            {
                query = query.Where(x => x.ClientFirstName.StartsWith(search.ClientName));

                
            }

            if(!string.IsNullOrWhiteSpace(search?.UserName))
            {
                query = query.Where(x => x.ClientUsername.StartsWith(search.UserName));
            }

            var list = query.ToList();
            var returnModel = _mapper.Map<List<Model.Clients>>(list);
            foreach (var client in returnModel)
            {
                var NumOfOrders = orderquery.Count(x => x.ClientId == client.ClientId);
                var NumOfRatings = ratingsquery.Count(x => x.ClientId == client.ClientId);
                client.NumberOfOrders = NumOfOrders;
                client.NumberOfRatings = NumOfRatings;
            }

            return returnModel;
        }

        public Model.Clients GetById(int id)
        {
            var client = _context.Clients.Find(id);

            return _mapper.Map<Model.Clients>(client);

        }

        public void Insert(ClientsInsertRequest request)
        {
            Database.Clients entity = _mapper.Map<Database.Clients>(request);

            if(request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Clients.Add(entity);
            _context.SaveChanges();
        }

        public void Update(int id, ClientsInsertRequest request)
        {
            var entity = _context.Clients.Find(id);
            _context.Clients.Attach(entity);
            _context.Clients.Update(entity);

            if(!string.IsNullOrWhiteSpace(request.Password))
            {
                if(request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwords do not match!");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
