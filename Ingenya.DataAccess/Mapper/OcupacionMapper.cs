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
    public class OcupacionMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdOcupacion = "idOcupacion";
        private const string DbColIdNombreParametro = "IdNombreParametroOcup";
        private const string DbColIdProyectoRoom = "IdProyectoRoomOcup";
        private const string DbColPorcentaje = "Porcentaje";
        private const string DbColGeneracionXPersona = "GeneracionXPersona";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };
            var nombreParametro = new NombreParametro()
            {
                IdNombreParametro = GetIntValue(row, DbColIdNombreParametro),

            };

            var x = new Ocupacion()
            {
                IdOcupacion = GetIntValue(row, DbColIdOcupacion),
                Porcentaje = GetIntValue(row, DbColPorcentaje),
                GeneracionXPersona = GetIntValue(row, DbColGeneracionXPersona),
                ObjProyectoRoom = ProyectoRoom,
                ObjNombreParametro = nombreParametro

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
                var nombreParametro = new NombreParametro()
                {
                    IdNombreParametro = GetIntValue(lstRows[i], DbColIdNombreParametro),

                };

                var x = new Ocupacion()
                {
                    IdOcupacion = GetIntValue(lstRows[i], DbColIdOcupacion),
                    Porcentaje = GetIntValue(lstRows[i], DbColPorcentaje),
                    GeneracionXPersona = GetIntValue(lstRows[i], DbColGeneracionXPersona),
                    ObjProyectoRoom = ProyectoRoom,
                    ObjNombreParametro = nombreParametro

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
                ProcedureName = "CRE_OCUPACION"
            };

            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddIntParam(DbColGeneracionXPersona, x.GeneracionXPersona);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_OCUPACION"
            };

            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddIntParam(DbColGeneracionXPersona, x.GeneracionXPersona);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_OCUPACION"
            };
            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_OCUPACION"
            };
            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddIntParam(DbColGeneracionXPersona, x.GeneracionXPersona);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_OCUPACION"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_OCUPACION_BY_ID"
            };

            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_OCUPACION"
            };
            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddIntParam(DbColGeneracionXPersona, x.GeneracionXPersona);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_OCUPACION"
            };
            var x = (Ocupacion)entity;

            operation.AddIntParam(DbColIdOcupacion, x.IdOcupacion);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddIntParam(DbColGeneracionXPersona, x.GeneracionXPersona);

            return operation;
        }
    }
}
