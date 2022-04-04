//array di JS = object yang iterable
const peserta = [
    'Alex', 'Dini','Fira','Nathan','Tevin'
]

//mengakses item pada array
console.log(peserta[2])

//mengubah item di dalam array
peserta[1] = 'Arif'
console.log(peserta)

// const peserta = [
// 'Alex', 'Dini','Fira','Nathan','Tevin'
// ]


/**
 * pass by reference = let kumpulan = peserta
 * 
 * pass by value = melibatkan spread operator
 * "spread operator " = symbol yang mampu memecahkan array/objevt
 * let kumpulankedua =[...peserta]
 */



//pass by reference
const kumpulanReference = peserta

kumpulanReference[0] = 'Nisa'
console.log(peserta)


//pass by value = value yang masuk jadi array baru
const kumpulanValue = [...peserta]
kumpulanValue[4] = 'Kevin'
console.log(peserta)


//mengakses jumlah item pada array = Array.length
console.log(peserta.length)


//built in method pada array

//slice = potong sebuah aray menjadi 2 array  yang dimulai dari index yang kita tentukan
//Array.slice(index?, start?, end?)

console.log(peserta.slice(2))

//splice  = potong sebuah array kemudian pindahkan kede dalam variable yang baru
//item yang terpotong akan dihapus dari arrya yang lama
//Array.splice(index, deleteCount())
console.log(peserta.splice(-2, 2))

//push(lawannya pop) = kita akan dorong 1 item baru kedalam array
peserta.push('Farhan')
console.log('array setelah push', peserta)

//pop = kita pentalkan 1 item index terakhir
peserta.pop()
console.log('array setelah pop',peserta)

//shift (lawannya unshift)  = menghapus data diindex 0 lalu geser item di index 1 dst ke kiri
peserta.shift()
console.log('array setelah shift', peserta)

//unshift = geser item di index 0 dan seterusnya ke kanan, lalu tambahkan data di index 0

peserta.unshift('Nisa')
console.log('array setelah unshift',peserta)
