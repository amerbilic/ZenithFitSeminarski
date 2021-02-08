using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithFit.WebAPI.Database
{
    public class Data
    {
        public static void Seed(ZenithFitDatabaseContext context)
        {
            context.Database.Migrate();

            //add init
        }
    }
}
