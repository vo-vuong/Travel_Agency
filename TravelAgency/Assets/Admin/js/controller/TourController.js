var tour = {
    init: function () {
        tour.registerEvents();
    },
    registerEvents: function () {
        $('.btn-dlTour').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            var item = '#row_' + id;
            $.ajax({
                url: "/Admin/Tour/Delete",
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

tour.init();