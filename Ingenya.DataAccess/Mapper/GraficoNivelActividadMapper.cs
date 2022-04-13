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
    public class GraficoNivelActividadMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdGraficoNivelActividad = "idGraficoNivelActividad";
        private const string DbColIdNombreParametro = "IdNombreParametroGarf";
        private const string DbColIdProyectoRoom = "IdProyectoRoomGarf";
        private const string DbColPorcentaje = "Porcentaje";
        private const string DbColCalorSensible = "CalorSensible";

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

            var x = new GraficoNivelActividad()
            {
                IdGraficoNivelActividad = GetIntValue(row, DbColIdGraficoNivelActividad),
                Porcentaje = GetIntValue(row, DbColPorcentaje),
                CalorSensible = GetDoubleValue(row, DbColCalorSensible),
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

                var x = new GraficoNivelActividad()
                {
                    IdGraficoNivelActividad = GetIntValue(lstRows[i], DbColIdGraficoNivelActividad),
                    Porcentaje = GetIntValue(lstRows[i], DbColPorcentaje),
                    CalorSensible = GetDoubleValue(lstRows[i], DbColCalorSensible),
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
                ProcedureName = "CRE_GRAFICONIVELACTIVIDAD"
            };

            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_GRAFICONIVELACTIVIDAD"
            };

            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_GRAFICONIVELACTIVIDAD"
            };
            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_GRAFICONIVELACTIVIDAD"
            };
            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_GRAFICONIVELACTIVIDAD"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_GRAFICONIVELACTIVIDAD_BY_ID"
            };

            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_GRAFICONIVELACTIVIDAD"
            };
            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);

            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_GRAFICONIVELACTIVIDAD"
            };
            var x = (GraficoNivelActividad)entity;

            operation.AddIntParam(DbColIdGraficoNivelActividad, x.IdGraficoNivelActividad);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddIntParam(DbColIdNombreParametro, x.ObjNombreParametro.IdNombreParametro);
            operation.AddDoubleParam(DbColPorcentaje, x.Porcentaje);
            operation.AddDoubleParam(DbColCalorSensible, x.CalorSensible);
            return operation;
        }
    }
}
