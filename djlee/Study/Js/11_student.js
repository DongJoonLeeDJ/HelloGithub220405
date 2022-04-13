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
