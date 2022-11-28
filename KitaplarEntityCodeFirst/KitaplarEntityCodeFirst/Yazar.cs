using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplarEntityCodeFirst
{
    public class Yazar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public ICollection<Kitap> Kitaps { get; set; }
    }
}
