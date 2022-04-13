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
    public class OcupacionManagement : BaseManagement
    {

        private OcupacionCrud crudFactory;
        public OcupacionManagement()
        {
            crudFactory = new OcupacionCrud();
        }
        public Ocupacion RetrieveOcupacion(Ocupacion obj)
        {
            return crudFactory.Retrieve<Ocupacion>(obj);
        }
        public void CreateOcupacion(Ocupacion obj)
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
        public void UpdateOcupacion(Ocupacion obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteOcupacion(Ocupacion obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllOcupacion()
        {

            List<Ocupacion> lista = crudFactory.RetrieveAll<Ocupacion>();
            return lista;
        }
    }
}
