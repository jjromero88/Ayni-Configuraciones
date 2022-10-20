using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Ayni.Configuracion.Aplication.Dto;
using Ayni.Configuracion.Transversal.Common;

namespace Ayni.Configuracion.Aplication.Interface
{
    public interface IMonedaApplication
    {

        #region Metodos Sincronos
        Response<bool> Insert(MonedaDto monedaDto);
        Response<bool> Update(MonedaDto monedaDto);
        Response<bool> Delete(int monedaId);
        Response<MonedaDto> Get(int monedaId);
        Response<IEnumerable<MonedaDto>> GetAll();
        #endregion


        #region Metodos Asincronos
        Task<Response<bool>> InsertAsync(MonedaDto monedaDto);
        Task<Response<bool>> UpdateAsync(MonedaDto monedaDto);
        Task<Response<bool>> DeleteAsync(int monedaId);
        Task<Response<MonedaDto>> GetAsync(int monedaId);
        Task<Response<IEnumerable<MonedaDto>>> GetAllAsync();
        #endregion

    }
}
