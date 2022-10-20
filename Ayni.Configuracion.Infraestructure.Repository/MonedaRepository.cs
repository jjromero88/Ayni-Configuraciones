using System;
using System.Data;
using System.Threading.Tasks;
using Ayni.Configuracion.Domain.Entity;
using Ayni.Configuracion.Infraestructure.Interface;
using Ayni.Configuracion.Transversal.Common;
using Dapper;

namespace Ayni.Configuracion.Infraestructure.Repository
{
    public class MonedaRepository : IMonedaRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public MonedaRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }


        #region METODOS SINCRONOS
        public Moneda Get(int moneda_id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_GET_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("MONEDA_ID", moneda_id);

                var moneda = connection.QuerySingle<Moneda>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return moneda;
            }
        }

        public IEnumerable<Moneda> GetAll()

        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_GET_LIST_MONEDA";

                var moneda = connection.Query<Moneda>(query, commandType: CommandType.StoredProcedure);

                return moneda;
            }
        }

        public bool Delete(int moneda_id)

        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_DEL_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("MONEDA_ID", moneda_id);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Insert(Moneda moneda)

        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_INS_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("DESCRIPCION", moneda.descripcion);
                parameters.Add("ABREVIATURA", moneda.abreviatura);
                parameters.Add("SIMBOLO", moneda.simbolo);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Update(Moneda moneda)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_UPD_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("MONEDA_ID", moneda.moneda_id);
                parameters.Add("DESCRIPCION", moneda.descripcion);
                parameters.Add("ABREVIATURA", moneda.abreviatura);
                parameters.Add("SIMBOLO", moneda.simbolo);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        #endregion



        #region METODOS ASINCRONOS
        public async Task<Moneda> GetAsync(int moneda_id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_GET_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("MONEDA_ID", moneda_id);

                var moneda = await connection.QuerySingleAsync<Moneda>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return moneda;
            }
        }

        public async Task<IEnumerable<Moneda>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_GET_LIST_MONEDA";

                var moneda = await connection.QueryAsync<Moneda>(query, commandType: CommandType.StoredProcedure);

                return moneda;
            }
        }

        public async Task<bool> DeleteAsync(int moneda_id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_DEL_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("MONEDA_ID", moneda_id);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> InsertAsync(Moneda moneda)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_INS_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("DESCRIPCION", moneda.descripcion);
                parameters.Add("ABREVIATURA", moneda.abreviatura);
                parameters.Add("SIMBOLO", moneda.simbolo);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Moneda moneda)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "USP_UPD_MONEDA";

                var parameters = new DynamicParameters();

                parameters.Add("MONEDA_ID", moneda.moneda_id);
                parameters.Add("DESCRIPCION", moneda.descripcion);
                parameters.Add("ABREVIATURA", moneda.abreviatura);
                parameters.Add("SIMBOLO", moneda.simbolo);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        #endregion

    }
}