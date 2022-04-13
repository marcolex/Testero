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
    public class ParametroMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdParametro = "idParametro";
        private const string DbColIdNombreParametro = "IdNombreParametro";
        private const string DbColValor = "Valor";
        private const string DbColEditable = "Editable";
        private const string DbColFecha = "Fecha";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var nombreParametro = new NombreParametro()
            {
                IdNombreParametro = GetIntValue(row, DbColIdNombreParametro),

            };

            var x = new Parametro()
            {
                IdParametro = GetIntValue(row, DbColIdParametro),
                Valor = GetDoubleValue(row, DbColValor),
                Editable = GetIntValue(row, DbColEditable),
                Fecha = GetDateValue(row, DbColFecha),
                ObjNombreParametro = nombreParametro,

            };

            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var nombreParametro = new NombreParametro()
                {
                    IdNombreParametro = GetIntValue(lstRows[i], DbColIdNombreParametro),

                };

                var x = new Parametro()
                {
                    IdParametro = GetIntValue(lstRows[i], DbColIdParametro),
                    Valor = GetDoubleValue(lstRows[i], DbColValor),
                    Editable = GetIntValue(lstRows[i], DbColEditable),
                    Fecha = GetDateValue(lstRows[i], DbColFecha),
                    ObjNombreParametro = nombreParametro,

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
                ProcedureName = "CRE_PARAMETRO"
            };

            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            operation.AddDoubleParam(DbColEditable, x.Editable);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PARAMETRO"
            };

            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            operation.AddDoubleParam(DbColEditable, x.Editable);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);


            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PARAMETRO"
            };
            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PARAMETRO"
            };
            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            operation.AddDoubleParam(DbColEditable, x.Editable);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PARAMETRO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PARAMETRO_BY_ID"
            };

            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PARAMETRO"
            };
            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            operation.AddDoubleParam(DbColEditable, x.Editable);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PARAMETRO"
            };
            var x = (Parametro)entity;

            operation.AddIntParam(DbColIdParametro, x.IdParametro);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            operation.AddDoubleParam(DbColEditable, x.Editable);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);

            return operation;
        }
    }
}
