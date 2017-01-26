using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Models;

namespace Angular2Mvc5Application1
{
    public class HeroRepo
    {
        private string _connectionString = @"Data Source=localhost;Initial Catalog=Testing;Integrated Security=True";

        public IEnumerable<Hero> GetHeroes()
        {
            using(var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using(var cmd = new SqlCommand("", conn))
                {
                    cmd.CommandText = @"SELECT * FROM Heroes";
                    var dr = cmd.ExecuteReader();

                    var retVal = new List<Hero>();
                    while (dr.Read())
                    {
                        var h = new Hero();
                        h.id = (int)dr["RecordId"];
                        h.name = (string)dr["HeroName"];
                        retVal.Add(h);
                    }

                    return retVal;
                }
            }
        }

        public async Task<IEnumerable<Hero>> GetHeroesAsync()
        {
            return await System.Threading.Tasks.Task.Factory.StartNew(() => GetHeroes());
        }

    }
}