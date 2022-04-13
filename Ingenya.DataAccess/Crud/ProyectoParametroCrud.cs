using Ingenya.DataAccess.Dao;
using Ingenya.DataAccess.Mapper;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.DataAccess.Crud
{
    public class ProyectoParametroCrud : CrudFactory
    {
        public ProyectoParametroCrud()
        {
            _mapper = new ProyectoParametroMapper();
        }

        public List<T> RetriveParametrosByProyRoom<T>(BaseEntity entity)
        {
            ProyectoParametroMapper _mapper = new ProyectoParametroMapper();

            var instance = SqlDao.GetInstance();
            var operation = _mapper.GetRetriveParametrosByRoomStatement(entity);
            var lstResult = instance.ExecuteQueryProcedure(operation);
            if (lstResult.Count <= 0) return default(List<T>);
            var objs = _mapper.BuildProyectoParametroObjects(lstResult);
            List<T> lista1 = new List<T>();
            int i = 0;

            foreach (BaseEntity obj in objs)
            {

                lista1.Add((T)Convert.ChangeType(objs[i], typeof(T)));

                i = i + 1;

            }
            return lista1;
        }


        public bool GetUpdateValorStatement(BaseEntity entity)
        {
            ProyectoParametroMapper _mapper = new ProyectoParametroMapper();

            var operation = _mapper.GetUpdateValorStatement(entity);

            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);
            return true;
        }




    }
}
