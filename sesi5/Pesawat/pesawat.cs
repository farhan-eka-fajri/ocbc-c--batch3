using System;

namespace testpesawat{

    public class Pesawat{

        public string nama;

        private string ketinggian;

        public string Ketinggian{
        get {return this.ketinggian;}
        set {this.ketinggian = value;}
        }



        public void terbang(){
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);

        }

        public void sudahterbang(){
            Console.WriteLine("Pesawat skarang berada pada ketinggian {0}", this.ketinggian);
        }
    }
}