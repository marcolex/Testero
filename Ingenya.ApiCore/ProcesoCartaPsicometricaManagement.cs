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
    public class ProcesoCartaPsicometricaManagement : BaseManagement
    {

        private ProcesoCartaPsicometricaCrud crudFactory;
        public ProcesoCartaPsicometricaManagement()
        {
            crudFactory = new ProcesoCartaPsicometricaCrud();
        }
        public ProcesoCartaPsicometrica RetrieveProcesoCartaPsicometrica(ProcesoCartaPsicometrica obj)
        {
            return crudFactory.Retrieve<ProcesoCartaPsicometrica>(obj);
        }
        public void CreateProcesoCartaPsicometrica(ProcesoCartaPsicometrica obj)
        {
            try
            {
                crudFactory.Create(obj);
            }
            catch (Exception ex)
            {
                //HandleException(ex);
            }

        }
        public void UpdateProcesoCartaPsicometrica(ProcesoCartaPsicometrica obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteProcesoCartaPsicometrica(ProcesoCartaPsicometrica obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllProcesoCartaPsicometrica()
        {

            List<ProcesoCartaPsicometrica> lista = crudFactory.RetrieveAll<ProcesoCartaPsicometrica>();
            return lista;
        }
    }
}
