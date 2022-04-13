using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenya.Entities;
using Ingenya.DataAccess.Dao;

namespace Ingenya.DataAccess.Mapper
{
    internal interface ISqlStaments
    {
        SqlOperation GetCreateStatement(BaseEntity entity);
        SqlOperation GetRCreateStatement(BaseEntity entity);
        SqlOperation GetRUpdateStatement(BaseEntity entity);
        SqlOperation GetRetriveStatement(BaseEntity entity);
        SqlOperation GetRetriveAllStatement();
        SqlOperation GetRetriveProyectoStatement(BaseEntity entity);
        SqlOperation GetUpdateStatement(BaseEntity entity);
        SqlOperation GetDeleteStatement(BaseEntity entity);
    }
}
