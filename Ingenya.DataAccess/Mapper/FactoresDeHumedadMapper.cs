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
   
    public class FactoresDeHumedadMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdFactoresDeHumedad = "idFactorDeHumedad";
        private const string DbColIdProyectoRoom = "IdProyectoRoomFact";
        private const string DbColIdParametro = "IdParametroFct";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var proyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };
            var parametro = new Parametro()
            {
                IdParametro = GetIntValue(row, DbColIdParametro),

            };
            var x = new FactoresDeHumedad()
            {
                IdFactoresDeHumedad = GetIntValue(row, DbColIdFactoresDeHumedad),
                ObjProyectoRoom = proyectoRoom,
                ObjParametro = parametro,

            };

            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var proyectoRoom = new ProyectoRoom()
                {
                    IdProyectoRoom = GetIntValue(lstRows[i], DbColIdProyectoRoom),

                };
                var parametro = new Parametro()
                {
                    IdParametro = GetIntValue(lstRows[i], DbColIdParametro),

                };
                var x = new FactoresDeHumedad()
                {
                    IdFactoresDeHumedad = GetIntValue(lstRows[i], DbColIdFactoresDeHumedad),
                    ObjProyectoRoom = proyectoRoom,
                    ObjParametro = parametro,

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
                ProcedureName = "CRE_FACTORHUMEDAD"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_FACTORHUMEDAD"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_FACTORHUMEDAD"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_FACTORHUMEDAD"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_FACTORHUMEDAD"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_FACTORHUMEDAD_BY_ID"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_FACTORHUMEDAD"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_FACTORHUMEDAD"
            };

            var x = (FactoresDeHumedad)entity;

            operation.AddIntParam(DbColIdFactoresDeHumedad, x.IdFactoresDeHumedad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            return operation;
        }
    }
}
