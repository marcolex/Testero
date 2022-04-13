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
    public class CartaPsicometricaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdCartaPsicometrica = "idCartaPsicometrica";
        private const string DbColIdProyectoRoom = "IdProyectoRoom";
        private const string DbColDbt = "Dbt";
        private const string DbColCienPorCiento = "CienPorciento";
        private const string DbColOchentaPorCiento = "OchentaPorciento";
        private const string DbColSesentaPorCiento = "SesentaPorciento";
        private const string DbColCuarentaPorCiento = "CuarentaPorciento";
        private const string DbColVeintePorCiento = "VeintePorciento";
        private const string DbColTreintaYCincoTem = "TreintaYCincoTem";
        private const string DbColCuarentaYCincoTem = "CuarentaYCincoTem";
        private const string DbColCincuentaYCincoTem = "CincuentaYCincoTem";
        private const string DbColSesentaYCincoTem = "SesentaYCincoTem";
        private const string DbColSetentaYCincoTem = "SetentaYCincoTem";
        private const string DbColOchentaYCincoTem = "OchentaYCincoTem";
        private const string DbColNoventaYCincoTem = "NoventaYCincoTem";
        private const string DbColCientoCincoTem = "CientoCincoTem";
        private const string DbColCientoDiezTem = "CientoDiezTem";
        private const string DbColCientoQuinceTem = "CientoQuinceTem";
        private const string DbColCientoVeinteTem = "CientoVeinteTem";
        private const string DbColCientoVeintiCincoTem = "CientoVeintiCincoTem";
        private const string DbColCientoTreintaTem = "CientoTreintaTem";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var proyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };

            var x = new CartaPsicometrica()
            {

                IdCartaPsicometrica = GetIntValue(row, DbColIdCartaPsicometrica),
                 ObjProyectoRoom = proyectoRoom,
                Dbt = GetDoubleValue(row, DbColDbt),
                CienPorCiento = GetDoubleValue(row, DbColCienPorCiento),
                OchentaProCiento = GetDoubleValue(row, DbColOchentaPorCiento),
                SesentaPorCiento = GetDoubleValue(row, DbColSesentaPorCiento),
                CuarentaPorCiento = GetDoubleValue(row, DbColCuarentaPorCiento),
                VeintePorCiento = GetDoubleValue(row, DbColVeintePorCiento),
                TreintaYCientoTem = GetDoubleValue(row, DbColTreintaYCincoTem),
                CuarentaYCientoTem = GetDoubleValue(row, DbColCuarentaYCincoTem),
                CincuentaYCincoTem = GetDoubleValue(row, DbColCincuentaYCincoTem),
                SesentaYCincoTem = GetDoubleValue(row, DbColSesentaYCincoTem),
                SetentaYCincoTem = GetDoubleValue(row, DbColSetentaYCincoTem),
                OchentaYCincoTem = GetDoubleValue(row, DbColOchentaYCincoTem),
                NoventaYCincoTem = GetDoubleValue(row, DbColNoventaYCincoTem),
                CientoCincoTem = GetDoubleValue(row, DbColCientoCincoTem),
                CientoDiezTem = GetDoubleValue(row, DbColCientoDiezTem),
                CientoQuinceTem = GetDoubleValue(row, DbColCientoQuinceTem),
                CientoVeinteTem = GetDoubleValue(row, DbColCientoVeinteTem),
                CientoVeintiCincoTem = GetDoubleValue(row, DbColCientoVeintiCincoTem),
                CientoTreintaTem = GetDoubleValue(row, DbColCientoTreintaTem),

            };


            return x;
        }

        public override List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            List<BaseEntity> lista1 = new List<BaseEntity>();
            int i = 0;
            foreach (IDictionary obj in lstRows)
            {
                var proyectoRoom = new ProyectoRoom()
                {
                    IdProyectoRoom = GetIntValue(lstRows[i], DbColIdProyectoRoom),

                };


                var x = new CartaPsicometrica()
                {
                    IdCartaPsicometrica = GetIntValue(lstRows[i], DbColIdCartaPsicometrica),
                     ObjProyectoRoom = proyectoRoom,
                    Dbt = GetDoubleValue(lstRows[i], DbColDbt),
                    CienPorCiento = GetDoubleValue(lstRows[i], DbColCienPorCiento),
                    OchentaProCiento = GetDoubleValue(lstRows[i], DbColOchentaPorCiento),
                    SesentaPorCiento = GetDoubleValue(lstRows[i], DbColSesentaPorCiento),
                    CuarentaPorCiento = GetDoubleValue(lstRows[i], DbColCuarentaPorCiento),
                    VeintePorCiento = GetDoubleValue(lstRows[i], DbColVeintePorCiento),
                    TreintaYCientoTem = GetDoubleValue(lstRows[i], DbColTreintaYCincoTem),
                    CuarentaYCientoTem = GetDoubleValue(lstRows[i], DbColCuarentaYCincoTem),
                    CincuentaYCincoTem = GetDoubleValue(lstRows[i], DbColCincuentaYCincoTem),
                    SesentaYCincoTem = GetDoubleValue(lstRows[i], DbColSesentaYCincoTem),
                    SetentaYCincoTem = GetDoubleValue(lstRows[i], DbColSetentaYCincoTem),
                    OchentaYCincoTem = GetDoubleValue(lstRows[i], DbColOchentaYCincoTem),
                    NoventaYCincoTem = GetDoubleValue(lstRows[i], DbColNoventaYCincoTem),
                    CientoCincoTem = GetDoubleValue(lstRows[i], DbColCientoCincoTem),
                    CientoDiezTem = GetDoubleValue(lstRows[i], DbColCientoDiezTem),
                    CientoQuinceTem = GetDoubleValue(lstRows[i], DbColCientoQuinceTem),
                    CientoVeinteTem = GetDoubleValue(lstRows[i], DbColCientoVeinteTem),
                    CientoVeintiCincoTem = GetDoubleValue(lstRows[i], DbColCientoVeintiCincoTem),
                    CientoTreintaTem = GetDoubleValue(lstRows[i], DbColCientoTreintaTem),

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
                ProcedureName = "CRE_CARTAPSICOMETRICA"
            };
            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);
            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_CARTAPSICOMETRICA"
            };

            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);
            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_CARTAPSICOMETRICA"
            };
            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_CARTAPSICOMETRICA"
            };
            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);
            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_CARTAPSICOMETRICA"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_CARTAPSICOMETRICA_BY_ID"
            };

            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_CARTAPSICOMETRICA"
            };
            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_CARTAPSICOMETRICA"
            };
            var cartaPsicometrica = (CartaPsicometrica)entity;

            operation.AddIntParam(DbColIdCartaPsicometrica, cartaPsicometrica.IdCartaPsicometrica);
            operation.AddIntParam(DbColIdProyectoRoom, cartaPsicometrica. ObjProyectoRoom.IdProyectoRoom);
            operation.AddDoubleParam(DbColDbt, cartaPsicometrica.Dbt);
            operation.AddDoubleParam(DbColCienPorCiento, cartaPsicometrica.CienPorCiento);
            operation.AddDoubleParam(DbColOchentaPorCiento, cartaPsicometrica.OchentaProCiento);
            operation.AddDoubleParam(DbColSesentaPorCiento, cartaPsicometrica.SesentaPorCiento);
            operation.AddDoubleParam(DbColCuarentaPorCiento, cartaPsicometrica.CuarentaPorCiento);
            operation.AddDoubleParam(DbColVeintePorCiento, cartaPsicometrica.VeintePorCiento);
            operation.AddDoubleParam(DbColTreintaYCincoTem, cartaPsicometrica.TreintaYCientoTem);
            operation.AddDoubleParam(DbColCuarentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColCincuentaYCincoTem, cartaPsicometrica.CuarentaYCientoTem);
            operation.AddDoubleParam(DbColSesentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColSetentaYCincoTem, cartaPsicometrica.SesentaYCincoTem);
            operation.AddDoubleParam(DbColOchentaYCincoTem, cartaPsicometrica.OchentaYCincoTem);
            operation.AddDoubleParam(DbColNoventaYCincoTem, cartaPsicometrica.NoventaYCincoTem);
            operation.AddDoubleParam(DbColCientoCincoTem, cartaPsicometrica.CientoCincoTem);
            operation.AddDoubleParam(DbColCientoDiezTem, cartaPsicometrica.CientoDiezTem);
            operation.AddDoubleParam(DbColCientoQuinceTem, cartaPsicometrica.CientoQuinceTem);
            operation.AddDoubleParam(DbColCientoVeinteTem, cartaPsicometrica.CientoVeinteTem);
            operation.AddDoubleParam(DbColCientoVeintiCincoTem, cartaPsicometrica.CientoVeintiCincoTem);
            operation.AddDoubleParam(DbColCientoTreintaTem, cartaPsicometrica.CientoTreintaTem);
            return operation;
        }
    }
}
