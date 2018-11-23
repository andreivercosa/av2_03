using System;
using System.Collections.Generic;

namespace avaliacao03_funcionariosEDependentes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dep = "";
            List<Funcionario> lsFunc = new List<Funcionario>();


            Console.Write("Informe a quantidade de fucionarios: ");
            int quantFun = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= quantFun; i++){
                Funcionario funcionario = new Funcionario();
                Console.WriteLine("Informe o nome do Funcionario: ");
                funcionario.nome = Console.ReadLine();

                Console.Write("Informe a quantidade de dependentes: ");
                int quantDep = Convert.ToInt32(Console.ReadLine());
                for (int d = 1; d <= quantDep; d++){
                    Console.WriteLine("Informe o nome do(s) dependente(s): ");
                    dep = Console.ReadLine() + " ";
                    funcionario.dependentes.Add(dep);
                }
                lsFunc.Add(funcionario);

            }

            foreach(var i in lsFunc){
                Console.WriteLine("Funcionario: {0}", i.nome);
                Console.WriteLine("Dependentes: ");
                foreach (var a in i.dependentes){
                    Console.WriteLine("{0}", a);
                }
            }
        }
    }
}
