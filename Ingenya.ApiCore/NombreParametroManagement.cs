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
   public class NombreParametroManagement : BaseManagement
    {

        private NombreParametroCrud crudFactory;
        public NombreParametroManagement()
        {
            crudFactory = new NombreParametroCrud();
        }
        public NombreParametro RetrieveNombreParametro(NombreParametro obj)
        {
            return crudFactory.Retrieve<NombreParametro>(obj);
        }
        public void CreateNombreParametro(NombreParametro obj)
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
        public void UpdateNombreParametro(NombreParametro obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteNombreParametro(NombreParametro obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllNombreParametro()
        {

            List<NombreParametro> lista = crudFactory.RetrieveAll<NombreParametro>();
            return lista;
        }
    }
}
