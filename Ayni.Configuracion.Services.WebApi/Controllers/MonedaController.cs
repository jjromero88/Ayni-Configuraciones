using Microsoft.AspNetCore.Mvc;
using Ayni.Configuracion.Aplication.Dto;
using Ayni.Configuracion.Aplication.Interface;

namespace Ayni.Configuracion.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : Controller
    {
        private readonly IMonedaApplication _monedaApplication;

        public MonedaController(IMonedaApplication monedaApplication)
        {
            _monedaApplication = monedaApplication;
        }


        #region Metodos Sincronos

        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] MonedaDto MonedaDto)
        {
            if (MonedaDto == null)
                return BadRequest();

            var response = _monedaApplication.Insert(MonedaDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] MonedaDto MonedaDto)
        {
            if (MonedaDto == null)
                return BadRequest();

            var response = _monedaApplication.Update(MonedaDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("Delete/{monedaId}")]
        public IActionResult Delete(int monedaId)
        {
            if (string.IsNullOrEmpty(monedaId.ToString()))
                return BadRequest();

            var response = _monedaApplication.Delete(monedaId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("Get/{monedaId}")]
        public IActionResult Get(int monedaId)
        {
            if (string.IsNullOrEmpty(monedaId.ToString()))
                return BadRequest();

            var response = _monedaApplication.Get(monedaId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = _monedaApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion



        #region Metodos Asincronos

        [HttpPost("InsertAsync")]
        public async Task<IActionResult> InsertAsync([FromBody] MonedaDto MonedaDto)
        {
            if (MonedaDto == null)
                return BadRequest();

            var response = await _monedaApplication.InsertAsync(MonedaDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] MonedaDto MonedaDto)
        {
            if (MonedaDto == null)
                return BadRequest();

            var response = await _monedaApplication.UpdateAsync(MonedaDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("DeleteAsync/{monedaId}")]
        public async Task<IActionResult> DeleteAsync(int monedaId)
        {
            if (string.IsNullOrEmpty(monedaId.ToString()))
                return BadRequest();

            var response = await _monedaApplication.DeleteAsync(monedaId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("GetAsync/{monedaId}")]
        public async Task<IActionResult> GetAsync(int monedaId)
        {
            if (string.IsNullOrEmpty(monedaId.ToString()))
                return BadRequest();

            var response = await _monedaApplication.GetAsync(monedaId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _monedaApplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion

    }
}
