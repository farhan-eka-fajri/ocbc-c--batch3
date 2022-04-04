//string > "", '', ``
console.log("Hello FSD OCBC Batch3");
console.log("Apa kabar? ")

//number > 100, 10.01, 4.20, -900
console.log(100)
console.log(123_456_789)
console.log(123456789)

// boolean > true, false
console.log(true)
console.log(false)

//null
//undefined
//sama-sama falsy
console.log(null)
console.log(undefined)

//variable/function/method  > camelCase > console.grouEnd()
//class > PascalCase > Date()

//variable
// var | let | const

/*
var = global scope = bisa diubah

ES2015/ES6
let = local scope = bisa diubah
const = local scope = gk bisa diubah

konvensi nama
    camelCase
    gk boleh ada angka di depan
    gk boleh ada simbol

    (2) let/const tidak bisa dipanggil di luar scope
    {} = scope 

    (3) let/const tidak boleh dipanggil sebelum di declare
    (4) const di assign ulang
    const namaPeserta = "Han"
    namaPeserta = "susanto"
*/
{
    var namaPeserta = "Farhan"
}

console.log(namaPeserta)

//penulisan yang benar
let namaPesertaLain = "Fatin"
let asal = "Pekalongan"
let bahasaPemrograman = ['C#','PHP', 'JavaScript']

console.log(namaPesertaLain)
console.log(asal)
console.log(bahasaPemrograman[1])

// typeof = mencari tipe dari sebuah value 

console.log(typeof (typeof 100))
console.log(typeof '100')


//operasi matematika berlaku

console.log(2 * 3 + 5 / 2)
//------------6---+--2.5 == 8.5

console.log(17/3)
console.log(17%3)