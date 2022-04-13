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
    public class ProyectoRoomMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdProyectoRoom = "idProyectoRoom";
        private const string DbColIdRoom = "IdRoomPro";
        private const string DbColIdProyecto = "IdProyectoPro";
        private const string DbColIdProvedor = "IdProvedorPro";
        private const string DbColIdConcentracionParticula = "IdConcentracionParticulaPro";
        private const string DbColIdCartaPsicometrica = "IdCartaPsicometricaPro";
        private const string DbColIdProcesoCartaPsicometrica = "IdProcesoCartaPsicometricaPro";
        private const string DbColIdGraNivActCalorLatente = "IdGraNivActCalorLatentePro";
        private const string DbColIdGraficoNivelActividad = "IdGraficoNivelActividadPro";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var room = new Room()
            {
                IdRoom = GetIntValue(row, DbColIdRoom),

            };

            var provedor = new Provedor()
            {
                IdProvedor = GetIntValue(row, DbColIdProvedor),

            };

            var concentracionParticula = new ConcentracionParticula()
            {
                IdConcentracionParticula = GetIntValue(row, DbColIdConcentracionParticula),

            };

            var cartaPsicometrica = new CartaPsicometrica()
            {
                IdCartaPsicometrica = GetIntValue(row, DbColIdCartaPsicometrica),

            };

            var procesoCartaPsicometrica = new ProcesoCartaPsicometrica()
            {
                IdProcesoCartaPsicometrica = GetIntValue(row, DbColIdProcesoCartaPsicometrica),

            };

            var graNivActCalorLatente = new GraNivActCalorLatente()
            {
                IdGravNivActCalorLatente = GetIntValue(row, DbColIdGraNivActCalorLatente),

            };

            var graficoNivelActividad = new GraficoNivelActividad()
            {
                IdGraficoNivelActividad = GetIntValue(row, DbColIdGraficoNivelActividad),

            };

            var x = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),
                ObjRoom = room,
                ObjProvedor = provedor,
                ObjConcentracionParticula = concentracionParticula,
                ObjCartaPsicometrica = cartaPsicometrica,
                ObjProcesoCartaPsicometrica = procesoCartaPsicometrica,
                ObjGraNivActCalorLatente = graNivActCalorLatente,
                ObjGraficoNivelActividad = graficoNivelActividad,

            };

            return x;
        }


        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var room = new Room()
                {
                    IdRoom = GetIntValue(lstRows[i], DbColIdRoom),

                };

                var provedor = new Provedor()
                {
                    IdProvedor = GetIntValue(lstRows[i], DbColIdProvedor),

                };

                var concentracionParticula = new ConcentracionParticula()
                {
                    IdConcentracionParticula = GetIntValue(lstRows[i], DbColIdConcentracionParticula),

                };

                var cartaPsicometrica = new CartaPsicometrica()
                {
                    IdCartaPsicometrica = GetIntValue(lstRows[i], DbColIdCartaPsicometrica),

                };

                var procesoCartaPsicometrica = new ProcesoCartaPsicometrica()
                {
                    IdProcesoCartaPsicometrica = GetIntValue(lstRows[i], DbColIdProcesoCartaPsicometrica),

                };

                var graNivActCalorLatente = new GraNivActCalorLatente()
                {
                    IdGravNivActCalorLatente = GetIntValue(lstRows[i], DbColIdGraNivActCalorLatente),

                };

                var graficoNivelActividad = new GraficoNivelActividad()
                {
                    IdGraficoNivelActividad = GetIntValue(lstRows[i], DbColIdGraficoNivelActividad),

                };

                var x = new ProyectoRoom()
                {
                    IdProyectoRoom = GetIntValue(lstRows[i], DbColIdProyectoRoom),
                    ObjRoom = room,
                    ObjProvedor = provedor,
                    ObjConcentracionParticula = concentracionParticula,
                    ObjCartaPsicometrica = cartaPsicometrica,
                    ObjProcesoCartaPsicometrica = procesoCartaPsicometrica,
                    ObjGraNivActCalorLatente = graNivActCalorLatente,
                    ObjGraficoNivelActividad = graficoNivelActividad,

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
                ProcedureName = "CRE_PROYECTOROOM"
            };

            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.IdProyectoRoom);
            operation.AddIntParam(DbColIdRoom, x.ObjRoom.IdRoom);
            operation.AddIntParam(DbColIdProvedor, x.ObjProvedor.IdProvedor);
            operation.AddIntParam(DbColIdConcentracionParticula, x.ObjConcentracionParticula.IdConcentracionParticula);
            operation.AddIntParam(DbColIdCartaPsicometrica, x.ObjCartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.ObjProcesoCartaPsicometrica.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.ObjGraNivActCalorLatente.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdGraficoNivelActividad, x.ObjGraficoNivelActividad.IdGraficoNivelActividad);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_PROYECTOROOM"
            };

            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.IdProyectoRoom);
            operation.AddIntParam(DbColIdRoom, x.ObjRoom.IdRoom);
            operation.AddIntParam(DbColIdProvedor, x.ObjProvedor.IdProvedor);
            operation.AddIntParam(DbColIdProyecto, x.ObjProyecto.IdProyecto);
            operation.AddIntParam(DbColIdConcentracionParticula, x.ObjConcentracionParticula.IdConcentracionParticula);
            operation.AddIntParam(DbColIdCartaPsicometrica, x.ObjCartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.ObjProcesoCartaPsicometrica.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.ObjGraNivActCalorLatente.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdGraficoNivelActividad, x.ObjGraficoNivelActividad.IdGraficoNivelActividad);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_PROYECTOROOM"
            };
            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.IdProyectoRoom);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_PROYECTOROOM"
            };
            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdRoom, x.ObjRoom.IdRoom);
            operation.AddIntParam(DbColIdProyecto, x.ObjProyecto.IdProyecto);
            operation.AddIntParam(DbColIdCartaPsicometrica, x.ObjCartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProvedor, x.ObjProvedor.IdProvedor);
            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.ObjProcesoCartaPsicometrica.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdGraficoNivelActividad, x.ObjGraficoNivelActividad.IdGraficoNivelActividad);
            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.ObjGraNivActCalorLatente.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdConcentracionParticula, x.ObjConcentracionParticula.IdConcentracionParticula);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROYECTOROOM"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PROYECTOROOM_BY_ID"
            };

            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.IdProyectoRoom);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_PROYECTOROOM"
            };
            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.IdProyectoRoom);
            operation.AddIntParam(DbColIdRoom, x.ObjRoom.IdRoom);
            operation.AddIntParam(DbColIdProvedor, x.ObjProvedor.IdProvedor);
            operation.AddIntParam(DbColIdConcentracionParticula, x.ObjConcentracionParticula.IdConcentracionParticula);
            operation.AddIntParam(DbColIdCartaPsicometrica, x.ObjCartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.ObjProcesoCartaPsicometrica.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.ObjGraNivActCalorLatente.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdGraficoNivelActividad, x.ObjGraficoNivelActividad.IdGraficoNivelActividad);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_PROYECTOROOM"
            };
            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyectoRoom, x.IdProyectoRoom);
            operation.AddIntParam(DbColIdRoom, x.ObjRoom.IdRoom);
            operation.AddIntParam(DbColIdProvedor, x.ObjProvedor.IdProvedor);
            operation.AddIntParam(DbColIdConcentracionParticula, x.ObjConcentracionParticula.IdConcentracionParticula);
            operation.AddIntParam(DbColIdCartaPsicometrica, x.ObjCartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProcesoCartaPsicometrica, x.ObjProcesoCartaPsicometrica.IdProcesoCartaPsicometrica);
            operation.AddIntParam(DbColIdGraNivActCalorLatente, x.ObjGraNivActCalorLatente.IdGravNivActCalorLatente);
            operation.AddIntParam(DbColIdGraficoNivelActividad, x.ObjGraficoNivelActividad.IdGraficoNivelActividad);
            return operation;
        }

        public SqlOperation GetRetriveProyectoStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_PROYECTOROOM_BY_PROYECTO"
            };

            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyecto, x.ObjProyecto.IdProyecto);

            return operation;
        }

        public SqlOperation GetRetriveProyectoByRoomStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_PROYECTOROOM_BY_ROOM_PROYECTO"
            };

            var x = (ProyectoRoom)entity;

            operation.AddIntParam(DbColIdProyecto, x.ObjProyecto.IdProyecto);
            operation.AddIntParam(DbColIdRoom, x.ObjRoom.IdRoom);

            return operation;
        }
    }

}
