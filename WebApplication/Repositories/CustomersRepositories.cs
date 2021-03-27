using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public class CustomersRepositories:Repositori<Customers>
    {
        public CustomersRepositories() : base() { } 

        public int? Select(Customers customers)
        {
            using(IDbConnection context = new SqlConnection(_connectionstring))
            {
                var Id = context.Query<int>("Select cast(Scoup_Identity() as int)").FirstOrDefault();
                return Id;
            }
        }

    }
}
