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
    public class ProyectoParametroMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdProyectoParametro = "idProyectoParametro";
        private const string DbColIdProyectoRoom = "IdProyectoRoomPro";
        private const string DbColIdParametro = "IdParametro";
        private const string DbColNombreParametro = "nombreParametro";
        private const string DbColValor= "Valor";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };
            var parametro = new Parametro()
            {
                IdParametro = GetIntValue(row, DbColIdParametro),

            };

            var x = new ProyectoParametro()
            {
                IdProyectoParametro = GetIntValue(row, DbColIdProyectoParametro),
                Valor = GetIntValue(row, DbColValor),
                ObjProyectoRoom = ProyectoRoom,
                ObjParametro = parametro,

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
                var parametro = new Parametro()
                {
                    IdParametro = GetIntValue(lstRows[i], DbColIdParametro),

                };

                var x = new ProyectoParametro()
                {
                    IdProyectoParametro = GetIntValue(lstRows[i], DbColIdProyectoParametro),
                    Valor = GetIntValue(lstRows[i], DbColValor),
                    ObjProyectoRoom = ProyectoRoom,
                    ObjParametro = parametro,

                };
                i = i + 1;
                lista1.Add(x);
            }
            return lista1;
        }

        public List<BaseEntity> BuildProyectoParametroObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var ProyectoRoom = new ProyectoRoom()
                {
                    IdProyectoRoom = GetIntValue(lstRows[i], DbColIdProyectoRoom),
                };

                var NombreParametro = new NombreParametro()
                {
                    Nombre = GetStringValue(lstRows[i], DbColNombreParametro),
                };

                var parametro = new Parametro()
                {
                    IdParametro = GetIntValue(lstRows[i], DbColIdParametro),
                    ObjNombreParametro = NombreParametro,
                };

                var x = new ProyectoParametro()
                {
                    IdProyectoParametro = GetIntValue(lstRows[i], DbColIdProyectoParametro),
                    Valor = GetDoubleValue(lstRows[i], DbColValor),
                    ObjProyectoRoom = ProyectoRoom,
                    ObjParametro = parametro,

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
                ProcedureName = "CRE_PROYECTOPARAMETRO"
            };

            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PROYECTOPARAMETRO"
            };

            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PROYECTOPARAMETRO"
            };
            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PROYECTOPARAMETRO"
            };
            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROYECTOPARAMETRO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PROYECTOPARAMETRO_BY_ID"
            };

            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PROYECTOPARAMETRO"
            };
            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PROYECTOPARAMETRO"
            };
            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdParametro, x.ObjParametro.IdParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);

            return operation;
        }

        public SqlOperation GetUpdateValorStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PROYECTOPARAMETROVALOR"
            };
            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoParametro, x.IdProyectoParametro);
            operation.AddDoubleParam(DbColValor, x.Valor);

            return operation;
        }

        public SqlOperation GetRetriveParametrosByRoomStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROYECTOPARAMETRO_BY_PROYECTOROOM"
            };

            var x = (ProyectoParametro)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);

            return operation;
        }

    }
}
