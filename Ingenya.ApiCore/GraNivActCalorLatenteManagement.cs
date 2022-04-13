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
    public class GraNivActCalorLatenteManagement : BaseManagement
    {

        private GraNivActCalorLatenteCrud crudFactory;
        public GraNivActCalorLatenteManagement()
        {
            crudFactory = new GraNivActCalorLatenteCrud();
        }
        public GraNivActCalorLatente RetrieveGraNivActCalorLatente(GraNivActCalorLatente obj)
        {
            return crudFactory.Retrieve<GraNivActCalorLatente>(obj);
        }
        public void CreateGraNivActCalorLatente(GraNivActCalorLatente obj)
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
        public void UpdateGraNivActCalorLatente(GraNivActCalorLatente obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteGraNivActCalorLatente(GraNivActCalorLatente obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllGraNivActCalorLatente()
        {

            List<GraNivActCalorLatente> lista = crudFactory.RetrieveAll<GraNivActCalorLatente>();
            return lista;
        }
    }
}
