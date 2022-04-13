using System;
using System.Collections;
using System.Collections.Generic;
using Ingenya.DataAccess.Crud;
using Ingenya.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.ApiCore
{
    public class FugaManagement : BaseManagement
    {

        private FugaCrud crudFactory;
        public FugaManagement()
        {
            crudFactory = new FugaCrud();
        }
        public Fuga RetrieveFuga(Fuga obj)
        {
            return crudFactory.Retrieve<Fuga>(obj);
        }
        public void CreateFuga(Fuga obj)
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
        public void UpdateFuga(Fuga obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteFuga(Fuga obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllFuga()
        {

            List<Fuga> lista = crudFactory.RetrieveAll<Fuga>();
            return lista;
        }

        public IList RetrieveAllFugaByProyecto(Fuga obj)
        {
            FugaCrud crudFactory = new FugaCrud();

            List<Fuga> lista = crudFactory.RetriveFugaByProyRoom<Fuga>(obj);
            return lista;
        }
    }
}
