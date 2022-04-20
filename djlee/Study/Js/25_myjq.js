//jquery의 window.onload와 똑같음

//$().ready(function () {}) 이걸 아래와 같이 더 줄일 수 있다.
//$(function(){})

$(function() {
    $("#aaa").css('color', 'red')
    let bbb = $("#bbb")
    bbb.on("click", function(){alert("하이~~~~")})

    //되긴 되는 데, 어중간하게 섞어서 쓰면 더 안 좋을 수 있다.
    //사실 이거때문에 jQ가 점점 없어지는 분위기가 형성되었다.
    //js 자체는 점점 좋아지고 있으니 굳~~이 jq를 쓸 이유가 사라지고 있는 것이다.
    let aaa = document.querySelector("#aaa")
    aaa.onclick = function(){alert("이거되나")}//되긴 한다.
})