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
    public class ConcentracionParticulaManagement : BaseManagement
    {

        private ConcentracionParticulaCrud crudFactory;
        public ConcentracionParticulaManagement()
        {
            crudFactory = new ConcentracionParticulaCrud();
        }
        public ConcentracionParticula RetrieveConcentracionParticula(ConcentracionParticula obj)
        {
            return crudFactory.Retrieve<ConcentracionParticula>(obj);
        }
        public void CreateConcentracionParticula(ConcentracionParticula obj)
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
        public void UpdateConcentracionParticula(ConcentracionParticula obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteConcentracionParticula(ConcentracionParticula obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllConcentracionParticula()
        {

            List<ConcentracionParticula> lista = crudFactory.RetrieveAll<ConcentracionParticula>();
            return lista;
        }

        public IList RetriveByProRoomStatement(ConcentracionParticula obj)
        {

            List<ConcentracionParticula> lista = crudFactory.RetriveByProRoomStatement<ConcentracionParticula>(obj);
            return lista;
        }
        
    }
}
