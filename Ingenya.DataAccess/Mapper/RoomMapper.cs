using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenya.DataAccess.Dao;
using Ingenya.Entities;

namespace Ingenya.DataAccess.Mapper
{
    public class RoomMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdRoom = "idRoom";
        private const string DbColNombre = "Nombre";
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var x = new Room()
            {
                IdRoom = GetIntValue(row, DbColIdRoom),
                Nombre = GetStringValue(row, DbColNombre),

            };

            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var x = new Room()
                {

                    IdRoom = GetIntValue(lstRows[i], DbColIdRoom),
                    Nombre = GetStringValue(lstRows[i], DbColNombre),

                };
                i = i + 1;
                lista1.Add(x);
            }
            return lista1;
        }

        public override SqlOperation GetCreateBillStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_ROOM"
            };

            var x = (Room)entity;

            operation.AddIntParam(DbColIdRoom, x.IdRoom);
            operation.AddStringParam(DbColNombre, x.Nombre);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_ROOM"
            };

            var x = (Room)entity;

            operation.AddIntParam(DbColIdRoom, x.IdRoom);
            operation.AddStringParam(DbColNombre, x.Nombre);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_ROOM"
            };

            var x = (Room)entity;

            operation.AddIntParam(DbColIdRoom, x.IdRoom);
            
            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_ROOM"
            };

            var x = (Room)entity;

            operation.AddVarcharParam(DbColNombre, x.Nombre);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_ROOM"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ROOM_BY_ID"
            };

            var x = (Room)entity;

            operation.AddIntParam(DbColIdRoom, x.IdRoom);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_ROOM"
            };

            var x = (Room)entity;

            operation.AddIntParam(DbColIdRoom, x.IdRoom);
            operation.AddStringParam(DbColNombre, x.Nombre);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_ROOM"
            };

            var x = (Room)entity;

            operation.AddIntParam(DbColIdRoom, x.IdRoom);
            operation.AddStringParam(DbColNombre, x.Nombre);
            return operation;
        }
    }
}
