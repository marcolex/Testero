using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.API
{
    public class ClienteCrud : CrudFactory
    {
        public ClienteCrud()
        {
            _mapper = new ClienteMapper();
        }
    }
}
