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
    public class FugaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdFuga = "idFuga";
        private const string DbColIdProyectoRoom = "IdProyectoRoomFug";
        private const string DbColIdNombreParametro = "IdNombreParametroFug";
        private const string DbColCantidad = "Cantidad";
        private const string DbColArea = "Area";
        private const string DbColFactor = "Factor";
        private const string DbColFlow = "Flow";


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

            var x = new Fuga()
            {
                IdFuga = GetIntValue(row, DbColIdFuga),
                Cantidad = GetIntValue(row, DbColCantidad),
                Area = GetDoubleValue(row, DbColArea),
                Factor = GetDoubleValue(row, DbColFactor),
                Flow = GetDoubleValue(row, DbColFlow),
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

                var x = new Fuga()
                {
                    IdFuga = GetIntValue(lstRows[i], DbColIdFuga),
                    Cantidad = GetDoubleValue(lstRows[i], DbColCantidad),
                    Area = GetDoubleValue(lstRows[i], DbColArea),
                    Factor = GetDoubleValue(lstRows[i], DbColFactor),
                    Flow = GetDoubleValue(lstRows[i], DbColFlow),
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
                ProcedureName = "CRE_FUGA"
            };

            var x = (Fuga)entity;

            operation.AddIntParam(DbColIdFuga, x.IdFuga);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColCantidad, x.Cantidad);
            operation.AddDoubleParam(DbColArea, x.Area);
            operation.AddDoubleParam(DbColFactor, x.Factor);
            operation.AddDoubleParam(DbColFlow, x.Flow);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_FUGA"
            };

            var x = (Fuga)entity;

            operation.AddIntParam(DbColIdFuga, x.IdFuga);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColCantidad, x.Cantidad);
            operation.AddDoubleParam(DbColArea, x.Area);
            operation.AddDoubleParam(DbColFactor, x.Factor);
            operation.AddDoubleParam(DbColFlow, x.Flow);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_FUGA"
            };
            var x = (Fuga)entity;

            operation.AddIntParam(DbColIdFuga, x.IdFuga);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_FUGA"
            };
            var x = (Fuga)entity;
            operation.AddIntParam(DbColIdFuga, x.IdFuga);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColCantidad, x.Cantidad);
            operation.AddDoubleParam(DbColArea, x.Area);
            operation.AddDoubleParam(DbColFactor, x.Factor);
            operation.AddDoubleParam(DbColFlow, x.Flow);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_FUGA"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_FUGA_BY_ID"
            };

            var x = (Fuga)entity;
            operation.AddIntParam(DbColIdFuga, x.IdFuga);
   
            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_FUGA"
            };
            var x = (Fuga)entity;
            operation.AddIntParam(DbColIdFuga, x.IdFuga);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColCantidad, x.Cantidad);
            operation.AddDoubleParam(DbColArea, x.Area);
            operation.AddDoubleParam(DbColFactor, x.Factor);
            operation.AddDoubleParam(DbColFlow, x.Flow);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_FUGA"
            };
            var x = (Fuga)entity;
            operation.AddIntParam(DbColIdFuga, x.IdFuga);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColCantidad, x.Cantidad);
            operation.AddDoubleParam(DbColArea, x.Area);
            operation.AddDoubleParam(DbColFactor, x.Factor);
            operation.AddDoubleParam(DbColFlow, x.Flow);
            return operation;
        }

        public SqlOperation GetRetriveFugasByRoomStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_FUGA_BY_PROYEC_ROOM"
            };

            var x = (Fuga)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);

            return operation;
        }



        
    }
}
