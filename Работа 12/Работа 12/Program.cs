using System;
using System.IO;
using System.Text;
namespace Rabota_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string buyFile, discountFile, line, line2;
            decimal totalCost = 0, discount = 0, price, discountPercentage, threshold, finalCost;
            int quantity;
            Console.Write("Введите имя файла с чеком: ");
            buyFile = Environment.CurrentDirectory + @"\" + Console.ReadLine() + ".txt";
            Console.Write("Введите имя файла со скидками: ");
            discountFile = Environment.CurrentDirectory + @"\" + Console.ReadLine() + ".txt";

            StreamReader buyReader = new StreamReader(buyFile);

            while ((line = buyReader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                quantity = int.Parse(parts[2]);
                price = decimal.Parse(parts[3]);
                totalCost += quantity * price;
            }
            StreamReader discountReader = new StreamReader(discountFile);
            while ((line2 = discountReader.ReadLine()) != null)
            {
                string[] parts = line2.Split(',');
                discountPercentage = decimal.Parse(parts[0]);
                threshold = decimal.Parse(parts[1]);
                if (totalCost >= threshold)
                {
                    discount = totalCost * discountPercentage / 100;
                }
            }
            finalCost = totalCost - discount;
            Console.WriteLine($"Общая стоимость покупки: {totalCost}");
            Console.WriteLine($"Скидка: {discount}");
            Console.WriteLine($"Итоговая стоимость с учетом скидки: {finalCost}");
            Console.ReadKey();
        }
    }
}
