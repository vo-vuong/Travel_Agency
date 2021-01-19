// Author: VoXuanQuocVuong
// Email:  vovuong1025@gmail.com
// Date Create: 19/01/2021

var user = {
    init: function () {
        user.registerEvents();
    },
    registerEvents: function () {
        $('.btn-dlUser').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            var item = '#row_' + id;
            $.ajax({
                url: "/Admin/User/Delete",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    if (response.status == true) {
                        $(item).remove();
                        $('#AlertBox').removeClass('alert-danger');
                        $('#AlertBox').addClass('alert-success');
                        $('#AlertBox').slideDown();
                        $('#AlertBox').delay(1000).slideUp(500);
                        $('#AlertBox').text("Xóa thành công.");
                    }
                    else {
                        $('#AlertBox').removeClass('alert-success');
                        $('#AlertBox').addClass('alert-danger');
                        $('#AlertBox').slideDown();
                        $('#AlertBox').delay(1000).slideUp(500);
                        $('#AlertBox').text("Xóa thất bại!");
                    }
                }
            });
        });
    }
}

user.init();