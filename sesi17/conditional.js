const namaPeserta = "Farhan"
const sudahMakan = false
const sudahMinum = true

//if-else

if(sudahMakan){
//kondisi jika true
console.log(`${namaPeserta} sedang ngoding`)
}else{
//kondisi jika false

console.log(`${namaPeserta} harus makan`)
}



//`` = BACKTIP
// if-else if
if(sudahMinum){
//jika kondisi pertama true
    console.log(`${namaPeserta} sedang ngoding`)
}else if (sudahMakan){
    console.log(`${namaPeserta} harus minum`)
}



//if-else if-else

if(sudahMinum && sudahMakan){
    //jika kondisi pertama true
        console.log(`${namaPeserta} sedang ngoding`)
    }else if (sudahMakan){
    //jika kondisi kedua true
        console.log(`${namaPeserta} harus makan`)
    }else{
    //jika semua kondisi sebelumnya false
        console.log(`${namaPeserta} harus minum`)
    }


// switch-case
switch(sudahMakan){
    case true:
        console.log(`${namaPeserta} sedang ngoding`)
        break
    case false:
        console.log(`${namaPeserta} harus makan`)
        break
}


    