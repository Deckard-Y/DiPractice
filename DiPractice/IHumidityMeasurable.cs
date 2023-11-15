using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// 湿度を測定する機能を提供するインターフェイスです。
    /// このインターフェイスを実装するクラスは、特定の環境の湿度を測定し、
    /// その値をダブルとして返す責任があります。
    /// </summary>
    public interface IHumidityMeasurable
    {
        /// <summary>
        /// 湿度を測定し、その値を返します。
        /// 測定される湿度の単位や範囲は実装に依存します。
        /// </summary>
        /// <returns>測定された湿度値（パーセント単位）</returns>
        double MeasureHumidity();
    }
}
