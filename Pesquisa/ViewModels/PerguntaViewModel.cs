using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.ViewModels
{
    public class PerguntaViewModel
    {

        public int Id { get; set; }
        public string Pergunta { get; set; }

        public RespostaViewModel Resposta { get; set; }
    }
}
