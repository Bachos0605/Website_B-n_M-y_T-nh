﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DungBachComputer.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        public int MaSp { get; set; }
        public int? MaDm { get; set; }
        public string TenSp { get; set; }
        public string AnhSp { get; set; }
        public string VideoSp { get; set; }
        public string ThuongHieu { get; set; }
        public int GiaSp { get; set; }
        public bool TrangThai { get; set; }
        public bool BestSeller { get; set; }
        public DateTime CreateDate { get; set; }
        public string MotaSp { get; set; }

        public virtual DanhMucSp MaDmNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
