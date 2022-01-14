$(document).ready(function () {

    $("#itemCount").change(function () {

        let itemCount = Number($(this).val().split('-')[0]);
        let pageCount = Number($(this).val().split('-')[1]);
        let page = Number($(this).val().split('-')[2]);

        let pageItemCount = $(".pageItemCount");
        console.log(pageItemCount[0]);
        for (var i = 1; i <= pageItemCount.length; i++) {
            let newPage = 0;

            if (i == 1) {
                newPage = page - 1;
            } else if (i == pageItemCount.length) {
                newPage = page + 1;
            } else {
                newPage = i - 1;
            }

            pageItemCount[i-1].href = "/shop?page=" + newPage + "&itemCount=" + itemCount;

            //if (i == 1) {
            //    pageItemCount[i].setAttribute("href", "/shop?page=" + (page - 1) + "&itemCount=" + itemCount);
            //} else if (i == pageItemCount.length) {
            //    pageItemCount[i].setAttribute("href", "/shop?page=" + (page + 1) + "&itemCount=" + itemCount);
            //} else {
            //    pageItemCount[i].setAttribute("href", "/shop?page=" + (i - 1) + "&itemCount=" + itemCount);
            //}
        }
    });


});