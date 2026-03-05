using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = {"samsun", "ankara", "istanbul", "adana", "batman", "kastamonu" };

            //foreach (string city in cities) 
            //{ 
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 6433, 653, 656, 123, 889, 321, 43, 65, 78, 10 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 6433, 653, 656, 123, 889, 321, 43, 65, 78, 10 };

            //foreach(int number in numbers)
            //{
            //    if(number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 6433, 653, 656, 123, 889, 321, 43, 65, 78, 10 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //string word = "Merhaba";
            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            ////Öğrenci isimlerini ve ortalamalarını saklayacak diziler
            //string[] studentName=new string[studentCount];
            //double[] studentExamAvg= new double[studentCount];

            //for(int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz : ");
            //    studentName[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi yapalım

            //    for(int j =0; j < 3; j++)
            //    {
            //        Console.Write($"{studentName[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult /3;
            //}

            ////Sınav ortalamaları
            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------------------");

            //    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilerin ortalaması ve geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
            //    }

            //    Console.WriteLine("------------------------------------------");
            //}




            #endregion

            Console.Read();
        }
    }
}
