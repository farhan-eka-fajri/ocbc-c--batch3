using System;

public class Logika3{

    public static void Main(){

        string Username;
        string Password;

        //digunakan untuk menginput, isikan username = ocbc dan password = bootcamp

        Console.WriteLine("Username : ");
        Username = Console.ReadLine();
        Console.WriteLine("Password : ");
        Password = Console.ReadLine();

        //logika percabangan jika username dan password sama maka kondisi pertama yang akan terpenuhi
        if (Username == "ocbc" && Password == "bootcamp"){
            Console.WriteLine("Anda berhasil Login");
        }

        //jika tidak maka kondisi kedua akan terpenuhi
        else{
            Console.WriteLine("Username atau Password anda salah");
        }
    }
}