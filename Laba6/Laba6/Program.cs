using System;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultArea = Data.Input();
            //var basket = new Basket();
            var calculate = new Calculator();

            var countPackTile = calculate.NumberPacksTiles(resultArea);
            Console.WriteLine("\nКоличество покупаемых упаковок плитки: {0}", countPackTile);

            //var tileRed = new Tile("Red", 250);
            //Console.WriteLine(tileRed);

            //basket.ChangePrice(countPackTile, tileRed.PriceOfOnePack);
            //Console.WriteLine("\nПокупки на сумму: {0}", basket.Price);

            //basket.PrintCheck();

        }
    }

  

    class Calculator
    {
        public double TotalArea(double length, double width)
        {
            return length * width;
        }

        public double AdditionalArea(double length, double width)
        {
            return length * width;
        }

        public int NumberPacksTiles(double size)
        {
            if (size % 10 == 0)
                return (int)(size / 10);
            else
                return (int)(size / 10 + 1);
        }
    }

    class Data
    {
        public static double Input()
        {
            var calculate = new Calculator();
            Console.WriteLine("Введите размеры комнаты в формате: \nДлина \nШирина");
            var totalArea = calculate.TotalArea(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Полная площадь: {0}", totalArea);
            Console.WriteLine("\nВведите размеры дополнительной прощади в формате: \nДлина \nШирина");
            var additionalArea = calculate.AdditionalArea(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Дополнительная площадь: {0}", additionalArea);
            var resultArea = totalArea - additionalArea;
            Console.WriteLine("\nИтоговая площадь: {0}", resultArea);
            return resultArea;
        }
    }
}
