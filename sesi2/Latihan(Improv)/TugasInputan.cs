using System;

public class TugasInputan{

    public static void Main(string[] args){
        //deklrasi variabel biodata
        string uname, pw, jen_kel, status;
        int age;
        bool status_jk, status_nikah;
        //input
        Console.WriteLine("=== BIODATA ===");
        Console.Write("Masukan Username: ");
        uname = Console.ReadLine();
        Console.Write("Masukan Password: ");
        pw = Console.ReadLine();
        Console.Write("Masukan umur: ");
        age = int.Parse(Console.ReadLine());

        //kondisi
        do{
            Console.Write("Masukkan Jenis Kelamin [L/P] : ");
            jen_kel = Console.ReadLine();
            status_jk = jen_kel == "L" || jen_kel =="P";
        }while(!status_jk);

        if (jen_kel == "L" || jen_kel == "P") 
        {
            Console.WriteLine($"Jenis Kelamin : {jen_kel}");
        }

        do 
        {
            Console.Write("Status Nikah (y/n) : ");
            status= Console.ReadLine();
            status_nikah = status == "y" || status == "n";
        } while(!status_nikah);


        
        //deklarasi variable aritmatika
        float nilai1,nilai2,nilai3,total,rerata;

        //inputan aritmatika
        Console.WriteLine("=== ARITMATIKA ===");
        Console.Write("Masukan nilai pertama : ");
        nilai1 = float.Parse(Console.ReadLine());
        Console.Write("Masukan nilai kedua: ");
        nilai2 = float.Parse(Console.ReadLine());
        Console.Write("Masukan nilai ketiga: ");
        nilai3 = float.Parse(Console.ReadLine());

        //perhitungan
        total = nilai1 + nilai2 + nilai3;
        rerata = total/3;


        //output
        Console.WriteLine("===============================");
        Console.WriteLine("Terima Kasih telah menginput!");
        Console.WriteLine($"Username = {uname}");
        Console.WriteLine($"umur = {age}");
        Console.WriteLine($"Jenis Kelamin = {jen_kel}");
        Console.WriteLine($"Status Nikah = {status_nikah}");
        Console.WriteLine($"Total Nilai = {total}");
        Console.WriteLine($"Rata-rata nilai = {rerata}");







    }
    
}