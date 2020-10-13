using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeManageMent.ViewModels
{
    public class SteamModel
    {
        public string original { get; set; }
        public string sale { get; set; }
        public string cc { get; set; }
        public string language { get; set; }
        public DateTime created_at { get; set; }
    }
}
