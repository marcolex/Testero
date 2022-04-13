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
    public class ProyectoParametroManagement : BaseManagement
    {

        private ProyectoParametroCrud crudFactory;
        public ProyectoParametroManagement()
        {
            crudFactory = new ProyectoParametroCrud();
        }
        public ProyectoParametro RetrieveProyectoParametro(ProyectoParametro obj)
        {
            return crudFactory.Retrieve<ProyectoParametro>(obj);
        }

        public IList RetriveParametrosByProyRoom(ProyectoParametro obj)
        {
            List<ProyectoParametro> lista = crudFactory.RetriveParametrosByProyRoom<ProyectoParametro>(obj);
            return lista;
        }
        
        public void CreateProyectoParametro(ProyectoParametro obj)
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
        public void UpdateProyectoParametro(ProyectoParametro obj)
        {
            crudFactory.Update(obj);
        }


        public void UpdateValorProyectoParametro(ProyectoParametro obj)
        {
            ProyectoParametroCrud crudFactory = new ProyectoParametroCrud();

            crudFactory.GetUpdateValorStatement(obj);
        }

        public void DeleteProyectoParametro(ProyectoParametro obj)
        {

            crudFactory.Delete(obj);
        }
        public IList RetrieveAllProyectoParametro()
        {

            List<ProyectoParametro> lista = crudFactory.RetrieveAll<ProyectoParametro>();
            return lista;
        }
    }
}
