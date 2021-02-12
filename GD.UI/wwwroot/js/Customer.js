// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.
function ConnectToAPI() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:56243/api/customer',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        beforeSend: function () {

        },
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });
}
function Inserir() {
    var data = {
        Name: $("#txtName").val(),

    }
    $.ajax({
        type: 'POST',
        url: 'http://localhost:56243/api/customer',
        data: JSON.stringify(data),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        beforeSend: function () {

        },
        success: function (response) {
            console.log(response);
        },
        error: function (error) {
            console.log(error);
        }
    });
}
//$(document).ready(function () {
//    ConnectToAPI()
//});
//$.get("ajax/CustomerController.cs", function (data) {
//    $(".result").html(data);
//    alert("Load was performed.");
//});
//    $.ajax({
//        method: "POST",
//        url: "Customer.js",
//        data: { nome: "Pedro", email: "pedro@email.com" }
//    })
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
//$.ajax({
//    // edit to add steve's suggestion.
//    url: "/CustomerController/ActionResult",
//    /*url: '<%= Url.Action("ActionResult", "CustomerController") %>'*/
//    success: function (data) {
//        // your data could be a View or Json or what ever you returned in your action method 
//        // parse your data here
//        alert(data);   
//    }
//});
        //$(document).ready(function () {
        //    $.ajax({
        //        url: '@Url.Action("Customer", "Customer")',
        //        success: function (result, status, xhr) {
        //            alert("Result: " + status + " " + xhr.status + " " + xhr.statusText)
        //        },
        //        error: function (xhr, status, error) {
        //            alert("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
        //        }
        //    });
        //});
//var url = '@Url.Action("GetData")';
//$.ajax({
//    url: url,
//    type: 'GET',
//    cache: false,
//    data: { value: strId },
//    success: function (result) {
//        $('#result').html(result);
//    }
//});
//$.ajax({
//    url: "/Customer/Customer",
//    success: function () {
//        alert("success");
//    }
//});
//$(function () {
//    $("#btnGet").click(function () {
//        $.ajax({
//            type: "POST",
//            url: "/Customer/AjaxMethod",
//            data: '{name: "' + $("#txtName").val() + '" }',
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (response) {
//                alert("Hello: " + response.Name + " .\nCurrent Date and Time: " + response.DateTime);
//            },
//            failure: function (response) {
//                alert(response.responseText);
//            },
//            error: function (response) {
//                alert(response.responseText);
//            }
//        });
//    });
//});