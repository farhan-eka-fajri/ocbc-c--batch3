using System;

class Array{

    static void Main(){

        int[] aAngka = new int[5] {1,2,3,4,5};
        string[] aNama = new string[] {"Joni","Meri","David"};
        object[] aObjek = { 20.33, "Lorem ipsum", DateTime.Now, true, 'D'};

        string[] contoh = new string[4]{
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };

        //akses array
        int angka = aAngka[4];
        string contoh1 = contoh[3];
        string nama = aNama[0];
        object obj = aObjek[2];
        Console.WriteLine(angka);
        Console.WriteLine(contoh1);
        Console.WriteLine(nama);
        Console.WriteLine(obj);
        Console.Write("Press any key to continue . . ");


    }
}