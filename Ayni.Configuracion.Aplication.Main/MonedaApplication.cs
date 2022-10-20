using AutoMapper;
using Ayni.Configuracion.Aplication.Dto;
using Ayni.Configuracion.Aplication.Interface;
using Ayni.Configuracion.Domain.Entity;
using Ayni.Configuracion.Domain.Interface;
using Ayni.Configuracion.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ayni.Configuracion.Aplication.Main
{
    public class MonedaApplication : IMonedaApplication
    {
        private readonly IMonedaDomain _monedaDomain;
        private readonly IMapper _mapper;

        public MonedaApplication(IMonedaDomain monedaDomain, IMapper mapper)
        {
            _monedaDomain = monedaDomain;
            _mapper = mapper;
        }


        #region Metodos Sincronos
        public Response<bool> Insert(MonedaDto monedaDto)
        {
            var response = new Response<bool>();

            try
            {
                var moneda = _mapper.Map<Moneda>(monedaDto);
                response.Data = _monedaDomain.Insert(moneda);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Update(MonedaDto monedaDto)
        {
            var response = new Response<bool>();

            try
            {
                var moneda = _mapper.Map<Moneda>(monedaDto);
                response.Data = _monedaDomain.Update(moneda);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Delete(int monedaId)
        {
            var response = new Response<bool>();

            try
            {
                response.Data = _monedaDomain.Delete(monedaId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminacion exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<MonedaDto> Get(int monedaId)
        {
            var response = new Response<MonedaDto>();

            try
            {
                var moneda = _monedaDomain.Get(monedaId);
                response.Data = _mapper.Map<MonedaDto>(moneda);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<IEnumerable<MonedaDto>> GetAll()
        {
            var response = new Response<IEnumerable<MonedaDto>>();

            try
            {
                var moneda = _monedaDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<MonedaDto>>(moneda);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                    //_logger.LogInformation("Consulta exitosa!!");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                //_logger.LogError(ex.Message);
            }

            return response;
        }
        #endregion


        #region Metodos Asincronos
        public async Task<Response<bool>> InsertAsync(MonedaDto monedaDto)
        {
            var response = new Response<bool>();

            try
            {
                var moneda = _mapper.Map<Moneda>(monedaDto);
                response.Data = await _monedaDomain.InsertAsync(moneda);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> UpdateAsync(MonedaDto monedaDto)
        {
            var response = new Response<bool>();

            try
            {
                var moneda = _mapper.Map<Moneda>(monedaDto);
                response.Data = await _monedaDomain.UpdateAsync(moneda);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> DeleteAsync(int monedaId)
        {

            var response = new Response<bool>();

            try
            {
                response.Data = await _monedaDomain.DeleteAsync(monedaId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminacion exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<MonedaDto>> GetAsync(int monedaId)
        {
            var response = new Response<MonedaDto>();

            try
            {
                var moneda = await _monedaDomain.GetAsync(monedaId);
                response.Data = _mapper.Map<MonedaDto>(moneda);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<MonedaDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<MonedaDto>>();

            try
            {
                var moneda = await _monedaDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<MonedaDto>>(moneda);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        #endregion

    }
}