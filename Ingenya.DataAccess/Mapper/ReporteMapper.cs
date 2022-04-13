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
    public class ReporteMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdReporte = "idReporte";
        private const string DbColIdProyectoRoom = "IdProyectoRoomRep";
        private const string DbColIdFecha = "Fecha";
        private const string DbColArchivo = "Archivo";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };

            var x = new Reporte()
            {
                IdReporte = GetIntValue(row, DbColIdReporte),
                Fecha = GetDateValue(row, DbColIdFecha),
                //Valor = GetIntValue(row, DbColArchivo),
                ObjProyectoRoom = ProyectoRoom,

            };

            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {

            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var ProyectoRoom = new ProyectoRoom()
                {
                    IdProyectoRoom = GetIntValue(lstRows[i], DbColIdProyectoRoom),

                };
                var x = new Reporte()
                {
                    IdReporte = GetIntValue(lstRows[i], DbColIdReporte),
                    Fecha = GetDateValue(lstRows[i], DbColIdFecha),
                    ObjProyectoRoom = ProyectoRoom,

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
                ProcedureName = "CRE_REPORTE"
            };

            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDateTimeParam(DbColIdFecha, x.Fecha);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_REPORTE"
            };

            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDateTimeParam(DbColIdFecha, x.Fecha);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_REPORTE"
            };
            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_REPORTE"
            };
            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDateTimeParam(DbColIdFecha, x.Fecha);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_REPORTE"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_REPORTE_BY_ID"
            };

            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);
            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_REPORTE"
            };
            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDateTimeParam(DbColIdFecha, x.Fecha);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_REPORTE"
            };
            var x = (Reporte)entity;

            operation.AddIntParam(DbColIdReporte, x.IdReporte);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDateTimeParam(DbColIdFecha, x.Fecha);

            return operation;
        }
    }
}
