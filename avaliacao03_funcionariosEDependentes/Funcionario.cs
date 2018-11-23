using System;
using System.Collections.Generic;

namespace avaliacao03_funcionariosEDependentes
{
    public class Funcionario
    {
        public string nome{get;set;}

        public List<string> dependentes = new List<string>();


        public Funcionario()
        {
        }
    }
}
