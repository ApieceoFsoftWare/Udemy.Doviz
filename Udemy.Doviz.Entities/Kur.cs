using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Doviz.Entities
{
    public class Kur
    {
        public Guid ID { get; set; }
        public Guid ParaBirimiID { get; set; }
        // Bu alandaki bölüm API den gelen bölüm 
            public decimal Satis { get; set; }
            public decimal Alis { get; set; }
            public decimal Degisim { get; set; }
            public decimal d_oran {  get; set; }
            public string d_yon { get; set; }
        // Bu alandaki bölüm API den gelen bölüm 
        public DateTime OlusturmaTarihi { get; set; }
    }

}
