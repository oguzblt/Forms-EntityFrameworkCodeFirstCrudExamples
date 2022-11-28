using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplarEntityCodeFirst
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string BasimYili { get; set; }
        public int SayfaSayisi { get; set; }
        public int YazarId { get; set; }
        public int TurId { get; set; }
        public Yazar Yazar { get; set; }
        public KitapTur Tur { get; set; }
        
    }
}
