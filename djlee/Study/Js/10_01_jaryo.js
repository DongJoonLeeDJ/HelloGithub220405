console.log(2==2) // true
console.log("2"==2) // true (값을 비교)
console.log("2"===2)// false(값과 타입 둘 다 비교)

//js에서 false가 나오는 경우
console.log("false 모음집. 이 경우들 빼고는 전부 true")
console.log(Boolean(0)) //숫자 0을 Boolean 타입으로 변경시 false
console.log(Boolean(NaN))//false -> NaN -> Not a Number -> 문자열등을 숫자로 바꾸다 실패한 거
console.log(Boolean(''))//false
console.log(Boolean(null))//false
console.log(Boolean(undefined))//false -> 어떤 타입인지 아직 안 정해졌는데 "aa"같은 문자열이나 숫자 더할 때
console.log(Boolean(false))//false
console.log(Boolean(Number("aaa")))//false

//false같은 데 true인 것들...
console.log("false같지만 true")
console.log(Boolean("0")) //0이긴한데... 숫자 0이 아니고 문자열 0이다.
console.log(Boolean(String(Number("문자열")))) //"NaN"이라는 글자

//자바스크립트에서의 객체
//java, c#과 유사한 부분도 있지만 js는 js만의 독특한 형태를 가지고 있다.
//둘 다 객체임...
let student = {} //처음에 빈 객체로 선언
student.name = "이동준" //그 뒤에 내가 원하는 속성 추가 가능
student.age = 34

let pokemon = {   //처음부터 속성이랑 값을 넣을 수도 있음
    No : 1,
    Name : "이상해씨",
    Type : "풀/독"
}

student.sayHello = () => {alert("ㅎㅇ")} //속성에 함수 추가 됨
student.Pokemon = pokemon //또 다른 객체 추가 가능
student.lotto = [1,17,21,31,35,39,44] //배열도 추가 가능. 참고로 배열 자체도 객체이며, 배열 안에 배열,객체,함수 등 들어감
 
pokemon.master = "한지우" //속성 추가 가능

console.log(student)
console.log(pokemon)
student.sayHello()

console.log(student.name)
//console.log(student[age])
console.log(student["name"])
//console.log(student[0])

//+ - / * % 에 대한 자료형 처리
console.log("123"-10) //113
console.log("123"/10) //12.3
console.log("123"*10) //1230
console.log("123"%10) //3
console.log("123"+10) //12310 <- 문자열로써 더함
console.log(Number("123")+10) // 133 <- 숫자로써 더함