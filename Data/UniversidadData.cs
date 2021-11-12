

using Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Data
{
    public class UniversidadData
    {
        
        private string conf;
        public string ConfConexion()
        {

            //Construir la conexión
            try
            {
                var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfiguration configuration = builder.Build();
                conf = configuration["ConnectionStrings:connectionString"];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return conf;
        }

        public List<UniversidadEntity> LIS_UniversidadData(string CODALU)
        {

            List<UniversidadEntity> lstAlumnos = new List<UniversidadEntity>();

            try
            {
                string sOpcion = "01";
                ConfConexion();

                var conn = new SqlConnection(conf);
                conn.Open();

                SqlCommand _Command = new("USP_MNT_Universidad", conn);
                _Command.CommandType = CommandType.StoredProcedure;
                _Command.Parameters.Add(new SqlParameter("@sOpcion", sOpcion));
                _Command.Parameters.Add(new SqlParameter("@nCODALU", CODALU));
           
                SqlDataReader reader = _Command.ExecuteReader();

                while (reader.Read())
                {
                    UniversidadEntity alumnoEnt = new UniversidadEntity();

                    alumnoEnt.CODALU = reader["CODALU"].ToString();
                    alumnoEnt.NOMALU = reader["NOMALU"].ToString();
                    alumnoEnt.APEALU = reader["APEALU"].ToString();
                    alumnoEnt.CODCUR = reader["CODCUR"].ToString();
                    alumnoEnt.NOMCUR = reader["NOMCUR"].ToString();
                    alumnoEnt.NOTA = Convert.ToInt32(reader["NOTA"]);
                    alumnoEnt.CREDITO = Convert.ToInt32(reader["CREDITO"]);

                    lstAlumnos.Add(alumnoEnt);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return lstAlumnos;
        }


    }
}
