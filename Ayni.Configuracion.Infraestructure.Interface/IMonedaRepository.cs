using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ayni.Configuracion.Domain.Entity;
using Ayni.Configuracion.Infraestructure.Interface;

namespace Ayni.Configuracion.Infraestructure.Interface
{
    public interface IMonedaRepository
    {

        #region Metodos Sincronos
        bool Insert(Moneda moneda);
        bool Update(Moneda moneda);
        bool Delete(int moneda_id);
        Moneda Get(int moneda_id);
        IEnumerable<Moneda> GetAll();
        #endregion


        #region Metodos Asincronos
        Task<bool> InsertAsync(Moneda moneda);
        Task<bool> UpdateAsync(Moneda moneda);
        Task<bool> DeleteAsync(int moneda_id);
        Task<Moneda> GetAsync(int moneda_id);
        Task<IEnumerable<Moneda>> GetAllAsync();
        #endregion

    }
}
