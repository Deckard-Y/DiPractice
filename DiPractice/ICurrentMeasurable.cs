using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// 電流を測定する機能を提供するインターフェイスです。
    /// このインターフェイスを実装するクラスは、特定の電流源の電流を測定し、
    /// その値をダブルとして返す責任があります。
    /// </summary>
    public interface ICurrentMeasurable
    {
        /// <summary>
        /// 電流を測定し、その値を返します。
        /// 測定される電流の単位や範囲は実装に依存します。
        /// </summary>
        /// <returns>測定された電流値（アンペア単位）</returns>
        double MeasureCurrent();
    }
}
