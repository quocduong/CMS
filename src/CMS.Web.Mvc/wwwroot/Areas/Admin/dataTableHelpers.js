var datatables = (function ($) {
    return function () {
        var table;
        function initial(element, options) {
            $(element).DataTable({
                'paging': true,
                'lengthChange': false,
                'searching': false,
                'ordering': true,
                'info': true,
                'autoWidth': false,
                buttons: options.buttons
            });
        }
    }
})(jQuery);