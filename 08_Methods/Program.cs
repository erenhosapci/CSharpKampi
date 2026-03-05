using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotolar
            //Customer --> Listele, ekle, sil, güncelle

            //Void (Geri Değer Döndürmeyen Metot)

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Özcan");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 3;
            //    int y = 4;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri : "+ name + " " + surname);
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Eren", "Hoşapcıoğlu");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum(int number1, int number2,  int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geri Değer Döndüren Metotlar

            //string customerName() 
            //{
            //    return "Buse Yıldız";     
            //}
            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region Geri Değer Döndüren String Parametreli Metotlar

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardaInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
                return cardaInfo;
            }
            string x, y, z;
            Console.Write("Ülke Adını Giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkenti Giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrak Rengini Giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geri Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 11));
            //Console.WriteLine(Sum(24, 74));
            //Console.WriteLine(Sum(54, 97));
            //Console.WriteLine(Sum(62, 101));


            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli öğrenci sınavı geçti "+ " Ortalaması: " + result;
                }
                else
                {
                    return student + " İsimli öğrenci sınavı geçemedi " + " Ortalaması: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali",25,41,21));
            Console.WriteLine(ExamResult("Ayşe",36,88,33));

            #endregion

            Console.Read();
        }
    }
}
