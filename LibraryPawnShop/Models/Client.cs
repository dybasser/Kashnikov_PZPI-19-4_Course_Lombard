using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPawnShop.Models
{
    [Serializable]
    public class Client : User
    {
        public int Rank { set; get; }
        public string Email { set; get; }
        public int Age { set; get; }
    }
}
