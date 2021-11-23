using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModel.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public byte StudentCount { get; set; }
    }
}
