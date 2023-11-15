using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// 電圧を測定する機能を提供するインターフェイスです。
    /// このインターフェイスを実装するクラスは、特定の電圧源の電圧を測定し、
    /// その値をダブルとして返す責任があります。
    /// </summary>
    public interface IVoltageMeasurable
    {
        /// <summary>
        /// 電圧を測定し、その値を返します。
        /// 測定される電圧の単位や範囲は実装に依存します。
        /// </summary>
        /// <returns>測定された電圧値（ボルト単位）</returns>
        double MeasureVoltage();
    }
}
