using System;

namespace bufet
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1


            static void three()
            {
                three();
                try
                {
                    Console.WriteLine("Deyer daxil edin");
                    string a = Console.ReadLine();
                    int num1 = int.Parse(a);

                    Console.WriteLine("Deyer daxil edin");
                    string b = Console.ReadLine();
                    int num2 = int.Parse(b);

                    Console.WriteLine("Deyer daxil edin");
                    string c = Console.ReadLine();
                    int num3 = int.Parse(c);

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine($"en boyuk = {num1}");
                    }
                    else if (num2 > num1 && num1 > num3)
                    {
                        Console.WriteLine($"en boyuk = {num2}");
                    }
                    else if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine($"en boyuk = {num3}");
                    }
                    else
                    {
                        Console.WriteLine("ededler beraberdir");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Deyeri duzgun daxil edin");

                }



            }

            #endregion

            #region Task 2
            //static void ikinci()
            //{
            //    ikinci();
            //    try
            //    {
            //        Console.WriteLine("1 ci Ededi daxil edin");
            //        string a = Console.ReadLine();
            //        int say1 = int.Parse(a);

            //        Console.WriteLine("2 ci Ededi daxil edin");
            //        string b = Console.ReadLine();
            //        int say2 = int.Parse(b);

            //        Console.WriteLine("3 cu Ededi daxil edin");
            //        string c = Console.ReadLine();
            //        int say3 = int.Parse(c);

            //        Console.WriteLine("4 cu Ededi daxil edin");
            //        string d = Console.ReadLine();
            //        int say4 = int.Parse(d);

            //        Console.WriteLine("5 ci Ededi daxil edin");
            //        string e = Console.ReadLine();
            //        int say5 = int.Parse(e);

            //        double k = (double)(say1 + say2 + say3 + say4 + say5) / 5;
            //        Console.WriteLine(k);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Ededle simvollari bir yerde isletmek olmaz");
            //    }



            #endregion

            #region Task 3
            //    static void perimetr()
            //    {
            //    perimetr();
            //    try
            //    {

            //        Console.WriteLine("Düzbucaqlının enini daxil edin");
            //        string a = Console.ReadLine();
            //        int en = int.Parse(a);

            //        Console.WriteLine("Düzbucaqlının uzunluqunu daxil edin");
            //        string b = Console.ReadLine();
            //        int uzun = int.Parse(b);

            //        int s = (en * uzun);
            //        Console.WriteLine($"Sahesi {s}");

            //        int p = (en + uzun) * 2;
            //        Console.WriteLine($"Perimetri {p}");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Ededle simvol isletmeyin");
            //    }



            //    }
            #endregion

            #region Task 4
            //static void sade()
            //{
            //    sade();
            //    Console.WriteLine("Eded daxil edin");
            //    string numstr = Console.ReadLine();
            //    try
            //    {

            //        int num = int.Parse(numstr);
            //        int count = 0;

            //        if (num > 1)
            //        {
            //            for (int i = 0; i < num; i++)
            //            {
            //                if (num % 2 == 0)
            //                {
            //                    count++;
            //                }

            //                if (count > 2)
            //                {
            //                    Console.WriteLine("Eded murekkebdir");
            //                    break;
            //                }
            //            }

            //            if (count <= 2)
            //            {
            //                Console.WriteLine("Eded sadedir");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Duzgun daxil edin");
            //        }
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Duzgun daxil et");
            //    }

            //}

            #endregion

            #region Task 5
            //static void mertebe()
            //{
            //    mertebe();
            //    try
            //    {

            //        Console.WriteLine("Eded daxil edin");
            //        string a = Console.ReadLine();
            //        int mer = int.Parse(a);
            //        int count = 0;

            //        while (mer > 0)
            //        {
            //            mer = mer / 10;
            //            count++;
            //        }
            //        Console.WriteLine($"Mertebelidir {count}");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun formada daxil edin");

            //    }

            #endregion

            #region Task 6
            //static void natural()
            //{
            //    try
            //    {
            //        natural();
            //        Console.WriteLine("Eded daxil edin");
            //        string a = Console.ReadLine();
            //        int natural = int.Parse(a);


            //        if (natural > 1 && natural % 21 == 0)
            //        {

            //            Console.WriteLine("Eded hem 3 e hem de 7ye tam bolunur");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun daxil edin");

            //    }


            #endregion

            #region Task 7
            //static void bal()
            //{
            //    bal();
            //    try
            //    {
            //        Console.WriteLine("Balinizi daxil edin");
            //        string a = Console.ReadLine();
            //        int bal = int.Parse(a);

            //        if (bal > 0 && bal <= 100)
            //        {

            //            if (bal >= 91 && bal <= 100)
            //            {
            //                Console.WriteLine("Sizin Imtahan neticeniz A-dir");
            //            }
            //            else if (bal >= 81 && bal <= 90)
            //            {
            //                Console.WriteLine("Sizin Imtahan neticeniz B-dir");
            //            }
            //            else if (bal >= 71 && bal <= 80)
            //            {
            //                Console.WriteLine("Sizin Imtahan neticeniz C-dir");
            //            }
            //            else if (bal >= 61 && bal <= 70)
            //            {
            //                Console.WriteLine("Sizin Imtahan neticeniz D-dir");
            //            }
            //            else if (bal >= 51 && bal <= 60)
            //            {
            //                Console.WriteLine("Sizin Imtahan neticeniz E-dir");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tebrikler siz kesildiniz!!");
            //            }
            //        }
            //    }

            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Duzgun formada daxil edin");
            //    }


            #endregion

            #region Task 9
            //static void quvvet()
            //{
            //    quvvet();
            //    try
            //    {
            //        Console.WriteLine("Eded daxil edin");
            //        string a = Console.ReadLine();
            //        int say1 = int.Parse(a);

            //        Console.WriteLine("Eded daxil edin");
            //        string b = Console.ReadLine();
            //        int say2 = int.Parse(b);

            //        int count = 1;
            //        if (say1 > 1 && say2 > 1)
            //        {
            //            for (int i = 1; i <= say2; i++)
            //            {
            //                count = count * say1;

            //            }
            //            Console.WriteLine(count);
            //            #endregion
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Duzgun formada daxil edin");

            //    }





            //    }
            #endregion



        }
















    }


}
    
    

    

    


    


