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
    public class ProyectoMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdProyecto = "idProyecto";
        private const string DbColIdCliente = "IdCliente";
        private const string DbColNombreProyecto = "NombreProyecto";
        private const string DbColZona = "Zona";
        private const string DbColFecha = "Fecha";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var cliente = new Cliente()
            {
                IdCliente = GetIntValue(row, DbColIdCliente),

            };

           
            var x = new Proyecto()
            {
                IdProyecto = GetIntValue(row, DbColIdProyecto),
                NombreProyecto = GetStringValue(row, DbColNombreProyecto),
                Zona = GetStringValue(row, DbColZona),
                Fecha = GetDateValue(row, DbColFecha),
                ObjClient = cliente,

            };

            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var cliente = new Cliente()
                {
                    IdCliente = GetIntValue(lstRows[i], DbColIdCliente),

                };

               
                var x = new Proyecto()
                {
                    IdProyecto = GetIntValue(lstRows[i], DbColIdProyecto),
                    NombreProyecto = GetStringValue(lstRows[i], DbColNombreProyecto),
                    Zona = GetStringValue(lstRows[i], DbColZona),
                    Fecha = GetDateValue(lstRows[i], DbColFecha),
                    ObjClient = cliente,


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
                ProcedureName = "CRE_PROYECTO"
            };

            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColZona, x.Zona);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddIntParam(DbColIdCliente, x.ObjClient.IdCliente);
           
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PROYECTO"
            };

            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColZona, x.Zona);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddIntParam(DbColIdCliente, x.ObjClient.IdCliente);
           
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PROYECTO"
            };
            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PROYECTO"
            };
            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColZona, x.Zona);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddIntParam(DbColIdCliente, x.ObjClient.IdCliente);
           
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROYECTO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PROYECTO_BY_ID"
            };

            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PROYECTO"
            };
            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColZona, x.Zona);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddIntParam(DbColIdCliente, x.ObjClient.IdCliente);
           
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PROYECTO"
            };
            var x = (Proyecto)entity;

            operation.AddIntParam(DbColIdProyecto, x.IdProyecto);
            operation.AddVarcharParam(DbColNombreProyecto, x.NombreProyecto);
            operation.AddVarcharParam(DbColZona, x.Zona);
            operation.AddDateTimeParam(DbColFecha, x.Fecha);
            operation.AddIntParam(DbColIdCliente, x.ObjClient.IdCliente);
           
            return operation;
        }
    }
}
