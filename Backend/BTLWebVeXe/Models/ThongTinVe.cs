using System;
using System.Collections.Generic;

namespace BTLWebVeXe.Models
{
    public partial class ThongTinVe
    {
        public Guid MaVe { get; set; } 
        public string? TenKh { get; set; }
        public string? SoDt { get; set; }
        public string? Tuyen { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string? LoaiVe { get; set; }

        public virtual ThongTinTuyen? TuyenNavigation { get; set; }
    }
}
