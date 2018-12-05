using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pesquisa.ViewModels;


namespace Pesquisa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntasController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {

            var retorno = new List<PerguntaViewModel>();

            for (int i = 0; i < 10; i++)
            {
                retorno.Add(new PerguntaViewModel
                {
                    Id =  i,
                    Pergunta = @"Pergunta: " + i
                });
            }

            return new JsonResult(retorno);
            
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


    }
}