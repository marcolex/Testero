using Ingenya.DataAccess.Crud;
using Ingenya.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.ApiCore
{
    public class ProvedorManagement : BaseManagement
    {

        private ProvedorCrud crudFactory;
        public ProvedorManagement()
        {
            crudFactory = new ProvedorCrud();
        }
        public Provedor RetrieveProvedor(Provedor obj)
        {
            return crudFactory.Retrieve<Provedor>(obj);
        }
        public void CreateProvedor(Provedor obj)
        {
            try
            {
                crudFactory.Create(obj);
            }
            catch (Exception)
            {
                //HandleException(ex);
            }

        }
        public void UpdateProvedor(Provedor obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteProvedor(Provedor obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllProvedor()
        {

            List<Provedor> lista = crudFactory.RetrieveAll<Provedor>();
            return lista;
        }
    }
}
