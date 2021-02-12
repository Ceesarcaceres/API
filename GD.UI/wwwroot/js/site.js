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

