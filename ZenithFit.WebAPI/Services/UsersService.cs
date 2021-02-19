using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;
using ZenithFit.WebAPI.Exceptions;

namespace ZenithFit.WebAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly ZenithFitDatabaseContext _context;
        private readonly IMapper _mapper;
        public UsersService(ZenithFitDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Users> Get(UsersSearchRequest request)
        {
            var query = _context.Users.AsQueryable();
            var orderquery = _context.Orders.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.UserFirstName))
            {
                query = query.Where(x => x.UserFirstName.StartsWith(request.UserFirstName));
            }

            if (!string.IsNullOrWhiteSpace(request?.UserLastName))
            {
                query = query.Where(x => x.UserLastName.StartsWith(request.UserLastName));
            }

            var list = query.ToList();

            var returnModel = _mapper.Map<List<Model.Users>>(list);
            foreach (var user in returnModel)
            {
                var NumOfOrders = orderquery.Count(x => x.UserId == user.UserId);
                user.NumberOfOrders = NumOfOrders;

            }
            return returnModel;
        }


        public Model.Users GetbyId(int id)
        {
            var model = _context.Users.Find(id);

            return _mapper.Map<Model.Users>(model);
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

        public Model.Users Insert(UsersInsertRequest request)
        {
            var entity = _mapper.Map<Users>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwords are not matching!");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);


            _context.Users.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Users>(entity);
        }

        public Model.Users Update(int id, UsersInsertRequest update)
        {
            var entity = _context.Users.Find(id);

            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            _mapper.Map(update, entity);

            if (!string.IsNullOrWhiteSpace(update.Password))
            {
                if (update.Password != update.PasswordConfirmation)
                {
                    throw new UserException("Passwords are not matching!");
                }
                //TODO : update password
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Users>(entity);
        }

        public Model.Users Authenticate(string username, string password)
        {
            var user = _context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role).FirstOrDefault(x => x.UserUsername == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.PasswordSalt, password);

                if (hashedPass == user.PasswordHash)
                {
                    var roles = _context.UserRoles.Where(x => x.UserId == user.UserId);
                    Model.Users newuser = new Model.Users();

                    foreach (var item in roles)
                    {

                        newuser.UserRoles = new List<Model.UserRoles>();
                        newuser.UserRoles.Add(new Model.UserRoles
                        {
                            ChangedDate = item.ChangeDate,
                            UserID = item.UserId,
                            RoleID = item.RoleId,
                            UserRoleID = item.UserRoleId
                        });
                    }
                    newuser.UserFirstName = user.UserFirstName;
                    newuser.UserLastName = user.UserLastName;
                    newuser.UserUsername = user.UserUsername;
                    newuser.UserEmail = user.UserEmail;
                    newuser.UserId = user.UserId;
                    newuser.UserPhone = user.UserPhone;

                    return newuser;

                }
            }

            return null;
        }

        /* public Model.Users Authenticate(string username,string password)
         {
             var entity = _context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role).FirstOrDefault(x => x.UserUsername == username);

             if (entity == null)
             {
                 throw new UserException("Wrong username!");
             }

             var hash = GenerateHash(entity.PasswordSalt, password);

             if (hash != entity.PasswordHash)
             {
                 throw new UserException("Wrong password!");
             }

             return _mapper.Map<Model.Users>(entity);

         }*/


    }
    }    
