using System.Data;

namespace For_loop_ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //SORU: 1 - Bilgisayarın 1 - 100 aralığında bir sayıyı aklında tutmasını sağlayın.
            //        Kullanıcıya 5 hak vererek bu sayıyı tahmin etmesini isteyin
            //        Tahmini yönlendirerek kullanıcıya rehber olunuz.
            //        5.hakkını kullandığı ve bilmediği durumda hakkınız bitti yazsın.

            //int r = new Random().Next(0, 101);
            //int hak = 5;
            //for (hak = 5; hak > 0; hak--)
            //{
            //    Console.WriteLine("1 ile 100 arasında bir sayı giriniz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin < r)
            //    {
            //        Console.WriteLine("daha büyük bir sayı giriniz.");
            //    }
            //    else if (tahmin > r)
            //    {
            //        Console.WriteLine("daha küçük sayı giriniz.");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("afferin lan bildin...");
            //        Thread.Sleep(2000);
            //        break;
            //    }

            //}
            //Thread.Sleep(2000);
            //Console.Clear();
            //if (hak == 0)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"hakkınız bitti.tutulan sayı {r} idi");
            //}

            #endregion
            #region
            //SORU: 2 Aşağıdaki geometrik şekilleri for döngüsü ile ayrı ayrı kodlayınız.
            //    *
            //    **
            //    ***
            //    ****
            //    *****
            //    ******
            //    *******
            //for (int i = 1; i <=7; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            //*************
            //*           *
            //*           *
            //*           *
            //*           *
            //*           *
            //*************
            // for (int i = 1; i <= 7; i++)
            //{
            //   Console.WriteLine();
            //    for (int j = 1; j <= 13; j++)
            //    {
            //        if (i == 1 || i == 7)
            //        {
            //            Console.Write("*");
            //        }
            //        else if (j == 1 || j == 13)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //}





            //*
            //***
            //*****
            //*******
            //*********
            //***********
            //*************
            //for (int i = 1; i <= 13; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.Write("*");
            //        }


            //    }
            //    if (i % 2 == 0 )
            //    {
            //        Console.WriteLine();

            //    }

            //}

            #endregion
            #region
            //       *
            //      ***
            //     *****
            //    *******
            //   *********
            //  ***********
            // *************


            //int satir= 7;
            //for (int i = 1; i <= satir; i++)
            //{

            //    for (int j = 1; j <= satir-i; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}








            #endregion
            #region
            //("SORU: 3 - Çarpım tablosunu for döngüsü ile ekrana yazdırınız.")


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(" ");
            //        Console.Write(j + "x" + i + "=" + i * j);
            //    }
            //}




            #endregion


            Console.WriteLine();












        }
    }
}











