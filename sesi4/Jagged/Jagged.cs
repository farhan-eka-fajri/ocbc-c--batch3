using System;

class Jagged{

    static void Main(){

        int [][] jagged = new int [3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;


        //Menyimpan nilai-nilai dalam array pertama
        for(i=0;i<4;i++){
            jagged[0][i] = i;
        }

         //Menyimpan nilai-nilai dalam array kedua
        for(i=0;i<3;i++){
            jagged[1][i] = i;
        }

        //Menyimpan nilai-nilai dalam array pertama
        for(i=0;i<5;i++){
            jagged[2][i] = i;
        }

        //menampilkan nilai-nilai array pertama
        for (i = 0; i< 4; i++){
            Console.Write(jagged[0][i] +" ");
            
        }
        Console.WriteLine();
        //menampilkan nilai-nilai array kedua
        for (i = 0; i< 3; i++){
            Console.Write(jagged[1][i] +" ");
        
        }
        Console.WriteLine();
        //menampilkan nilai-nilai array ketiga
        for (i = 0; i< 5; i++){
            Console.Write(jagged[2][i] +" ");
        
        }
        Console.WriteLine();
        
    }
}