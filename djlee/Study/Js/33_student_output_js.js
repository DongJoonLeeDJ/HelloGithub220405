window.onload = () => {

    //name에 이벤트는 추가할거지만 name 변수자체를 바꾸진 않을거라서 const로 선언함
    //메모리 적인 측면에서도 const가 더 효율이 높음
    //변수의 값 자체가 변경될 일이 없으면 const가 더 좋음 (js 책 참고해보세요)
    const name = document.querySelector("#name") //쌍따옴표나 따옴표나 둘 중 아무거나 써도 된다.
    const gender = document.querySelector("#gender")
    const beonho = document.querySelector("#beonho")
    //name=100
    const print = document.querySelector("#print")
    const reset = document.querySelector("#reset")
    const printOrderBy = document.querySelector("#printOrderBy")
    const information = document.querySelector("#information")

    function resetInfo() 
    {
        information.innerHTML = '' //화면 리셋하는 함수
    }

    //리셋하기 //.onclick으로 해도 됨
    reset.addEventListener('click', () => {
        resetInfo() //화면 리셋
        students = [] //배열도 리셋
    })

    print.onclick = () =>{
        const student = new Student(name.value, gender.value, Number(beonho.value))
        let newStudentInfo = document.createElement('h1') 
        newStudentInfo.textContent = student.toString() //h1태그 만들고 그 안에 텍스트 내용 뭐 넣을지 정하는 것
        if(student.성별 == "남")
        {
            newStudentInfo.style.backgroundColor = 'gray'
            newStudentInfo.style.color = 'cyan'
        }
        else
        {
            newStudentInfo.style.backgroundColor = 'yellow'
            newStudentInfo.style.color='orange'
        }
        information.appendChild(newStudentInfo) //document.body.appendChild가 아니다.
        //id가 information인 div 태그 안에 h1태그를 하나 추가한 것

    }


    printOrderBy.onclick = function() {
        //학생 등록할 때 이미 있는 번호를 등록하는 건 아닌지 먼저 체크
        const idx = students.findIndex(aaa => aaa.번호 === Number(beonho.value))
        /*
        const idx = students.findIndex (
            function(item) {
                return item.번호 === Number(beonho.value)
            }
        )
        */


        console.log('idx='+idx)
        console.log(students)
        if(idx!=-1)
        {
            alert('번호 중복')
            return
        }

        resetInfo() //화면 리셋
        students.push(new Student(name.value, gender.value, Number(beonho.value)))

        //단순 숫자 배열과는 다르게 이런 객체 배열은 어떤 걸 기준으로 정렬할지 정해야 함
        //두 개의 객체를 가져와서, 여기선 두 객체의 번호값을 가지고 정렬함
        //값이 양수,0,음수냐에 따라서 정렬이 달라짐
        
        console.log(students) //sort하기 전에 찍어도 개발자도구에서 콘솔 확인해보면 정렬 다 되어 있는 게 나타나있다.
                              //가장 최근 상태의 students 상태가 찍힘
                              // sort 전 후 상태를 console로 찍어보고 싶으면 아래처럼 for문을 이용해 하나하나 출력해봐야 함
        for(let item of students)
            console.log(item)

        students.sort((ㅁ,ㅂ) => ㅁ.번호-ㅂ.번호)

        /*
        students.sort(function(a,b){
            return a.번호 - b.번호
        })
        */

        for(let item of students)
            console.log(item)

        for(let i = 0; i<students.length; i++)
        {
            let newStudentInfo = document.createElement('h1')
            newStudentInfo.textContent = students[i].toString()
            if(students[i].성별=="남")
            {
                newStudentInfo.style.backgroundColor='springgreen'
                newStudentInfo.style.color ='green'
            }
            else
            {
                newStudentInfo.style.backgroundColor='salmon'
                newStudentInfo.style.color='pink'
            }
            information.appendChild(newStudentInfo)
        }

    }



}