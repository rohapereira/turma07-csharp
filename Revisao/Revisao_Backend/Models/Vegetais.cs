using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revisao_Backend.Models
{
    public class Vegetais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime Validade { get; set; }
    }
}