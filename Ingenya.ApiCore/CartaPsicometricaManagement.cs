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
    public class CartaPsicometricaManagement : BaseManagement
    {

        private CartaPsicometricaCrud crudFactory;
        public CartaPsicometricaManagement()
        {
            crudFactory = new CartaPsicometricaCrud();
        }
        public CartaPsicometrica RetrieveCartaPsicometrica(CartaPsicometrica obj)
        {
            return crudFactory.Retrieve<CartaPsicometrica>(obj);
        }
        public void CreateCartaPsicometrica(CartaPsicometrica obj)
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
        public void UpdateCartaPsicometrica(CartaPsicometrica obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteCartaPsicometrica(CartaPsicometrica obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllCartaPsicometrica()
        {

            List<CartaPsicometrica> lista = crudFactory.RetrieveAll<CartaPsicometrica>();
            return lista;
        }
    }
}
