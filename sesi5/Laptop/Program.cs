﻿using System;

namespace testlaptop
{
    class Program
    {
        static void Main(string[] args)
        {
            //instant objek
            Laptop laptop1 = new Laptop();

            //akses atribut
            laptop1.merk="lenovo";
            laptop1.ram=4;
            laptop1.memory=128;

            //tampilkan
            Console.WriteLine("\n Merk Laptop adalah {0},", laptop1.merk);
            Console.WriteLine("Kapasitas Ram ada {0},", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0},", laptop1.memory);

            //akses method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
