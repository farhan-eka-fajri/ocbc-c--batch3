//object = memiliki property , method, function
// notasi:{}

const peserta = {
    //property = ciri
    nama: "Edward",
    pekerjaan: "Full-stack Developer @ OCBC",
    age: 22,

    //method = kemampuannya
    bekerja(){
        return `${this.nama} sedang ngoding JavaScript.`
    }
}

console.log(peserta.bekerja())

//coba looping objectnya
//1 ambil keynya degnen Object.keys()
const hasilObject = {}
Object.keys(peserta).forEach(function(key){
    //2 mengakses object = object['key]
   if(typeof peserta[key] === 'function'){
       hasilObject[key] = peserta[key]()
   } else{
       hasilObject[key] = peserta[key]
   }
})



console.log(hasilObject)

//array = kumpulan item sejenis = rak = bisa dilooping = isi array adalah index berurutan
//objek = entitas = barang di dunia nyata = tidak bisa dilooping = isinya adalah key yang menampung value



//cara menambahkan key baru ke dalam object
peserta.berkacamata = false
console.log(peserta)

peserta['berkacamata'] = false
console.log(peserta)

//cara mengubah value key pada object
peserta.nama = 'Alex'
console.log(peserta)

//menghapus key dari object
delete peserta.bekerja
console.log(peserta)