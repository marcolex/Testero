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
    public class NombreParametroMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdNombreParametro = "idNombreParametro";
        private const string DbColMedida = "Medida";
        private const string DbColFecha = "Fecha";
        private const string DbColNombre = "Nombre";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {

            var x = new NombreParametro()
            {
                IdNombreParametro = GetIntValue(row, DbColIdNombreParametro),
                Medida = GetStringValue(row, DbColMedida),
                Fecha = GetDateValue(row, DbColFecha),
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

                var x = new NombreParametro()
                {
                    IdNombreParametro = GetIntValue(lstRows[i], DbColIdNombreParametro),
                    Medida = GetStringValue(lstRows[i], DbColMedida),
                    Fecha = GetDateValue(lstRows[i], DbColFecha),
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
                ProcedureName = "CRE_NOMBREPARAMETRO"
            };

            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);
            operation.AddStringParam(DbColMedida, x.Medida);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddStringParam(DbColNombre, x.Nombre);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_NOMBREPARAMETRO"
            };

            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);
            operation.AddStringParam(DbColMedida, x.Medida);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddStringParam(DbColNombre, x.Nombre);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_NOMBREPARAMETRO"
            };
            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_NOMBREPARAMETRO"
            };
            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);
            operation.AddStringParam(DbColMedida, x.Medida);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddStringParam(DbColNombre, x.Nombre);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_NOMBREPARAMETRO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_NOMBREPARAMETRO_BY_ID"
            };

            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_NOMBREPARAMETRO"
            };
            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);
            operation.AddStringParam(DbColMedida, x.Medida);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddStringParam(DbColNombre, x.Nombre);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_NOMBREPARAMETRO"
            };
            var x = (NombreParametro)entity;

            operation.AddIntParam(DbColIdNombreParametro, x.IdNombreParametro);
            operation.AddStringParam(DbColMedida, x.Medida);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddStringParam(DbColNombre, x.Nombre);

            return operation;
        }
    }
}
