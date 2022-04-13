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
    public class ProyectoManagement : BaseManagement
    {

        private ProyectoCrud crudFactory;
        public ProyectoManagement()
        {
            crudFactory = new ProyectoCrud();
        }
        public Proyecto RetrieveProyecto(Proyecto obj)
        {
            return crudFactory.Retrieve<Proyecto>(obj);
        }
        public void CreateProyecto(Proyecto obj)
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
        public void UpdateProyecto(Proyecto obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteProyecto(Proyecto obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllProyecto()
        {

            List<Proyecto> lista = crudFactory.RetrieveAll<Proyecto>();
            return lista;
        }
    }
}
