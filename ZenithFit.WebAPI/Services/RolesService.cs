using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class RolesService : IRolesService
    {
        private readonly ZenithFitDatabaseContext _context;

        public RolesService(ZenithFitDatabaseContext context)
        {
            _context = context;
        }

        public Model.Roles CheckAdmin(int roleId)
        {
            var list = _context.Roles.ToList();
            Model.Roles result = new Model.Roles();

            foreach (var item in list)
            {
                if (item.RoleId == roleId)
                {
                    if (item.RoleName.Contains("Admin"))
                    {
                        result.RoleName = item.RoleName;
                        result.Description = item.RoleNote;
                        result.RoleID = item.RoleId;
                        return result;
                    }

                }
            }
            return null; 
        }

        public List<Model.Roles> Get()
        {
            List<Model.Roles> result = new List<Model.Roles>();
            var list = _context.Roles.ToList();

            foreach (var item in list)
            {
                Model.Roles role = new Model.Roles();
                role.RoleName = item.RoleName;
                role.Description = item.RoleNote;
                role.RoleID = item.RoleId;

                result.Add(role);
            }

            return result;
        }
    }
    }
