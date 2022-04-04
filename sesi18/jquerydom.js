//menyeleksi DOM berdasarkan Id element dan menampungnya
//kedalam variable

var pageTitleElement = document.getElementById("page-title")

/** menyeleksi DOM berdasarkan nama class element 
 * dan menampungnya ke dalam variable. isinya merupakan array
 * dari object html element, walaupun <h1> hanya ada 1
 */
var pageBoxElement = document.getElementsByClassName("page-box")

/**menyeleksi DOM berdasarkan tag <h1> dan menampungnya
 * ke dalam variabel. isinya merupakaan array dari object
 * html element
 */

var pageHeadings = document.getElementsByTagName("h1")

var pageTitleElementsContent = pageTitleElement.innerHTML;

//'isi <div id-"page-title> adalah Sample Page Title
console.log('isi <div id="page-title> : '+ pageTitleElementContent)

var pageBoxElementsContent = pageBoxElement.innerHTML;
//  isi <div class="page-box"> adalah undefined
console.log('isi <div class="page-box>' + pageBoxElementsContent)


for(var i = 0; i < pageBoxElement.length;i++){
    var currentPageBoxElement = pageBoxElement[i];
    var currentPageBoxElementsContent = currentPageBoxElement.innerHTML;

    var firstPageBoxElement = pageBoxElement[0];
    var firstPageBoxElementsContent = firstPageBoxElement.innerHTML;

    var secondPageBoxElement = pageBoxElement[1];
    var secondPageBoxElementsContent = secondPageBoxElement.innerHTML;

    var thirdPageBoxElement = pageBoxElement[2];
    var thirdPageBoxElementContent = thirdPageBoxElement.innerHTML;

}

console.log('isi <div class="page-box"> yang pertama :'+ firstPageBoxElementsContent)
console.log('isi <div class="page-box"> yang kedua :'+ secondPageBoxElementsContent)
console.log('isi <div class="page-box"> yang ketiga :'+ thirdPageBoxElementsContent)

