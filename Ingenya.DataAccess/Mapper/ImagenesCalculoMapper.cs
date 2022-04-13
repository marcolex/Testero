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
    public class ImagenesCalculoMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdImagenesCalculo = "idImagenesCalculo";
        private const string DbColIdProyectoRoom = "IdProyectoRoomImgs";
        private const string DbColNombre = "Nombre";
        private const string DbColImagen = "Imagen";

        public override BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ProyectoRoom = new ProyectoRoom()
            {
                IdProyectoRoom = GetIntValue(row, DbColIdProyectoRoom),

            };

            var x = new ImagenesCalculo()
            {
               IdImagenesCalculo = GetIntValue(row, DbColIdImagenesCalculo),
               Nombre = GetStringValue(row, DbColNombre),
               ObjProyectoRoom = ProyectoRoom,

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


                var x = new ImagenesCalculo()
                {
                    IdImagenesCalculo = GetIntValue(lstRows[i], DbColIdImagenesCalculo),
                    Nombre = GetStringValue(lstRows[i], DbColNombre),
                    ObjProyectoRoom = ProyectoRoom,

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
                ProcedureName = "CRE_IMAGENESCALCULO"
            };

            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColNombre, x.Nombre);

            return operation;
        }

        public override SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_IMAGENESCALCULO"
            };

            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColNombre, x.Nombre);

            return operation;
        }

        public override SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_IMAGENESCALCULO"
            };
            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);

            return operation;
        }

        public override SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RCRE_IMAGENESCALCULO"
            };
            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColNombre, x.Nombre);


            return operation;
        }

        public override SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_IMAGENESCALCULO"
            };
            return operation;
        }

        public override SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_IMAGENESCALCULO_BY_ID"
            };

            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);

            return operation;
        }

        public override SqlOperation GetRUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RUPDATE_IMAGENESCALCULO"
            };
            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColNombre, x.Nombre);
            return operation;
        }

        public override SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPDATE_IMAGENESCALCULO"
            };
            var x = (ImagenesCalculo)entity;

            operation.AddIntParam(DbColIdImagenesCalculo, x.IdImagenesCalculo);
            operation.AddIntParam(DbColIdProyectoRoom, x.ObjProyectoRoom.IdProyectoRoom);
            operation.AddVarcharParam(DbColNombre, x.Nombre);

            return operation;
        }
    }
}
