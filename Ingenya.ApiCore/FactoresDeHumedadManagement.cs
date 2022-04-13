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
    public class FactoresDeHumedadManagement : BaseManagement
    {

        private FactoresDeHumedadCrud crudFactory;
        public FactoresDeHumedadManagement()
        {
            crudFactory = new FactoresDeHumedadCrud();
        }
        public FactoresDeHumedad RetrieveFactoresDeHumedad(FactoresDeHumedad obj)
        {
            return crudFactory.Retrieve<FactoresDeHumedad>(obj);
        }
        public void CreateFactoresDeHumedad(FactoresDeHumedad obj)
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
        public void UpdateFactoresDeHumedad(FactoresDeHumedad obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteFactoresDeHumedad(FactoresDeHumedad obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllFactoresDeHumedad()
        {

            List<FactoresDeHumedad> lista = crudFactory.RetrieveAll<FactoresDeHumedad>();
            return lista;
        }
    }
}
