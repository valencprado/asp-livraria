using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjetoLivrariaNOITE.Models
{
    public class ClLivros
    { 
        public string codLivro { get; set; }
        [DisplayName("Nome do Autor")]
        public string nomeLivro { get; set; }
        public string codAutor { get; set; }
        public string nomeAutor { get; set; }
        public string status { get; set; }
    }
}