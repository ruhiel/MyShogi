﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShogi.Model.Shogi
{
    /// <summary>
    /// 128bit型
    /// C#ではサポートされていないので自前実装
    /// </summary>
    public struct UInt128
    {
        public UInt64 p0;
        public UInt64 p1;

        /// <summary>
        /// 64bitの値を2つ指定して初期化できるコンストラクタ
        /// </summary>
        /// <param name="p0_"></param>
        /// <param name="p1_"></param>
        public UInt128(UInt64 p0_,UInt64 p1_)
        {
            p0 = p0_;
            p1 = p1_;
        }

        /// <summary>
        /// 64bitの値 2つで初期化する
        /// </summary>
        /// <param name="p0_"></param>
        /// <param name="p1_"></param>
        public void Set(UInt64 p0_,UInt64 p1_)
        {
            p0 = p0_;
            p1 = p1_;
        }

        public override bool Equals(object key)
        {
            UInt128 k = (UInt128)key;
            return p0 == k.p0 && p1 == k.p1;
        }

        public override int GetHashCode()
        {
            return (int)(p0^p1);
        }

        public static UInt128 operator +(UInt128 c1, UInt128 c2)
        {
            return new UInt128(c1.p0 + c2.p0, c1.p1 + c2.p1);
        }

        public static UInt128 operator -(UInt128 c1, UInt128 c2)
        {
            return new UInt128(c1.p0 - c2.p0, c1.p1 - c2.p1);
        }

        public static UInt128 operator &(UInt128 c1, UInt128 c2)
        {
            return new UInt128(c1.p0 & c2.p0, c1.p1 & c2.p1);
        }

        public static UInt128 operator |(UInt128 c1, UInt128 c2)
        {
            return new UInt128(c1.p0 | c2.p0, c1.p1 | c2.p1);
        }

        public static UInt128 operator ^(UInt128 c1, UInt128 c2)
        {
            return new UInt128(c1.p0 ^ c2.p0, c1.p1 ^ c2.p1);
        }

        public static UInt128 operator *(UInt128 c1, int n)
        {
            return new UInt128(c1.p0 * (UInt64)n , c1.p1 *(UInt64)n);
        }

    }
}
