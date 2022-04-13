using Ingenya.API.Models;
using Ingenya.ApiCore;
using Ingenya.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ingenya.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Cliente cliente = new Cliente
            {
                IdCliente = 0
            };
            ClienteManagement clienteManagement = new ClienteManagement();
            cliente = clienteManagement.RetrieveClientebyId(cliente);
            var path = cliente;
            int x = path.IdCliente;
            Assert.IsTrue(x == 0);
        }
    }
}
