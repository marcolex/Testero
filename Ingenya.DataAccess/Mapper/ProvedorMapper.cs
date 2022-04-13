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
    public class ProvedorMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdProvedor = "idProvedor";
        private const string DbColNombreProyecto = "NombreProyecto";
        private const string DbColSite = "Site";
        private const string DbColTelefono = "Telefono";
        private const string DbColDireccion = "Direccion";
        private const string DbColCorreoContacto = "CorreoContacto";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var x = new Provedor()
            {
                IdProvedor = GetIntValue(row, DbColIdProvedor),
                NombreProyecto = GetStringValue(row, DbColNombreProyecto),
                Site = GetStringValue(row, DbColSite),
                Telefono = GetStringValue(row, DbColTelefono),
                Direccion = GetStringValue(row, DbColDireccion),
                CorreoContacto = GetStringValue(row, DbColCorreoContacto),

            };

            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {

                var x = new Provedor()
                {
                    IdProvedor = GetIntValue(lstRows[i], DbColIdProvedor),
                    NombreProyecto = GetStringValue(lstRows[i], DbColNombreProyecto),
                    Site = GetStringValue(lstRows[i], DbColSite),
                    Telefono = GetStringValue(lstRows[i], DbColTelefono),
                    Direccion = GetStringValue(lstRows[i], DbColDireccion),
                    CorreoContacto = GetStringValue(lstRows[i], DbColCorreoContacto),
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
                ProcedureName = "CRE_PROVEDOR"
            };

            var x = (Provedor)entity;

            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColSite, x.Site);
            operation.AddVarcharParam(DbColTelefono, x.Telefono);
            operation.AddVarcharParam(DbColDireccion, x.Direccion);
            operation.AddVarcharParam(DbColCorreoContacto, x.CorreoContacto);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PROVEDOR"
            };

            var x = (Provedor)entity;

            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColSite, x.Site);
            operation.AddVarcharParam(DbColTelefono, x.Telefono);
            operation.AddVarcharParam(DbColDireccion, x.Direccion);
            operation.AddVarcharParam(DbColCorreoContacto, x.CorreoContacto);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PROVEDOR"
            };
            var x = (Provedor)entity;

            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PROVEDOR"
            };
            var x = (Provedor)entity;
            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColSite, x.Site);
            operation.AddVarcharParam(DbColTelefono, x.Telefono);
            operation.AddVarcharParam(DbColDireccion, x.Direccion);
            operation.AddVarcharParam(DbColCorreoContacto, x.CorreoContacto);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROVEDOR"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PROVEDOR_BY_ID"
            };

            var x = (Provedor)entity;
            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PROVEDOR"
            };
            var x = (Provedor)entity;
            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColSite, x.Site);
            operation.AddVarcharParam(DbColTelefono, x.Telefono);
            operation.AddVarcharParam(DbColDireccion, x.Direccion);
            operation.AddVarcharParam(DbColCorreoContacto, x.CorreoContacto);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PROVEDOR"
            };
            var x = (Provedor)entity;
            operation.AddIntParam(DbColIdProvedor, x.IdProvedor);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColSite, x.Site);
            operation.AddVarcharParam(DbColTelefono, x.Telefono);
            operation.AddVarcharParam(DbColDireccion, x.Direccion);
            operation.AddVarcharParam(DbColCorreoContacto, x.CorreoContacto);
            return operation;
        }
    }
}
