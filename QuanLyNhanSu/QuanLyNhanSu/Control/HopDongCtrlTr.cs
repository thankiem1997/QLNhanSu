﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Object;
using QuanLyNhanSu.Model;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyNhanSu.Control
{
    class HopDongCtrlTr
    {
        public static DataTable GetListHopDong()
        {
            return HopDongModTr.GetListHopDong();

        }
    }
}
