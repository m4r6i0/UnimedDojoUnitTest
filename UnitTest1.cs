using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Unimed_DOJO_FIrstTest_Employee_Report.Employes;

namespace Unimed_DOJO_FIrstTest_Employee_Report
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Description("Como lojista, quero ver uma lista de todos os funcionários maiores de 18 anos, para saber quem tem permissão para trabalhar aos domingos")]
        public void FuncionariosMaiorDe18Anos()
        {
            var list = new Funcionarios();
            Assert.IsTrue(list.ListarFuncionarios().Count() >= 18);
        }
    }
}
