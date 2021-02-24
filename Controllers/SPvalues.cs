using mbfwAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace mbfwAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPvalues : ControllerBase
    {
        private readonly string _cs;

        public SPvalues(IOptions<ApplicationSettings> appSettings)
        {
            _cs = appSettings.Value.JWT_Secret;
        }

        [HttpGet("{sp}/{datefrom?}/{dateto?}")]
        public async Task<Double?> GetCash(string sp, DateTime? datefrom, DateTime dateto)
        {
            using (SqlConnection sql = new SqlConnection(_cs))
            {
                using (SqlCommand cmd = new SqlCommand(sp, sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (datefrom.HasValue)
                    {
                        cmd.Parameters.Add("@datefrom", SqlDbType.DateTime).Value = datefrom;
                        cmd.Parameters.Add("@dateto", SqlDbType.DateTime).Value = dateto;
                    }
                    else
                    {
                        cmd.Parameters.Add("@vdate", SqlDbType.DateTime).Value = dateto;
                    }
                    await sql.OpenAsync();
                    var value = await cmd.ExecuteScalarAsync();
                    return value == DBNull.Value ? 0: (Double)value;
                }
            }
        }

        [HttpGet("charts/{sp}/{datefrom?}/{dateto?}")]
        public async Task<List<MyClass>> GetSLSTOP1_Result1(string sp, DateTime datefrom, DateTime dateto)
        {
            using (SqlConnection sql = new SqlConnection(_cs))
            {
                using (SqlCommand cmd = new SqlCommand(sp, sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@datefrom", datefrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", dateto));
                    var response = new List<MyClass>();
                    await sql.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(CreateTable(reader));
                        }
                    }
                    return response;
                }
            }
        }
        private MyClass CreateTable(SqlDataReader reader)
        {
            return new MyClass()
            {
                QTY = (Double)reader["QTY"],
                PNAME = reader["PNAME"].ToString(),
            };
        }
        public class MyClass
        {
            public Nullable<double> QTY { get; set; }
            public string PNAME { get; set; }
        }
    }
}