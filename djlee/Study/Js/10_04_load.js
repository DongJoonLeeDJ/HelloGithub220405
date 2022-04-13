
//body 안에 있는 모든 태그들을 다 불러오고 나서
//그 때에 수행하는 스크립트들

//예를 들어서 script 태그가 head에 있는 데,
//body에 있는 태그에 접근하고 싶을 때
//그 때 쓰임

//보통 script태그가 head에 있으면 body에 있는 걸 가져다 쓸 수 없다. 왜냐면
//head태그입장에서는 body태그가 아직 생기지도 않은거다.
window.onload = () => {
    let a = document.querySelector('#a')
    a.innerHTML = "<h1>안녕</h1>"

}

//둘 다 똑같은 건데(둘 중 하나 쓰면 된다)
//위에껀 옛날 JS책에 많이 보이고, 아래껀 우리가 받은 js책에서 쓰는 형식
document.addEventListener("DOMContentLoaded", () => {


})