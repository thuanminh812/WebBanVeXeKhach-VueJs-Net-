using System;
using System.Collections.Generic;

namespace BTLWebVeXe.Models
{
    public partial class ThongTinChuyen
    {

        public string MaChuyen { get; set; } = null!;
        public string? Tuyen { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual ThongTinTuyen? TuyenNavigation { get; set; }
    }
}
