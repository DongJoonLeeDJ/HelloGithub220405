//$ = document
//window.onload랑 똑같은거임
//document.body.addEventListner("DOMContentLoaded", function(){})
$(function()
{
    const name = $('#name')
    const gender = $('#gender')
    const beonho = $('#beonho')

    const print = $('#print')
    const reset = $('#reset')
    const printOrderBy = $('#printOrderBy')
    const information = $('#information')

    function resetInfo()
    {
        information.html('')
    }

    reset.on('click', () => {
        resetInfo()
        students = []
    })

    //단순 출력
    print.on('click', () => {
        //val() = 값 읽어오기
        const student = new Student(name.val(), gender.val(), Number(beonho.val()))
        let newStudentInfo = $('<h1></h1>') //태그 만들기
        newStudentInfo.text(student.toString()) //안에 글자 넣는거
        //newStudentInfo.text = "ㅁㅁㅁ" <- 이렇게 하면 안 됨
        if(student.성별 =="남")
        {
            newStudentInfo.css('background-color', 'springgreen').css('color','blue')
        } 
        else
        {
            newStudentInfo.css('background-color', 'black').css('color','pink')
        }
        information.append(newStudentInfo)
    })


    printOrderBy.on('click', () => {
        const idx = students.findIndex(function(item) {
            return item.번호 === Number(beonho.val())
        })
        if(idx != -1)
        {
            alert('중복!')
            return
        }
        resetInfo()
        students.push(new Student(name.val(),gender.val(),Number(beonho.val())))

        students.sort(function(a,b) {
            return a.번호-b.번호
        })
        for(let i = 0; i<students.length; i++)
        {
            let newStudentInfo = $('<h1></h1>')
            newStudentInfo.text(students[i].toString())
            if(students[i].성별=="남")
            {
                newStudentInfo.css('background-color','gold').css('color','snow')
            }
            else
            {
                newStudentInfo.css('background-color','yellow').css('color','gray')
            }
            information.append(newStudentInfo)
        }

    })

}
)