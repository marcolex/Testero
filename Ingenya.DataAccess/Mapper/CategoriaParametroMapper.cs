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
    public class CategoriaParametroMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdCategoriaParametro = "idCategoriaParametro";
        private const string DbColIdSubCategoriaParametro = "IdSubCategoriaParametro";
        private const string DbColNombre = "Nombre";
 
        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var subCategoriaParametro = new SubCategoriaParametro()
            {
                IdSubCategoriaParametro = GetIntValue(row, DbColIdSubCategoriaParametro),

            };

            var categoriaParametro = new CategoriaParametro()
            {
                IdCategoriaParametro = GetIntValue(row, DbColIdCategoriaParametro),
                Nombre = GetStringValue(row, DbColNombre),
                ObjSubCategoriaParametro = subCategoriaParametro,

            };

            return categoriaParametro;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i=0;
            foreach (IDictionary obj in lstRows)
            {
                 var subCategoriaParametro = new SubCategoriaParametro()
            {
                IdSubCategoriaParametro = GetIntValue(lstRows[i], DbColIdSubCategoriaParametro),

            };
            var categoriaParametro = new CategoriaParametro()
            {
                IdCategoriaParametro = GetIntValue(lstRows[i], DbColIdCategoriaParametro),
                Nombre = GetStringValue(lstRows[i], DbColNombre),
                ObjSubCategoriaParametro = subCategoriaParametro,

            };
                i = i + 1;
                lista1.Add(categoriaParametro);
            }
            return lista1;
        }

        public override SqlOperation GetCreateBillStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_CATEGORIAPARAMETRO"
            };

            var categoriaParametro = (CategoriaParametro)entity;

            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, categoriaParametro.Nombre);
            operation.AddIntParam(DbColIdSubCategoriaParametro,categoriaParametro.ObjSubCategoriaParametro.IdSubCategoriaParametro);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_CATEGORIAPARAMETRO"
            };

            var categoriaParametro = (CategoriaParametro)entity;

            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, categoriaParametro.Nombre);
            operation.AddIntParam(DbColIdSubCategoriaParametro,categoriaParametro.ObjSubCategoriaParametro.IdSubCategoriaParametro);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_CATEGORIAPARAMETRO"
            };
            var categoriaParametro = (CategoriaParametro)entity;
            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
           var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_CATEGORIAPARAMETRO"
            };
              var categoriaParametro = (CategoriaParametro)entity;

            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, categoriaParametro.Nombre);
            operation.AddIntParam(DbColIdSubCategoriaParametro,categoriaParametro.ObjSubCategoriaParametro.IdSubCategoriaParametro);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
           var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_CATEGORIAPARAMETRO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_CATEGORIAPARAMETRO_BY_ID"
            };

           var categoriaParametro = (CategoriaParametro)entity;

            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
           var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_CATEGORIAPARAMETRO"
            };
            var categoriaParametro = (CategoriaParametro)entity;

            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, categoriaParametro.Nombre);
            operation.AddIntParam(DbColIdSubCategoriaParametro,categoriaParametro.ObjSubCategoriaParametro.IdSubCategoriaParametro);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
             var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_CATEGORIAPARAMETRO"
            };
            var categoriaParametro = (CategoriaParametro)entity;

            operation.AddIntParam(DbColIdCategoriaParametro, categoriaParametro.IdCategoriaParametro);
            operation.AddVarcharParam(DbColNombre, categoriaParametro.Nombre);
            operation.AddIntParam(DbColIdSubCategoriaParametro,categoriaParametro.ObjSubCategoriaParametro.IdSubCategoriaParametro);
            return operation;
        }
    }
}
