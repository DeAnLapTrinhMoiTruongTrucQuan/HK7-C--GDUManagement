﻿using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.Service
{
    class ThoiKhoaBieuService
    {
        IDaoThoiKhoaBieu TKBIdao = new ThoiKhoaBieuImpl();

      

        //Them 1 tkb moi
        public ThoiKhoaBieu CreateThoiKhoaBieu(ThoiKhoaBieu thoiKhoaBieu)
        {
            return TKBIdao.CreateThoiKhoaBieu(thoiKhoaBieu);
        }

        public List<ThoiKhoaBieu> GetAllTKB()
        {
            return TKBIdao.GetAllTKB();
        }
    }
}
