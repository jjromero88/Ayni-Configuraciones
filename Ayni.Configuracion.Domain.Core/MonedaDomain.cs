using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Ayni.Configuracion.Domain.Entity;
using Ayni.Configuracion.Domain.Interface;
using Ayni.Configuracion.Infraestructure.Interface;

namespace Ayni.Configuracion.Domain.Core
{

    /*
     * Logica y reglas de negocio
     */

    public class MonedaDomain : IMonedaDomain
    {
        private readonly IMonedaRepository _monedaRepository;

        public MonedaDomain(IMonedaRepository monedaRepository)
        {
            _monedaRepository = monedaRepository;
        }


        #region Metodos Sincronos

        public bool Insert(Moneda moneda)
        {
            return _monedaRepository.Insert(moneda);
        }

        public bool Update(Moneda moneda)
        {
            return _monedaRepository.Update(moneda);
        }

        public bool Delete(int moneda_id)
        {
            return _monedaRepository.Delete(moneda_id);
        }

        public Moneda Get(int moneda_id)
        {
            return _monedaRepository.Get(moneda_id);
        }

        public IEnumerable<Moneda> GetAll()
        {
            return _monedaRepository.GetAll();
        }

        #endregion



        #region Metodos Asincronos
        public async Task<bool> InsertAsync(Moneda moneda)
        {
            return await _monedaRepository.InsertAsync(moneda);
        }

        public async Task<bool> UpdateAsync(Moneda moneda)
        {
            return await _monedaRepository.UpdateAsync(moneda);
        }

        public async Task<bool> DeleteAsync(int moneda_id)
        {
            return await _monedaRepository.DeleteAsync(moneda_id);
        }

        public async Task<Moneda> GetAsync(int moneda_id)
        {
            return await _monedaRepository.GetAsync(moneda_id);
        }

        public async Task<IEnumerable<Moneda>> GetAllAsync()
        {
            return await _monedaRepository.GetAllAsync();
        }

        #endregion

    }
}