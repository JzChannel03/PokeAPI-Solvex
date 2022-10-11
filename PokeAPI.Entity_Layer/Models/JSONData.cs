using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Entity_Layer.Models
{
    public class JSONData<T>
    {
        public IEnumerable<T>? Data { get; set; }
    }
}
