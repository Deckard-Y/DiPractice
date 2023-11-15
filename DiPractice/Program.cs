using System;
using Microsoft.Extensions.DependencyInjection;

namespace DiPractice
{
    public class Program
    {
        private InstrumentA _instrumentA;

        public Program(InstrumentA instrumentA)
        {
            _instrumentA = instrumentA;
        }

        public void Run()
        {
            Console.WriteLine("温度: {0}", _instrumentA.MeasureTemperature());
            Console.WriteLine("湿度: {0}", _instrumentA.MeasureHumidity());
            Console.WriteLine("電圧: {0}", _instrumentA.MeasureVoltage());
            Console.WriteLine("振動: {0}", _instrumentA.MeasureVibration());
        }
    }

    public static class ProgramMain
    {
        public static void Main()
        {
            // DIコンテナのセットアップ
            var services = new ServiceCollection();
            services.AddTransient<InstrumentA>();
            services.AddTransient<Program>();

            // コンテナのビルド
            var serviceProvider = services.BuildServiceProvider();

            // Programクラスのインスタンスを取得し、Runメソッドを実行
            var program = serviceProvider.GetService<Program>();
            program?.Run();
        }
    }
}
