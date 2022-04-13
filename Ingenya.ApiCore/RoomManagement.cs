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
    public class RoomManagement : BaseManagement
    {

        private RoomCrud crudFactory;
        public RoomManagement()
        {
            crudFactory = new RoomCrud();
        }
        public Room RetrieveRoom(Room obj)
        {
            return crudFactory.Retrieve<Room>(obj);
        }

        public Room RCreateRoom(Room obj)
        {
            return crudFactory.RCreate<Room>(obj);
        }

        public void CreateRoom(Room obj)
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
        public void UpdateRoom(Room obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteRoom(Room obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllRoom()
        {

            List<Room> lista = crudFactory.RetrieveAll<Room>();
            return lista;
        }
    }
}
