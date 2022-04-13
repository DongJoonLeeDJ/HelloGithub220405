//Animal이라는 클래스 만들고, 그에 대한 속성들 추가하고, 
//그리고 메소드도 추가한 것
//자바스크립트에서 class 문법도 있지만, 옛날 책을 보거나 예전에 쓰이던 코드들을 보면
//객체 만들 때 function 형식을 많이 빌렸다.
function Animal (name, type, age)
{
    this.name = name
    this.type = type
    this.age = age
}
//모든 Animal이 introduce라는 공통적으로 메소드를 가지므로
//밖으로 따로 뺐다.
//이렇게 밖으로 안 빼면 new Animal 할 때 마다 이 메소드에 대한 메모리도 또 할당을 해줘야 한다.
//근데 prototype으로 정의하면 메모리를 한 번만 할당해주면 된다.
Animal.prototype.introduce = function() {
    console.log(this.name+"은 "+this.type+"이고, "+this.age+"살이다.")
}