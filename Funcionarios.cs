using System;
using System.Collections.Generic;
using System.Text;

namespace Unimed_DOJO_FIrstTest_Employee_Report.Employes
{
    public class Funcionarios
    {
        public string Name { get; set; }
        public int Idade { get; set; }

        public List<Funcionarios> ListarFuncionarios()
        {
            return new List<Funcionarios>()
        {
            new Funcionarios(){ Name = "George", Idade = 17},
            new Funcionarios(){ Name = "Jonh", Idade = 18},
            new Funcionarios(){ Name = "Ringo", Idade = 15},
            new Funcionarios(){ Name = "Paul", Idade = 51},
        };
        }
    }
}
