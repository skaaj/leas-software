$(document).ready(function() {
	$("li a").click( function(e) {
		e.preventDefault();
		console.log($(this).attr("href"));
		$("html, body").animate({ scrollTop: $($(this).attr("href")).position().top }, "slow");

		$("li a").each( function(){
			$(this).removeClass("actived");
			$(this).parent().removeClass("actived");
		});

		$(this).addClass("actived");
		$(this).parent().addClass("actived");
	});
});