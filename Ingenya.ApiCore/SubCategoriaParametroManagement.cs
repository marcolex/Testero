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
    public class SubCategoriaParametroManagement : BaseManagement
    {

        private SubCategoriaParametroCrud crudFactory;
        public SubCategoriaParametroManagement()
        {
            crudFactory = new SubCategoriaParametroCrud();
        }
        public SubCategoriaParametro RetrieveSubCategoriaParametro(SubCategoriaParametro obj)
        {
            return crudFactory.Retrieve<SubCategoriaParametro>(obj);
        }
        public void CreateSubCategoriaParametro(SubCategoriaParametro obj)
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
        public void UpdateSubCategoriaParametro(SubCategoriaParametro obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteSubCategoriaParametro(SubCategoriaParametro obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllSubCategoriaParametro()
        {

            List<SubCategoriaParametro> lista = crudFactory.RetrieveAll<SubCategoriaParametro>();
            return lista;
        }
    }
}
