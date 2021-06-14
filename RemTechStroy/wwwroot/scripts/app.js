$(function() {

   var header = $("#header"),
       introH = $("#intro").innerHeight(),
       scrollOffset = $(window).scrollTop();

    checkScroll(scrollOffset);

   $(window).on("scroll", function () {

       scrollOffset = $(this).scrollTop();
       checkScroll(scrollOffset);
   });

   function checkScroll(scrollOffset) {
       if (scrollOffset >= introH) {
           header.addClass("fixed");
       }
       else {
           header.removeClass("fixed");
       }
   }

    $("[data-scroll]").on("click", function (event) {
        event.preventDefault();

       var $this = $(this),
           blockId = $this.data('scroll'),
           blockOffset = $(blockId).offset().top;

       blockOffset = blockOffset - 40;

        $("#nav a").removeClass("active");
        // $("#header").removeClass("active");
        $this.addClass("active");

       $("html, body").animate({
           scrollTop: (blockOffset)
       }, 500);
    });

   $("#nav_toggle").on("click", function (event) {
       event.preventDefault();

       $("#nav_toggle").toggleClass("active");
       $("#nav").toggleClass("active");
       $("#header").toggleClass("active");
   });

    $("#nav").on("click", function (event) {
        event.preventDefault();
        $("#nav_toggle").removeClass("active");
        $("#nav").removeClass("active");
        $("#header").removeClass("active");
    });

    $("[data-collapse]").on("click", function (event) {
        event.preventDefault();

        var $this = $(this),
            icon = $this.find("i"),
            blockId = $this.data('collapse');

        $this.toggleClass("active");
        icon.toggleClass("fa-chevron-down fa-chevron-up");
        $(blockId).slideToggle();
    });

});

