function Student(n,a,nm)
{
    this.name = n
    this.age = a
    this.number = nm
}

Student.prototype.registerInfo = function()
{
    alert(this.name+'학생 등록 완료')
}

//객체를 생성하는 다양한 방법
function Student2(n,a,nm) //js는 매개변수에 타입이 정해져 있지 않다.
{
    //Student 객체라기 보단 그냥 name,age,number,registerInfo라는 속성을 갖는 객체라고 보는 편이 맞다.
    return {
        name : n,
        age : a,
        number : nm,
        registerInfo : function () {
            alert(n+"번 학생 등록")
        }
    }
}

function Student3(n,a,nm)
{
    return new Student(n,a,nm)
}

