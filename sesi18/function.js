// function
// *  1. tradisional => function <namaFunction>(){}

function sapa(nama = "Dini"){
    console.log(`Halo ${nama}! Apa kabarnya?`)
}

//const sapa = function (){}

sapa()
sapa("Farhan")


//  *  2. arrow => 
//  *      sebegai variable => const<namaFunction> = () => {}
//  *      sebagai anonymous function :
//  *      () => {}
//  */

const sapaArrow = (nama = "Fira", alamat = 'jalan jambu') => {
    console.log(`Halo ${nama} sukses selalu ya! di jalan ${alamat}`)
} // scope-less

sapaArrow()
sapaArrow("Nisa")