using System;

class HitungNilai4{

    public static void Main(String[]args){

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Password: ");
        string password = Console.ReadLine();

        bool isAdult = age > 18; //pernyataan 1
        bool isPasswordValid = password == "OCBC"; //pernyataan 2

        // menggunakan logika AND

        if(isAdult && isPasswordValid){
            Console.WriteLine("WELCOME TO THE CLUB!");
        }
        else{
            Console.WriteLine("Sorry, try again!");
        }
    }
}