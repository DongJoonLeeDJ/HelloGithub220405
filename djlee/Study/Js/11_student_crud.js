
window.onload = () => {
    let name = document.querySelector("#name")
    let age = document.querySelector("#age")
    let num = document.querySelector("#num")

    let create = document.querySelector("#create")
    let read = document.querySelector("#read")
    let update = document.querySelector("#update")
    let my_delete = document.querySelector("#delete")
    //delete라는 키워드가 이미 쓰이고 있음

    //let o = {a:1,b:2}
    //delete o.b //특정 객체, 객체의 속성 삭제시 쓰임
    //console.log(o)

    let consolelog = document.querySelector("#consolelog")
    let students = []

    create.onclick = function() {
    }
    read.onclick = function() {
    }
    update.onclick = function() {
    }
    my_delete.onclick = function() {
    }
    consolelog.onclick = function() {
        console.log(students)
    }

}