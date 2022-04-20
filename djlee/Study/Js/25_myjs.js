/*id가 aaa인 태그에 css를 red로 바꿔보세요.
id가 bbb인 태그에 click 이벤트 추가해보세요.

js와 jq 모두로 해보세요
 */

window.onload = function() {
    let aaa = document.getElementById('aaa')
    let bbb = document.getElementById('bbb')
    aaa.style.color = 'red'
    bbb.onclick = function() {
        alert("안뇽")
    }
}