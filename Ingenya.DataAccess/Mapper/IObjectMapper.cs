using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenya.Entities;

namespace Ingenya.DataAccess.Mapper
{
    internal interface IObjectMapper
    {
        List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);
        BaseEntity BuildObject(Dictionary<string, object> row);
    }

}
