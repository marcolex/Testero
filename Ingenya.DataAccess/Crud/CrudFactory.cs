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
    public abstract class CrudFactory
   { 
   protected EntityMapper EntityMapper { get; set; }

    protected EntityMapper _mapper;

    public bool Create(BaseEntity entity)
    {
        try
        {
            var operation = _mapper.GetCreateStatement(entity);

            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);
        }
        catch (Exception ex)
        {
            //ManageException(ex);
        }


        return true;
    }

    public bool Delete(BaseEntity entity)
    {
        var operation = _mapper.GetDeleteStatement(entity);

        var instance = SqlDao.GetInstance();
        instance.ExecuteProcedure(operation);
        return true;
    }

    public T RCreate<T>(BaseEntity entity)
    {
        var instance = SqlDao.GetInstance();
        var operation = _mapper.GetRCreateStatement(entity);
        var lstResult = instance.ExecuteQueryProcedure(operation);
        if (lstResult.Count <= 0) return default(T);
        var dic = lstResult[0];
        var objs = _mapper.BuildObject(dic);

        return (T)Convert.ChangeType(objs, typeof(T));
    }
    public T RUpdate<T>(BaseEntity entity)
    {
        var instance = SqlDao.GetInstance();
        var operation = _mapper.GetRUpdateStatement(entity);
        var lstResult = instance.ExecuteQueryProcedure(operation);
        if (lstResult.Count <= 0) return default(T);
        var dic = lstResult[0];
        var objs = _mapper.BuildObject(dic);

        return (T)Convert.ChangeType(objs, typeof(T));
    }

    public T Retrieve<T>(BaseEntity entity)
    {
        var instance = SqlDao.GetInstance();
        var operation = _mapper.GetRetriveStatement(entity);
        var lstResult = instance.ExecuteQueryProcedure(operation);

        if (lstResult.Count <= 0) return default(T);

        var dic = lstResult[0];
        var objs = _mapper.BuildObject(dic);
        return (T)Convert.ChangeType(objs, typeof(T));
    }

        public List<T> RetrieveAll<T>()
    {
        var instance = SqlDao.GetInstance();
        var operation = _mapper.GetRetriveAllStatement();
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

    public bool Update(BaseEntity entity)
    {
        var operation = _mapper.GetUpdateStatement(entity);

        var instance = SqlDao.GetInstance();
        instance.ExecuteProcedure(operation);
        return true;
    }
}
}
