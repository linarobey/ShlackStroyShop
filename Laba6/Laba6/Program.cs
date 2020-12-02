using System;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultArea = Data.Input();
            var basket = new Basket();
            var calculate = new Calculator();

            var countPackTile = calculate.NumberPacksTiles(resultArea);
            Console.WriteLine("\nКоличество покупаемых упаковок плитки: {0}", countPackTile);

            var tileRed = new Tile("Red", 250);
            Console.WriteLine(tileRed);

            basket.ChangePrice(countPackTile, tileRed.PriceOfOnePack);
            Console.WriteLine("\nПокупки на сумму: {0}", basket.Price);

            basket.PrintCheck();

        }
    }

    class Basket
    {
        public int Price { get; set; }

        public Basket()
        {
            Price = 0;
        }

        public void ChangePrice(int count, int price)
        {
            Price += count * price;
        }

        public void PrintCheck()
        {
            if (Price < 1)
                Console.WriteLine("\nЧек не может быть напечатан: корзина пуста.");
            else
            {
                Console.WriteLine("\nЧек напечатан! Корзина очищена.");
                Price = 0;
            }
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

    class Tile
    {
        public string Name { get; set; }
        private readonly string description = null;
        public int PriceOfOnePack { get; set; }

        public Tile(string name, int price)
        {
            this.Name = name;
            this.PriceOfOnePack = price;
        }

        public override string ToString()
        {
            return $"{Name}    {PriceOfOnePack}";
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
