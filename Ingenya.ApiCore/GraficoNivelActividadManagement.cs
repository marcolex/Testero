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
   public class GraficoNivelActividadManagement : BaseManagement
    {

        private GraficoNivelActividadCrud crudFactory;
        public GraficoNivelActividadManagement()
        {
            crudFactory = new GraficoNivelActividadCrud();
        }
        public GraficoNivelActividad RetrieveGraficoNivelActividad(GraficoNivelActividad obj)
        {
            return crudFactory.Retrieve<GraficoNivelActividad>(obj);
        }
        public void CreateGraficoNivelActividad(GraficoNivelActividad obj)
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
        public void UpdateGraficoNivelActividad(GraficoNivelActividad obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteGraficoNivelActividad(GraficoNivelActividad obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllGraficoNivelActividad()
        {

            List<GraficoNivelActividad> lista = crudFactory.RetrieveAll<GraficoNivelActividad>();
            return lista;
        }
    }
}
