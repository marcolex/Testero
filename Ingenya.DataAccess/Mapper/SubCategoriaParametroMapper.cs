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
    public class SubCategoriaParametroMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdSubCategoriaParametro = "idSubCategoriaParametro";
        private const string DbColIdParametro = "IdParametroSub";
        private const string DbColNombre = "Nombre";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var parametro = new Parametro()
            {
                IdParametro = GetIntValue(row, DbColIdParametro),

            };

            var subcategoriaParametro = new SubCategoriaParametro()
            {
                IdSubCategoriaParametro = GetIntValue(row, DbColIdSubCategoriaParametro),
                Nombre = GetStringValue(row, DbColNombre),
                ObjParametro = parametro,

            };

            return subcategoriaParametro;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var parametro = new Parametro()
                {
                    IdParametro = GetIntValue(lstRows[i], DbColIdParametro),

                };
                var subCategoriaParametro = new SubCategoriaParametro()
                {
                    IdSubCategoriaParametro = GetIntValue(lstRows[i], DbColIdSubCategoriaParametro),
                    Nombre = GetStringValue(lstRows[i], DbColNombre),
                    ObjParametro = parametro,

                };
                i = i + 1;
                lista1.Add(subCategoriaParametro);
            }
            return lista1;
        }

        public override SqlOperation GetCreateBillStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_SUBCATEGORIAPARAMETRO"
            };

            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, subCategoriaParametro.Nombre);
            operation.AddIntParam(DbColIdParametro, subCategoriaParametro.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_SUBCATEGORIAPARAMETRO"
            };

            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, subCategoriaParametro.Nombre);
            operation.AddIntParam(DbColIdParametro, subCategoriaParametro.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_SUBCATEGORIAPARAMETRO"
            };
            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_SUBCATEGORIAPARAMETRO"
            };
            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, subCategoriaParametro.Nombre);
            operation.AddIntParam(DbColIdParametro, subCategoriaParametro.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_SUBCATEGORIAPARAMETRO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_SUBCATEGORIAPARAMETRO_BY_ID"
            };

            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_SUBCATEGORIAPARAMETRO"
            };
            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, subCategoriaParametro.Nombre);
            operation.AddIntParam(DbColIdParametro, subCategoriaParametro.ObjParametro.IdParametro);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_SUBCATEGORIAPARAMETRO"
            };
            var subCategoriaParametro = (SubCategoriaParametro)entity;

            operation.AddIntParam(DbColIdSubCategoriaParametro, subCategoriaParametro.IdSubCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, subCategoriaParametro.Nombre);
            operation.AddIntParam(DbColIdParametro, subCategoriaParametro.ObjParametro.IdParametro);
            return operation;
        }
    }
}
