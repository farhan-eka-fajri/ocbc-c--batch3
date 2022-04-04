// while loop (do-while loop) = uncountable loop
// for loop = countable loop

//for loop
// for(let i = 0; i < 10; i++){}
    //jalankan jika i<10

    for(let i = 0; i < 10; i++){

    }

//while loop

/**
 * while(kondisi){
 * jalankan perintah disini 
 * }
 */

let count = 10

while(count>10){
    console.log(count--)
}

//waspada infinite loop

//kasus 1 for loop
for (let i = 0; i < 10; i + 1){
    console.log(i)
}

//kasus 2 while loop
while(true){
    console.log('ini looping')
}