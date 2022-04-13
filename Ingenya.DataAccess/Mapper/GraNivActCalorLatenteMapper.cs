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
    public class GraNivActCalorLatenteMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
    
        private const string DbColIdGraNivActCalorLatente = "idGraNivActCalorLatente";
        private const string DbColIdProyectoRoom = "idProyectoRoomGraNiv";
        private const string DbColTipoAplicacion = "TipoAplicacion";
        private const string DbColPorcentaje = "Porcentaje";
        private const string DbColCalorSensible = "CalorSensible";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };

            var x = new GraNivActCalorLatente()
            {
                IdGravNivActCalorLatente = GetIntValue(row, DbColIdGraNivActCalorLatente),
                TipoAplicacion = GetStringValue(row, DbColTipoAplicacion),
                Porcentaje = GetDoubleValue(row, DbColPorcentaje),
                CalorSensible = GetDoubleValue(row, DbColCalorSensible),
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


                var x = new GraNivActCalorLatente()
                {
                    IdGravNivActCalorLatente = GetIntValue(lstRows[i], DbColIdGraNivActCalorLatente),
                    TipoAplicacion = GetStringValue(lstRows[i], DbColTipoAplicacion),
                    Porcentaje = GetDoubleValue(lstRows[i], DbColPorcentaje),
                    CalorSensible = GetDoubleValue(lstRows[i], DbColCalorSensible),
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
                ProcedureName = "CRE_GRANIVACTCALORLATENTE"
            };

            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTipoAplicacion, x.TipoAplicacion);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_GRANIVACTCALORLATENTE"
            };

            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTipoAplicacion, x.TipoAplicacion);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_GRANIVACTCALORLATENTE"
            };
            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_GRANIVACTCALORLATENTE"
            };
            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTipoAplicacion, x.TipoAplicacion);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_GRANIVACTCALORLATENTE"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_GRANIVACTCALORLATENTE_BY_ID"
            };

            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_GRANIVACTCALORLATENTE"
            };
            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTipoAplicacion, x.TipoAplicacion);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_GRANIVACTCALORLATENTE"
            };
            var x = (GraNivActCalorLatente)entity;

            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTipoAplicacion, x.TipoAplicacion);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }
    }
}
