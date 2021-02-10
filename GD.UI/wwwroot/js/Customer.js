// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

  
    $.ajax({
        method: "POST",
        url: "Customer.js",
        //data: { nome: "Pedro", email: "pedro@email.com" }
    })

//    $(document).ready(function () {
//    let endpoint = 'api/[controller]'
//    $(".content a").each(function (index, element) {

//        $.ajax({
//            url: endpoint + "&q=" + $(this).text(),
//            contentType: "application/json",
//            dataType: 'json',
//            success: function (result) {
//                console.log(result);
//            }
//        })
//    });
//});