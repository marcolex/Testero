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
    public class ProcesoCartaPsicometricaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdProcesoCartaPsicometrica = "idProcesoCartaPsicometrica";
        private const string DbColIdProyectoRoom = "IdProyectoRoomPro";
        private const string DbColPunto = "Punto";
        private const string DbColDbt = "Dbt";
        private const string DbColW = "W";
        private const string DbColDescription= "Descripcion";
        private const string DbColTipo = "Tipo";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };

            var x = new ProcesoCartaPsicometrica()
            {
                IdProcesoCartaPsicometrica = GetIntValue(row, DbColIdProcesoCartaPsicometrica),
                Punto = GetIntValue(row, DbColPunto),
                Dbt = GetIntValue(row, DbColDbt),
                ObjProyectoRoom = ProyectoRoom,
                W = GetIntValue(row, DbColW),
                Description = GetStringValue(row, DbColDescription),
                Tipo = GetStringValue(row, DbColTipo),

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

                var x = new ProcesoCartaPsicometrica()
                {
                    IdProcesoCartaPsicometrica = GetIntValue(lstRows[i], DbColIdProcesoCartaPsicometrica),
                    Punto = GetIntValue(lstRows[i], DbColPunto),
                    Dbt = GetIntValue(lstRows[i], DbColDbt),
                    ObjProyectoRoom = ProyectoRoom,
                    W = GetIntValue(lstRows[i], DbColW),
                    Description = GetStringValue(lstRows[i], DbColDescription),
                    Tipo = GetStringValue(lstRows[i], DbColTipo),

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
                ProcedureName = "CRE_PROCESOCARTAPSICOMETRICA"
            };

            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColPunto, x.Punto);
            operation.AddDoubleParam(DbColDbt, x.Dbt);
            operation.AddDoubleParam(DbColW, x.W);
            operation.AddVarcharParam(DbColDescription, x.Description);
            operation.AddVarcharParam(DbColTipo, x.Tipo);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PROCESOCARTAPSICOMETRICA"
            };

            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColPunto, x.Punto);
            operation.AddDoubleParam(DbColDbt, x.Dbt);
            operation.AddDoubleParam(DbColW, x.W);
            operation.AddVarcharParam(DbColDescription, x.Description);
            operation.AddVarcharParam(DbColTipo, x.Tipo);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PROCESOCARTAPSICOMETRICA"
            };
            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PROCESOCARTAPSICOMETRICA"
            };
            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColPunto, x.Punto);
            operation.AddDoubleParam(DbColDbt, x.Dbt);
            operation.AddDoubleParam(DbColW, x.W);
            operation.AddVarcharParam(DbColDescription, x.Description);
            operation.AddVarcharParam(DbColTipo, x.Tipo);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROCESOCARTAPSICOMETRICA"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PROCESOCARTAPSICOMETRICA_BY_ID"
            };

            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);
            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PROCESOCARTAPSICOMETRICA"
            };
            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColPunto, x.Punto);
            operation.AddDoubleParam(DbColDbt, x.Dbt);
            operation.AddDoubleParam(DbColW, x.W);
            operation.AddVarcharParam(DbColDescription, x.Description);
            operation.AddVarcharParam(DbColTipo, x.Tipo);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PROCESOCARTAPSICOMETRICA"
            };
            var x = (ProcesoCartaPsicometrica)entity;

            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColPunto, x.Punto);
            operation.AddDoubleParam(DbColDbt, x.Dbt);
            operation.AddDoubleParam(DbColW, x.W);
            operation.AddVarcharParam(DbColDescription, x.Description);
            operation.AddVarcharParam(DbColTipo, x.Tipo);

            return operation;
        }
    }
}
