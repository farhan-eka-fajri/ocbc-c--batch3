using System;

public class Logika4{
    
    public static void Main(){
        double Nilai;
            Console.Write("Nilai: ");
            Nilai = Convert.ToDouble(Console.ReadLine());

            if (Nilai >= 85){

                Console.WriteLine("Kamu mendapat grade A");
            }
                else if (Nilai >= 65){

                Console.WriteLine("Kamu mendapat grade B");
            }
                else if (Nilai >= 45){

                Console.WriteLine("Kamu mendapat grade C");
            }
                else if (Nilai >= 25){
                    for(int i=0;i<=10;i+=2){
                        Console.WriteLine($"Saya akan belajar lebih giat {i}");
                    }

                Console.WriteLine("Kamu mendapat grade D");
            }
    }
}