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
   public class ParametroManagement : BaseManagement
    {

        private ParametroCrud crudFactory;
        public ParametroManagement()
        {
            crudFactory = new ParametroCrud();
        }
        public Parametro RetrieveParamentro(Parametro obj)
        {
            return crudFactory.Retrieve<Parametro>(obj);
        }

        public Parametro RCreateParametro(Parametro obj)
        {
            return crudFactory.RCreate<Parametro>(obj);
        }

        public void CreateParametro(Parametro obj)
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
        public void UpdateParametro(Parametro obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteParametro(Parametro obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllParametro()
        {

            List<Parametro> lista = crudFactory.RetrieveAll<Parametro>();
            return lista;
        }
    }
}
