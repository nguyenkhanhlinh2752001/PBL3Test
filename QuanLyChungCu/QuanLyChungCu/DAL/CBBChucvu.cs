﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAL
{
    class CBBChucvu
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
