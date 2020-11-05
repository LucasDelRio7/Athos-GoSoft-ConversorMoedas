using LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LucasDelRio.AthosGoSoft.ConversorMoedas.Web.Controllers
{
    [Route("api/conversor")]
    [ApiController]
    public class ConversorController : ControllerBase
    {
        private readonly IConversorService conversorService;

        public ConversorController(IConversorService conversorService)
        {
            this.conversorService = conversorService;
        }

        [HttpGet("euro-real/{valor}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult EuroParaReal(decimal valor)
        {
            try
            {
                var tupleRetorno = conversorService.ConverterEuroParaReal(valor);

                if (!tupleRetorno.Item1)
                    return StatusCode(StatusCodes.Status400BadRequest, tupleRetorno.Item2);

                return StatusCode(StatusCodes.Status200OK, tupleRetorno.Item3);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("euro-dolar/{valor}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult EuroParaDolar(decimal valor)
        {
            try
            {
                var tupleRetorno = conversorService.ConverterEuroParaDolar(valor);

                if (!tupleRetorno.Item1)
                    return StatusCode(StatusCodes.Status400BadRequest, tupleRetorno.Item2);

                return StatusCode(StatusCodes.Status200OK, tupleRetorno.Item3);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("dolar-real/{valor}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DolarParaReal(decimal valor)
        {
            try
            {
                var tupleRetorno = conversorService.ConverterDolarParaReal(valor);

                if (!tupleRetorno.Item1)
                    return StatusCode(StatusCodes.Status400BadRequest, tupleRetorno.Item2);

                return StatusCode(StatusCodes.Status200OK, tupleRetorno.Item3);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("dolar-euro/{valor}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DolarParaEuro(decimal valor)
        {
            try
            {
                var tupleRetorno = conversorService.ConverterDolarParaEuro(valor);

                if (!tupleRetorno.Item1)
                    return StatusCode(StatusCodes.Status400BadRequest, tupleRetorno.Item2);

                return StatusCode(StatusCodes.Status200OK, tupleRetorno.Item3);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("real-euro/{valor}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult RealParaEuro(decimal valor)
        {
            try
            {
                var tupleRetorno = conversorService.ConverterRealParaEuro(valor);

                if (!tupleRetorno.Item1)
                    return StatusCode(StatusCodes.Status400BadRequest, tupleRetorno.Item2);

                return StatusCode(StatusCodes.Status200OK, tupleRetorno.Item3);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("real-dolar/{valor}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult RealParaDolar(decimal valor)
        {
            try
            {
                var tupleRetorno = conversorService.ConverterRealParaDolar(valor);

                if (!tupleRetorno.Item1)
                    return StatusCode(StatusCodes.Status400BadRequest, tupleRetorno.Item2);

                return StatusCode(StatusCodes.Status200OK, tupleRetorno.Item3);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}