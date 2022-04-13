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
    public class ConcentracionParticulaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdConcentracionParticula = "idConcentracionParticula";
        private const string ObjProyectoRoom = "IdProyectoRoomCon";
        private const string DbColTiempo = "Tiempo";
        private const string DbColConcenPartiIni = "ConcenPartiIni";
        private const string DbColConcenPartiGen = "ConcenPartiGen";
        private const string DbColPartiIni = "PartiIni";
        private const string DbColPartiRetorna = "PartiRetorna";
        private const string DbColPartiFin = "PartiFin";
        private const string DbColConcenPartiFin = "ConcenPartiFin";
        private const string DbColConceIncome = "ConceIncome";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, ObjProyectoRoom),

            };

            var x = new ConcentracionParticula()
            {
                IdConcentracionParticula = GetIntValue(row, DbColIdConcentracionParticula),
                Tiempo = GetStringValue(row, DbColTiempo),
                ConcenPartiIni = GetDoubleValue(row, DbColConcenPartiIni),
                ConcenPartiGen = GetDoubleValue(row, DbColConcenPartiGen),
                PartiIni = GetDoubleValue(row, DbColPartiIni),
                PartiRetorna = GetDoubleValue(row, DbColPartiRetorna),
                PartiFin = GetDoubleValue(row, DbColPartiFin),
                ConcenPartiFin = GetDoubleValue(row, DbColConcenPartiFin),
                ObjProyectoRoom = ProyectoRoom,
                ConceIncome = GetDoubleValue(row, DbColConceIncome),
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
                    IdProyectoRoom = GetIntValue(lstRows[i], ObjProyectoRoom),

                };

                var x = new ConcentracionParticula()
                {
                    IdConcentracionParticula = GetIntValue(lstRows[i], DbColIdConcentracionParticula),
                    Tiempo = GetStringValue(lstRows[i], DbColTiempo),
                    ConcenPartiIni = GetDoubleValue(lstRows[i], DbColConcenPartiIni),
                    ConcenPartiGen = GetDoubleValue(lstRows[i], DbColConcenPartiGen),
                    PartiIni = GetDoubleValue(lstRows[i], DbColPartiIni),
                    PartiRetorna = GetDoubleValue(lstRows[i], DbColPartiRetorna),
                    PartiFin = GetDoubleValue(lstRows[i], DbColPartiFin),
                    ConcenPartiFin = GetDoubleValue(lstRows[i], DbColConcenPartiFin),
                    ObjProyectoRoom = ProyectoRoom,
                    ConceIncome = GetDoubleValue(lstRows[i], DbColConceIncome),
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
                ProcedureName = "CRE_CONCENTRACIONPARTICULA"
            };

            var x  = (ConcentracionParticula)entity;

                operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);
                operation.AddIntParam(ObjProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
                operation.AddVarcharParam(DbColTiempo, x.Tiempo);
                operation.AddDoubleParam(DbColConcenPartiIni, x.ConcenPartiIni);
                operation.AddDoubleParam(DbColConcenPartiGen, x.ConcenPartiGen);
                operation.AddDoubleParam(DbColPartiIni, x.PartiIni);
                operation.AddDoubleParam(DbColPartiRetorna, x.PartiRetorna);
                operation.AddDoubleParam(DbColPartiFin, x.PartiFin);
                operation.AddDoubleParam(DbColConcenPartiFin, x.ConcenPartiFin);
                operation.AddDoubleParam(DbColConceIncome, x.ConceIncome);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_CONCENTRACIONPARTICULA"
            };

            var x = (ConcentracionParticula)entity;

            operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);
            operation.AddIntParam(ObjProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTiempo, x.Tiempo);
            operation.AddDoubleParam(DbColConcenPartiIni, x.ConcenPartiIni);
            operation.AddDoubleParam(DbColConcenPartiGen, x.ConcenPartiGen);
            operation.AddDoubleParam(DbColPartiIni, x.PartiIni);
            operation.AddDoubleParam(DbColPartiRetorna, x.PartiRetorna);
            operation.AddDoubleParam(DbColPartiFin, x.PartiFin);
            operation.AddDoubleParam(DbColConcenPartiFin, x.ConcenPartiFin);
            operation.AddDoubleParam(DbColConceIncome, x.ConceIncome);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_CONCENTRACIONPARTICULA"
            };
            var x = (ConcentracionParticula)entity;

            operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_CONCENTRACIONPARTICULA"
            };
            var x = (ConcentracionParticula)entity;
            operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);
            operation.AddIntParam(ObjProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTiempo, x.Tiempo);
            operation.AddDoubleParam(DbColConcenPartiIni, x.ConcenPartiIni);
            operation.AddDoubleParam(DbColConcenPartiGen, x.ConcenPartiGen);
            operation.AddDoubleParam(DbColPartiIni, x.PartiIni);
            operation.AddDoubleParam(DbColPartiRetorna, x.PartiRetorna);
            operation.AddDoubleParam(DbColPartiFin, x.PartiFin);
            operation.AddDoubleParam(DbColConcenPartiFin, x.ConcenPartiFin);

            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_CONCENTRACIONPARTICULA"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_CONCENTRACIONPARTICULA_BY_ID"
            };

            var x = (ConcentracionParticula)entity;
            operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);

            return operation;
        }

        public SqlOperation GetRetriveByProRoomStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_CONCENTRACIONPARTICULA_BY_PRO_ROOM_ID"
            };

            var x = (ConcentracionParticula)entity;
            operation.AddIntParam(ObjProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);

            return operation;
        }


        



        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_CONCENTRACIONPARTICULA"
            };
            var x = (ConcentracionParticula)entity;
            operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);
            operation.AddIntParam(ObjProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTiempo, x.Tiempo);
            operation.AddDoubleParam(DbColConcenPartiIni, x.ConcenPartiIni);
            operation.AddDoubleParam(DbColConcenPartiGen, x.ConcenPartiGen);
            operation.AddDoubleParam(DbColPartiIni, x.PartiIni);
            operation.AddDoubleParam(DbColPartiRetorna, x.PartiRetorna);
            operation.AddDoubleParam(DbColPartiFin, x.PartiFin);
            operation.AddDoubleParam(DbColConcenPartiFin, x.ConcenPartiFin);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_CONCENTRACIONPARTICULA"
            };
            var x = (ConcentracionParticula)entity;
            operation.AddIntParam(DbColIdConcentracionParticula, x.IdConcentracionParticula);
            operation.AddIntParam(ObjProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColTiempo, x.Tiempo);
            operation.AddDoubleParam(DbColConcenPartiIni, x.ConcenPartiIni);
            operation.AddDoubleParam(DbColConcenPartiGen, x.ConcenPartiGen);
            operation.AddDoubleParam(DbColPartiIni, x.PartiIni);
            operation.AddDoubleParam(DbColPartiRetorna, x.PartiRetorna);
            operation.AddDoubleParam(DbColPartiFin, x.PartiFin);
            operation.AddDoubleParam(DbColConcenPartiFin, x.ConcenPartiFin);
            operation.AddDoubleParam(DbColConceIncome, x.ConceIncome);

            return operation;
        }
    }
}
