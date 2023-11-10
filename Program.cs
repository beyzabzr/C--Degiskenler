using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            //int deger = 2;
            //string degisken = null;
            //string Degisken = null;
            //string degisken_veri = null;

            Console.WriteLine("");
            byte b = 5; //Bellekte 1 byte yer kaplar (0 - 255)
            sbyte c = 5; //Bellekte 1 byte yer kaplar (-128 - 227)

            short s = 5; //Bellekte 2 byte yer kaplar (-32,768 - 32,768)
            ushort us = 5; //Bellekte 2 byte yer kaplar (0 - 65,365)

            Int16 i16 = 2; //2 byte 
            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong il = 4; //8 byte

            // REEL SAYILAR :
            float f = 5; //4 byte  
            double d = 5; //8 byte
            decimal de = 5; //16 byte

            char ch = '2'; // 2 byte
            string str = "Beyza"; // Sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now; // O anda ki tarihi ve saati getirir
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Beyza Bozer";
            string ad = "Beyza";
            string soyad = "Bozer";
            string tamIsim = ad + " " + soyad;

            //Integer tanimlama sekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean
            bool bool1 = 10 > 2;

            //Degisken Dönüsümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString(); //int degiskenini stringe cevirmek icin
            Console.WriteLine(yeniDeger); // 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); //40

            //Date Time
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}