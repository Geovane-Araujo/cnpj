using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnpj.Resources
{
    class Util
    {
        public static int Buscacnpj(String cnpj)
        {

            int verificador = 0;

            var connectO = "Host=localhost;Username=postgres;Password=1816;Database=adonai-cnpj";
            var con = new NpgsqlConnection(connectO);

            con.Open();

            var sql = "SELECT COUNT(cnpj)as cnpj FROM basecnpj where cnpj ='" + cnpj + "'";
            var command = new NpgsqlCommand(sql, con);
            NpgsqlDataReader rs = command.ExecuteReader();

            if (rs.HasRows)
            {
                while (rs.Read())
                {
                    verificador = rs.GetInt32(rs.GetOrdinal("cnpj"));
                }
            }
            rs.Close();
            con.Close();
            con.Dispose();
            command.Dispose();

            return verificador;
        }

        public static int BuscacnpjMysql(MySqlConnection con, String cnpj)
        {

            int verificador = 0;
            var sql = "SELECT COUNT(cnpj)as cnpj FROM basecnpj where cnpj ='" + cnpj + "'";
            var command = new MySqlCommand(sql, con);
            MySqlDataReader rs = command.ExecuteReader();

            if (rs.HasRows)
            {
                while (rs.Read())
                {
                    verificador = rs.GetInt32(rs.GetOrdinal("cnpj"));
                }
            }
            rs.Close();
            command.Dispose();

            return verificador;
        }
    }
}
