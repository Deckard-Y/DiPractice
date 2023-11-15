using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// 振動を測定する機能を提供するインターフェイスです。
    /// このインターフェイスを実装するクラスは、特定の環境や装置における振動の強度を測定し、
    /// その値をダブルとして返す責任があります。
    /// </summary>
    public interface IVibrationMeasurable
    {
        /// <summary>
        /// 振動を測定し、その強度を返します。
        /// 測定される振動の単位や範囲、特性（例えば周波数や振幅）は実装に依存します。
        /// </summary>
        /// <returns>測定された振動の強度</returns>
        double MeasureVibration();
    }
}
