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
    public class ClienteMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdCliente = "idCliente";
        private const string DbColNombre = "Nombre";
        private const string DbColSite = "Site";
        private const string DbColTelefono = "Telefono";
        private const string DbColDireccion = "Direccion";
        private const string DbColCorreoContacto = "CorreoContacto";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var x = new Cliente()
            {
                IdCliente = GetIntValue(row, DbColIdCliente),
                Nombre = GetStringValue(row, DbColNombre),
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

                var x = new Cliente()
                {
                    IdCliente = GetIntValue(lstRows[i], DbColIdCliente),
                    Nombre = GetStringValue(lstRows[i], DbColNombre),
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
                ProcedureName = "CRE_CLIENTE"
            };

            var x = (Cliente)entity;

            operation.AddIntParam(DbColIdCliente, x.IdCliente);
            operation.AddVarcharParam(DbColNombre, x.Nombre);
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
                ProcedureName = "CRE_CLIENTE"
            };

            var x = (Cliente)entity;

            operation.AddIntParam(DbColIdCliente, x.IdCliente);
            operation.AddVarcharParam(DbColNombre, x.Nombre);
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
                ProcedureName = "DEL_CLIENTE"
            };
            var x = (Cliente)entity;

            operation.AddIntParam(DbColIdCliente, x.IdCliente);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_CLIENTE"
            };
            var x = (Cliente)entity;
            operation.AddIntParam(DbColIdCliente, x.IdCliente);
            operation.AddVarcharParam(DbColNombre, x.Nombre);
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
                ProcedureName = "RET_ALL_CLIENTE"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_CLIENTE_BY_ID"
            };

            var x = (Cliente)entity;
            operation.AddIntParam(DbColIdCliente, x.IdCliente);

            return operation;
        }
   

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_CLIENTE"
            };
            var x = (Cliente)entity;
            operation.AddIntParam(DbColIdCliente, x.IdCliente);
            operation.AddVarcharParam(DbColNombre, x.Nombre);
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
                ProcedureName = "UPDATE_CLIENTE"
            };
            var x = (Cliente)entity;
            operation.AddIntParam(DbColIdCliente, x.IdCliente);
            operation.AddVarcharParam(DbColNombre, x.Nombre);
            operation.AddVarcharParam(DbColSite, x.Site);
            operation.AddVarcharParam(DbColTelefono, x.Telefono);
            operation.AddVarcharParam(DbColDireccion, x.Direccion);
            operation.AddVarcharParam(DbColCorreoContacto, x.CorreoContacto);
            return operation;
        }
    }
}
