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

    //falta la entrada y la salida!!!

    public class BitacoraMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdBitacora = "idBitacora";
        private const string DbColFecha = "Fecha";
        private const string DbColEntrada = "Entrada";
        private const string DbColIdSalida = "Salida";
       

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
           

            var x = new Bitacora()
            {
                IdBitacora = GetIntValue(row, DbColIdBitacora),
                Fecha = GetDateValue(row, DbColFecha),

            };


            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {

                var x = new Bitacora()
                {
                    IdBitacora = GetIntValue(lstRows[i], DbColIdBitacora),
                    Fecha = GetDateValue(lstRows[i], DbColFecha),

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
                ProcedureName = "CRE_BITACORA"
            };

            var bitacora = (Bitacora)entity;

            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);
            operation.AddDateTimeParam(DbColFecha, bitacora.Fecha);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_BITACORA"
            };
            var bitacora = (Bitacora)entity;
            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);
            operation.AddDateTimeParam(DbColFecha, bitacora.Fecha);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_BITACORA"
            };
            var bitacora = (Bitacora)entity;
            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);
            operation.AddDateTimeParam(DbColFecha, bitacora.Fecha);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_BITACORA"
            };
            var bitacora = (Bitacora)entity;
            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);
            operation.AddDateTimeParam(DbColFecha, bitacora.Fecha);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_BITACORA"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_BITACORA_BY_ID"
            };

            var bitacora = (Bitacora)entity;
            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_BITACORA"
            };
            var bitacora = (Bitacora)entity;
            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);
            operation.AddDateTimeParam(DbColFecha, bitacora.Fecha);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_BITACORA"
            };
            var bitacora = (Bitacora)entity;

            operation.AddIntParam(DbColIdBitacora, bitacora.IdBitacora);
            operation.AddDateTimeParam(DbColFecha, bitacora.Fecha);
            return operation;
        }
    }
}
