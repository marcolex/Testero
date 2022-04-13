using Ingenya.DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.DataAccess.Crud
{
    public class FactoresDeHumedadCrud : CrudFactory
    {
        public FactoresDeHumedadCrud()
        {
            _mapper = new FactoresDeHumedadMapper();
        }
    }
}

