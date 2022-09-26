using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticasBF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic.Tests
{
    [TestClass()]
    public class EmployeesIntermediaTests
    {
        [TestMethod()]
        public void addEmployeesTest()
        {
            //arrange

            EmployeesIntermedia employeesIntermedia = new EmployeesIntermedia();

            int employeeID = 1;
            string employeeName = "pepe";
            string employeelastname = "ponpon";
            string title = "jefesito";

            //act

            employeesIntermedia.addEmployees(employeeID, employeeName, employeelastname, title);

            //assert

            Assert.AreEqual(1, "pepe", "ponpon","jefesito");
        }
    }
}