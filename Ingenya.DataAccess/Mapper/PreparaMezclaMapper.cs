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
    public class PreparaMezclaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdPreparaMezcla = "idPreparaMezcla";
        private const string DbColIdProyectoRoom = "IdProyectoRoomPrep";
        private const string DbColIdNombreParametro = "IdNombreParametroPrep";
        private const string DbColMakeUpAir = "MakeUpAir";
        private const string DbColRetorno = "Retorno";

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

            var x = new PreparaMezcla()
            {
                IdPreparaMezcla = GetIntValue(row, DbColIdPreparaMezcla),
                MakeUpAir = GetIntValue(row, DbColMakeUpAir),
                Retorno = GetIntValue(row, DbColRetorno),
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

                var x = new PreparaMezcla()
                {
                    IdPreparaMezcla = GetIntValue(lstRows[i], DbColIdPreparaMezcla),
                    MakeUpAir = GetIntValue(lstRows[i], DbColMakeUpAir),
                    Retorno = GetIntValue(lstRows[i], DbColRetorno),
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
                ProcedureName = "CRE_PREPARAMEZCLA"
            };

            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColMakeUpAir, x.MakeUpAir);
            operation.AddDoubleParam(DbColRetorno, x.Retorno);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PREPARAMEZCLA"
            };

            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColMakeUpAir, x.MakeUpAir);
            operation.AddDoubleParam(DbColRetorno, x.Retorno);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PREPARAMEZCLA"
            };
            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PREPARAMEZCLA"
            };
            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColMakeUpAir, x.MakeUpAir);
            operation.AddDoubleParam(DbColRetorno, x.Retorno);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PREPARAMEZCLA"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PREPARAMEZCLA_BY_ID"
            };

            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);
            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PREPARAMEZCLA"
            };
            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColMakeUpAir, x.MakeUpAir);
            operation.AddDoubleParam(DbColRetorno, x.Retorno);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PREPARAMEZCLA"
            };
            var x = (PreparaMezcla)entity;

            operation.AddIntParam(DbColIdPreparaMezcla, x.IdPreparaMezcla);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColMakeUpAir, x.MakeUpAir);
            operation.AddDoubleParam(DbColRetorno, x.Retorno);

            return operation;
        }
    }
}
