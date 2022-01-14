(function ($) {
    "use strict"; // Start of use strict

    $("#addNewItem").click(function () {

        let ColorImageItems = $(".ColorImageItem");
        let firstItem = $(ColorImageItems[0].cloneNode(true));
        let formControls = firstItem.find(".form-control");

        formControls[0].setAttribute("name", `[${ColorImageItems.length}].ColorId`);
        formControls[1].setAttribute("name", `[${ColorImageItems.length}].Image`);
        formControls[1].value = "";

        let itemContainer = $(".itemContainer");
        itemContainer.append(firstItem);
    });

    $(".addNewItem").click(function () {

        let index = $(this).data("index");
        let ColorImageItem = $(".ColorImageItem");
        let SizeToColorItems = $(".SizeToColorItem");

        for (var i = 0; i < ColorImageItem.length; i++) {
            if (ColorImageItem[i].dataset.index == index) {
                let SizeToColorContainer = $(ColorImageItem[i]).find(".SizeToColorContainer");
                let SizeToColorItem = ($(ColorImageItem[i]).find(".SizeToColorItem"))[0].cloneNode(true);

                let formControls = $(SizeToColorItem).find(".form-control");

                formControls[0].setAttribute("name", `[${SizeToColorItems.length}].SizeId`);
                formControls[1].setAttribute("name", `[${SizeToColorItems.length}].Price`);
                formControls[2].setAttribute("name", `[${SizeToColorItems.length}].Quantity`);
                formControls[3].setAttribute("name", `[${SizeToColorItems.length}].ColorId`);

                //console.log(SizeToColorItem);
                //console.log(formControls);
                //console.log(SizeToColorItems);
                //console.log(SizeToColorItems.length);

                SizeToColorContainer.append(SizeToColorItem);
            }
        }
    });

})(jQuery);
