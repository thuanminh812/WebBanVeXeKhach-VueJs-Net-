using System;
using System.Collections.Generic;

namespace BTLWebVeXe.Models
{
    public partial class ThongTinTuyen
    {
        public ThongTinTuyen()
        {
            ThongTinChuyens = new HashSet<ThongTinChuyen>();
            ThongTinVes = new HashSet<ThongTinVe>();
        }

        public string Tuyen { get; set; } = null!;
        public string MaTuyen { get; set; } = null!;

        public virtual ICollection<ThongTinChuyen> ThongTinChuyens { get; set; }
        public virtual ICollection<ThongTinVe> ThongTinVes { get; set; }
    }
}
