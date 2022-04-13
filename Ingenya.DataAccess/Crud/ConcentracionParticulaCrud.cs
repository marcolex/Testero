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
    public class ConcentracionParticulaCrud : CrudFactory
    {
        public ConcentracionParticulaCrud()
        {
            _mapper = new ConcentracionParticulaMapper();
        }

        public List<T> RetriveByProRoomStatement<T>(BaseEntity entity)
        {
            ConcentracionParticulaMapper _mapper = new ConcentracionParticulaMapper();

            var instance = SqlDao.GetInstance();
            var operation = _mapper.GetRetriveByProRoomStatement(entity);
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
    }
}
