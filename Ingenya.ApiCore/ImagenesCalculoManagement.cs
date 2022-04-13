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
    public class ImagenesCalculoManagement : BaseManagement
    {

        private ImagenesCalculoCrud crudFactory;
        public ImagenesCalculoManagement()
        {
            crudFactory = new ImagenesCalculoCrud();
        }
        public ImagenesCalculo RetrieveImagenesCalculo(ImagenesCalculo obj)
        {
            return crudFactory.Retrieve<ImagenesCalculo>(obj);
        }
        public void CreateImagenesCalculo(ImagenesCalculo obj)
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
        public void UpdateImagenesCalculo(ImagenesCalculo obj)
        {

            crudFactory.Update(obj);
        }
        public void DeleteImagenesCalculo(ImagenesCalculo obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllImagenesCalculo()
        {

            List<ImagenesCalculo> lista = crudFactory.RetrieveAll<ImagenesCalculo>();
            return lista;
        }
    }
}
