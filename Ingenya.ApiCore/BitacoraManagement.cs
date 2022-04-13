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
    public class BitacoraManagement : BaseManagement
    {

        private BitacoraCrud crudFactory;
        public BitacoraManagement()
        {
            crudFactory = new BitacoraCrud();
        }
        public Bitacora RetrieveBitacora(Bitacora bitacora)
        {
            return crudFactory.Retrieve<Bitacora>(bitacora);
        }
        public void CreateBitacora(Bitacora bitacora)
        {
            try
            {
                crudFactory.Create(bitacora);
            }
            catch (Exception ex)
            {
                //HandleException(ex);
            }

        }
        public void UpdateBitacora(Bitacora bitacora)
        {

            crudFactory.Update(bitacora);
        }
        public void DeleteBitacora(Bitacora bitacora)
        {

            crudFactory.Delete(bitacora);
        }
        public IList RetrieveAllBitacora()
        {

            List<Bitacora> lista = crudFactory.RetrieveAll<Bitacora>();
            return lista;
        }
    }
}
