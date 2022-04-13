using System.Collections.Generic;

namespace Ingenya.API.Models
{
    public interface IClienteReporsitory
    {
        void Add(Cliente item);
        IEnumerable<Cliente> GetAll();
        Cliente Find(string key);
        Cliente Remove(string key);
        void Update(Cliente item);
    }
}
