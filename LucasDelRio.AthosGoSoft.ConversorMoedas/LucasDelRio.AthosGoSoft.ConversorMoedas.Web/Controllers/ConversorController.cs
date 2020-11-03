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
        public IActionResult CriarComanda(decimal valor)
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
    }
}