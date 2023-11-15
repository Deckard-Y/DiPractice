using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// 温度を測定する機能を提供するインターフェイスです。
    /// このインターフェイスを実装するクラスは、特定の環境の温度を測定し、
    /// その値をダブルとして返す責任があります。
    /// </summary>
    public interface ITemperatureMeasurable
    {
        /// <summary>
        /// 温度を測定し、その値を返します。
        /// 測定される温度の単位や範囲は実装に依存します。
        /// </summary>
        /// <returns>測定された温度値（摂氏または華氏）</returns>
        double MeasureTemperature();
    }
}
