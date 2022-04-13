using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenya.DataAccess.Dao;
using Ingenya.Entities;

namespace Ingenya.DataAccess.Mapper
{
    public abstract class EntityMapper : IObjectMapper, ISqlStaments
    {

        public abstract List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);
        public abstract BaseEntity BuildObject(Dictionary<string, object> row);
        protected string GetStringValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is string)
                return (string)val;

            return "";
        }

        internal object GetCreateRoleStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        protected int GetIntValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is int)
                return (int)dic[attName];

            return -1;
        }

        protected double GetDoubleValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is double)
                return (double)dic[attName];

            return -1;
        }

        protected DateTime GetDateValue(Dictionary<string, object> dic, string attName)
        {
            var val = dic[attName];
            if (dic.ContainsKey(attName) && val is DateTime)
                return (DateTime)dic[attName];

            return DateTime.Now;
        }



        public abstract SqlOperation GetCreateStatement(BaseEntity entity);
        public abstract SqlOperation GetRCreateStatement(BaseEntity entity);
        public abstract SqlOperation GetRUpdateStatement(BaseEntity entity);
        public abstract SqlOperation GetRetriveStatement(BaseEntity entity);
        public abstract SqlOperation GetRetriveAllStatement();
        public abstract SqlOperation GetCreateBillStatement(BaseEntity entity);
        public abstract SqlOperation GetUpdateStatement(BaseEntity entity);
        public abstract SqlOperation GetDeleteStatement(BaseEntity entity);

        List<BaseEntity> IObjectMapper.BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            throw new NotImplementedException();
        }

        BaseEntity IObjectMapper.BuildObject(Dictionary<string, object> row)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRetriveProyectoStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        SqlOperation ISqlStaments.GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

