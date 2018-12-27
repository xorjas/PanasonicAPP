var $obj = $obj || {}

$obj = function () {

    var slider = $('#slider');

    initEvents = function () {
        $(".arrows span.left").click(function () {
            $("#slider img:last-child").clone().prependTo(slider);
            slider.css('left', '-' + $("#slider img:last-child").width() + 'px');
            slider.animate({
                left: "+=" + $("#slider img:last-child").width()
            }, 1000, function () {
                $("#slider img:last-child").remove();
                slider.css('left', '0');
            });
        });

        $(".arrows span.right").click(function () {
            $("#slider img:first-child").clone().appendTo(slider);
            slider.animate({
                left: "-=" + $("#slider img:first-child").width()
            }, 1000, function () {
                $("#slider img:first-child").remove();
                slider.css('left', '0');
            });
        });
    }

    initSlider = function () {
        var slider = $("#slider");
        var imgCount = $("#slider img").length;
        var width = (imgCount * slider.width());
        $("#slider").css('width', width)
    }

    this.init = function () {
        initEvents();
        initSlider();


    }
}

var obj = new $obj;
obj.init();