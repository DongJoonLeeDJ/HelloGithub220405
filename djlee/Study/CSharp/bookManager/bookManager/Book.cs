using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookManager
{
    public class Book
    {
        //get; set; 추가하는 이유
        //1. java의 getter setter처럼 관례화되어 있다.(java처럼 심하게 관례화되어있는 건 아님)
        //2. dataGridview에 DataSource로 지정시 get;set; 없으면 화면에 안 보임
        public string Isbn { get; set; } //PK 기본키
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Page { get; set; }

        public int UserId { get; set; } //FK 외래키(참조키)
        public string UserName { get; set; }
        public bool isBorrowed { get; set; }
        public DateTime BorrowedAt { get; set; }

    }
}
