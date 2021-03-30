using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Drscription { get; set; }
        public string Client { get; set; }
    }
}
