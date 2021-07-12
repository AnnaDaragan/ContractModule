
var AddEditPersonalInfo = function (id) {
    var url = "/CompanyServices/CreateOrEdit?id=" + id;
    if (id > 0)
        $('#title').html("Изменить запись");
    else
        $('#title').html("Новая запись");

    $("#InfoFormModelDiv").load(url, function () {
        $("#InfoFormModel").modal("show");

    });
};

var SubmitAddEdit = function (form) {
    $.validator.unobtrusive.parse(form);
    if ($(form).valid()) {
        var data = $(form).serializeJSON();
        data = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            url: "/api/compserv",
            data: data,
            contentType: "application/json",
            success: function (data) {
                if (data.success) {
                    $("#InfoFormModel").modal("hide");
                    $("#tabCS").load("/CompanyServices/Index #tabCS");
                    ShowMessage(data.message);
                }
            }
        });
    }
    return false;
}

var Delete = function (id) {
    swal({
        title: "Вы уверены, что хотите удалить эту запись?",
        text: "Вы не сможете её восстановить!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Да, удалить!",
        cancelButtonText: "Отмена",
        closeOnConfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: '/api/compserv/' + id,
            success: function (data) {
                if (data.success) {
                    ShowMessage(data.message);
                    $("#tabCS").load("/CompanyServices/Index #tabCS");

                }
            }
        });
    });
}

function ShowMessage(msg) {
    toastr.success(msg);
}
