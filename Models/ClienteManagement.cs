using Ingenya.API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.API
{
   public class ClienteManagement
    {

        private ClienteCrud crudFactory;
        public ClienteManagement()
        {
            crudFactory = new ClienteCrud();
        }
        public Cliente RetrieveClientebyId(Cliente obj)
        {
            return crudFactory.Retrieve<Cliente>(obj);
        }
        public void CreateCliente(Cliente obj)
        {
            try
            {
                crudFactory.Create(obj);
            }
            catch (Exception ex)
            {
                //HandleException(ex);
            }

        }
        public void UpdateCliente(Cliente obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteCliente(Cliente obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllCliente()
        {

            List<Cliente> lista = crudFactory.RetrieveAll<Cliente>();
            return lista;
        }
    }
}
