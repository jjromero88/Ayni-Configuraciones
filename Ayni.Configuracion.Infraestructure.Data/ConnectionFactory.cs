using System;
using Ayni.Configuracion.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Ayni.Configuracion.Infraestructure.Data
{

    /*
     * Responsabilidad:
     * Conectarse a la BD y devolver la instancia de la coneccion
     */

    public class ConnectionFactory : IConnectionFactory
    {

        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /*
         Accede a la bd y devuelve una instancia de coneccion abierta
         */
        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("AyniConfiguracionConnection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}