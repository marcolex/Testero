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
    public class CategoriaParametroManagement : BaseManagement
    {

        private CategoriaParametroCrud crudFactory;
        public CategoriaParametroManagement()
        {
            crudFactory = new CategoriaParametroCrud();
        }
        public CategoriaParametro RetrieveCategoriaParametro(CategoriaParametro obj)
        {
            return crudFactory.Retrieve<CategoriaParametro>(obj);
        }
        public void CreateCategoriaParametro(CategoriaParametro obj)
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
        public void UpdateCategoriaParametro(CategoriaParametro obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteCategoriaParametro(CategoriaParametro obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllCategoriaParametro()
        {

            List<CategoriaParametro> lista = crudFactory.RetrieveAll<CategoriaParametro>();
            return lista;
        }
    }
}
