//jalankan dengan node assignment4.js {angka1} {angka2}
//contoh node assignment4.js 10 5

a=process.argv[2]
b=process.argv[3]
console.log("")
console.log("Sum:",parseInt(a) + parseInt(b))
console.log("Difference:",a-b)
console.log("Product:",a*b)
console.log("Quotient:",a/b)
console.log("Remainder:",a%b)
console.log("Value of num1 after increment:",++a)
console.log("Value of num2 after decrement:",--b)