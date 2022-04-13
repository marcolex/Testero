using Ingenya.DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.DataAccess.Crud
{
    public class SubCategoriaParametroCrud : CrudFactory
    {
        public SubCategoriaParametroCrud()
        {
            _mapper = new SubCategoriaParametroMapper();
        }
    }
}
