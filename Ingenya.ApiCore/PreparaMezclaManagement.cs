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
    public class PreparaMezclaManagement : BaseManagement
    {

        private PreparaMezclaCrud crudFactory;
        public PreparaMezclaManagement()
        {
            crudFactory = new PreparaMezclaCrud();
        }
        public PreparaMezcla RetrievePreparaMezcla(PreparaMezcla obj)
        {
            return crudFactory.Retrieve<PreparaMezcla>(obj);
        }
        public void CreatePreparaMezcla(PreparaMezcla obj)
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
        public void UpdatePreparaMezcla(PreparaMezcla obj)
        {

            crudFactory.Update(obj);
        }
        public void DeletePreparaMezcla(PreparaMezcla obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllPreparaMezcla()
        {

            List<PreparaMezcla> lista = crudFactory.RetrieveAll<PreparaMezcla>();
            return lista;
        }
    }
}
