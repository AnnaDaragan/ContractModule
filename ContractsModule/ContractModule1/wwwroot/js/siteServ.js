var AddEditPersonalInfo = function (id) {
    var url = "/Services/CreateOrEdit?id=" + id;
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
            url:  "/api/serv",
            data: data,
            contentType: "application/json",
            success: function (data) {
                if (data.success) {
                    $("#InfoFormModel").modal("hide");
                    $("#tabS").load("/Services/Index #tabS");
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
            url: '/api/serv/' + id,
            success: function (data) {
                if (data.success) {
                    ShowMessage(data.message);
                    $("#tabS").load("/Services/Index #tabS");
                }
            }
        });
    });
}

function ShowMessage(msg) {
    toastr.success(msg);
}