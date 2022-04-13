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
    public class ProyectoRoomManagement : BaseManagement
    {

        private ProyectoRoomCrud crudFactory;
        public ProyectoRoomManagement()
        {
            crudFactory = new ProyectoRoomCrud();
        }
        public ProyectoRoom RetrieveProyectoRoom(ProyectoRoom obj)
        {
            return crudFactory.Retrieve<ProyectoRoom>(obj);
        }

        public IList RetrieveProyectoRoomXProyecto(ProyectoRoom obj)
        {
            List<ProyectoRoom> lista = crudFactory.RetrieveProyectoRoomXProyecto<ProyectoRoom>(obj);
            return lista;
        }

        public ProyectoRoom RetriveProyectoByRoomStatement(ProyectoRoom obj)
        {
            return crudFactory.RetriveProyectoByRoomStatement<ProyectoRoom>(obj);
        }

        public ProyectoRoom RCreateProyectoRoom(ProyectoRoom obj)
        {
            return crudFactory.RCreate<ProyectoRoom>(obj);
        }

        public void CreateProyectoRoom(ProyectoRoom obj)
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
        public void UpdateProyectoRoom(ProyectoRoom obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteProyectoRoom(ProyectoRoom obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllProyectoRoom()
        {

            List<ProyectoRoom> lista = crudFactory.RetrieveAll<ProyectoRoom>();
            return lista;
        }
    }
}
