using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Repositories
{
    public abstract class Repositori<Model>
    {
        public string _connectionstring = @"Data source = WIN-C6IAG73172R\SQLEXPRESS; initial catalog = AlifAcademy; integrated security = true";

        public List<Model> Select()
        {
            using (IDbConnection context = new SqlConnection(_connectionstring))
            {
                return context.Query<Model>($"Select * from {typeof(Model).Name}").ToList();
            }
        }
    }
}
