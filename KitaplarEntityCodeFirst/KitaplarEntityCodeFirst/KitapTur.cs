using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplarEntityCodeFirst
{
    public class KitapTur
    {
        public int Id { get; set; }
        public string TurAd { get; set; }
        public ICollection<Kitap> Kitaps { get; set; }
    }
}
