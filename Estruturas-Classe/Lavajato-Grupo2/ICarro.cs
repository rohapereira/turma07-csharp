using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato_Grupo2
{
    internal interface ICarro
    {
        string Nome { get; set; }
        int Id { get; set; }
        string Modelo { get; set; }
    }
}
