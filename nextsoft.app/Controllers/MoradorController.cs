using Microsoft.AspNetCore.Mvc;
using NextSoft.Domain.Entitites;
using NextSoft.Service.Services;
using NextSoft.Service.Validations;
using System;

namespace NextSoft.app.Controllers
{
    [Produces("application/json")]
    [Route("api/Morador")]
    public class MoradorController : ControllerBase
    {
        private BaseService<Morador> service = new BaseService<Morador>();

        [Route("/api/Morador/")]
        [HttpPost]
        public IActionResult Post([FromBody] Morador item)
        {
            try
            {
                service.Post<MoradorValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("/api/Morador/")]
        [HttpPut]
        public IActionResult Put([FromBody] Morador item)
        {
            try
            {
                service.Put<MoradorValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("/api/Morador/")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("/api/Morador/")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [Route("/api/Morador/all")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

}