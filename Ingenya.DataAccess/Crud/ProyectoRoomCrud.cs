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
    public class ProyectoRoomCrud : CrudFactory
    {
        ProyectoRoomMapper _mapperGlobal;

        public ProyectoRoomCrud()
        {
            _mapper = new ProyectoRoomMapper();
            _mapperGlobal = new ProyectoRoomMapper();
        }

        public List<T> RetrieveProyectoRoomXProyecto<T>(BaseEntity entity)
        {
            ProyectoRoomMapper _mapper = new ProyectoRoomMapper();

            var instance = SqlDao.GetInstance();
            var operation = _mapper.GetRetriveProyectoStatement(entity);
            var lstResult = instance.ExecuteQueryProcedure(operation);
            if (lstResult.Count <= 0) return default(List<T>);
            var objs = _mapper.BuildObjects(lstResult);
            List<T> lista1 = new List<T>();
            int i = 0;

            foreach (BaseEntity obj in objs)
            {

                lista1.Add((T)Convert.ChangeType(objs[i], typeof(T)));

                i = i + 1;

            }
            return lista1;
        }

        public T RetriveProyectoByRoomStatement<T>(BaseEntity entity)
        {
            ProyectoRoomMapper _mapper = new ProyectoRoomMapper();

            var instance = SqlDao.GetInstance();
            var operation = _mapper.GetRetriveProyectoByRoomStatement(entity);
            var lstResult = instance.ExecuteQueryProcedure(operation);

            if (lstResult.Count <= 0) return default(T);

            var dic = lstResult[0];
            var objs = _mapper.BuildObject(dic);
            return (T)Convert.ChangeType(objs, typeof(T));
        }
    }
}
