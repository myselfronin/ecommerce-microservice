var dataTable;

$(document).ready(function () {
    loadDataTable()
    var url = window.location.search;
    if (url.includes("approved")) {
        loaddatatable("approved");
    }
    else {
        if (url.includes("readyforpickup")) {
            loaddatatable("readyforpickup");
        }
        else {
            if (url.includes("cancelled")) {
                loaddatatable("cancelled");
            }
            else {
                loaddatatable("all");
            }
        }
    }
});
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        order: [[0, 'desc']],
        "ajax": { url: "/order/getall" },
        "columns": [
            { data: 'orderHeaderId', "width": "5%" },
            { data: 'email', "width": "25%" },
            { data: 'name', "width": "20%" },
            { data: 'phone', "width": "10%" },
            { data: 'status', "width": "10%" },
            { data: 'orderTotal', "width": "10%" },
            {
                data: 'orderHeaderId',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/order/orderDetail?orderId=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i></a>
                    </div>`
                },
                "width": "10%"
            }
        ],
    })
}