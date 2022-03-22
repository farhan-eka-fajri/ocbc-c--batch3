using System;


public class Assignment {
    public static void Main() {
    Kesini:
    Console.WriteLine("=========Selamat Datang Di Menu Silahkan Buat Pilihan : ==============");
    Console.WriteLine("1 Segitiga Alfabet");
    Console.WriteLine("2 Segitiga Angka");
    Console.WriteLine("3 Faktorial");
    Console.WriteLine("4 Balik Angka");
    Console.WriteLine("5 Convert Angka To String");
    Console.WriteLine("6 Balik Huruf");
    Console.WriteLine("7 About Me");
    Console.WriteLine("8 Exit");
    Console.Write("Masukkan Pilihan: ");
    int pilih;
    pilih = int.Parse(Console.ReadLine());
    
    
      switch(pilih) {

        case 1:
          char ch='A';      
       int i, j, k, m;      
       for(i=1; i<=5; i++)      
       {      
        for(j=5; j>=i; j--)      
         Console.Write(" ");      
        for(k=1;k<=i;k++)      
         Console.Write(ch++);      
        ch--;      
        for(m=1;m<i;m++)      
         Console.Write(--ch);      
        Console.Write("\n");      
        ch='A';      
       }   
          break;
    
        case 2:
         int  ii,jj,kk,ll,nn;           
       Console.Write("Enter the Range=");    
       nn= int.Parse(Console.ReadLine());     
       for(ii=1; ii<=nn; ii++)      
       {          
        for(jj=1; jj<=nn-ii; jj++)      
        {      
         Console.Write(" ");      
        }      
        for(kk=1;kk<=ii;kk++)      
        {      
         Console.Write(kk);      
        }      
        for(ll=ii-1;ll>=1;ll--)      
        {      
        Console.Write(ll);      
        }      
        Console.Write("\n");      
       }      
          break;
    
        case 3:
         int iii,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= int.Parse(Console.ReadLine());     
       for(iii=1;iii<=number;iii++){      
        fact=fact*iii;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);  

          break;

        case 4:
        int  n, reverse=0, rem;           
        Console.Write("Enter a number: ");      
        n= int.Parse(Console.ReadLine());     
        while(n!=0)      
        {      
        rem=n%10;        
        reverse=reverse*10+rem;      
        n/=10;      
        }      
        Console.Write("Reversed Number: "+reverse);  
        break;
        case 5:
        int nnn,sum=0,r;     
       Console.Write("Enter the Number= ");    
       nnn= int.Parse(Console.ReadLine());     
       while(nnn>0)      
       {      
        r=nnn%10;      
        sum=sum*10+r;      
        nnn=nnn/10;      
       }      
       nnn=sum;      
       while(nnn>0)      
       {      
        r=nnn%10;      
        switch(r)      
        {      
         case 1:      
         Console.Write("one ");  
         break;      
         case 2:      
         Console.Write("two ");      
         break;      
         case 3:      
         Console.Write("three ");    
         break;      
         case 4:      
         Console.Write("four ");    
         break;      
         case 5:      
         Console.Write("five ");    
         break;      
         case 6:      
         Console.Write("six ");     
         break;      
         case 7:    
         Console.Write("seven ");    
         break;    
         case 8:      
         Console.Write("eight ");      
         break;      
         case 9:      
         Console.Write("nine ");    
         break;      
         case 0:      
         Console.Write("zero ");    
         break;      
         default:      
         Console.Write("tttt ");      
         break;      
        }//end of switch      
        nnn=nnn/10;      
       }//end of while loop   
        break;
        case 6:
      Console.WriteLine("Masukan huruf : ");
      string str = Console.ReadLine();
      char[] arr = str.ToCharArray();
      Console.WriteLine("Original String: "+str);
      // Reverse
      Array.Reverse(arr);
      Console.WriteLine("Reversed String: "+new string(arr));
      break;
        case 7:
        Console.WriteLine("Nama = Farhan Eka Fajri");
        Console.WriteLine("Jenis Kelamin  = Laki-Laki");
        Console.WriteLine("Alamat = Jakarta Timur");
        Console.WriteLine("Hobi = Game,TV Series, Movel Fiksi, Movies");
        Console.WriteLine("Umur = 23");
        Console.WriteLine("Pekerjaan = Software Engineer");
        Console.WriteLine("Jurusan = Teknik Informatika");
        Console.WriteLine("Kampus = Gunadarma");
        break;
         case 8:
         Console.WriteLine("Bye-Bye");
         break;
        default:
          Console.WriteLine("Masukan Pilihan 1-8");
          goto Kesini;
          break;
      }
      
    }
}