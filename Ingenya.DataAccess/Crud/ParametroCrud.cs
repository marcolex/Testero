using Ingenya.DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.DataAccess.Crud
{
    public class ParametroCrud : CrudFactory
    {
        public ParametroCrud()
        {
            _mapper = new ParametroMapper();
        }
    }
}
