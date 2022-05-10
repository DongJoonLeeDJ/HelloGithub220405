using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookManager
{
    public class DataManager
    {
        //클래스 변수
        //DataManager 클래스는 클래스변수와 클래스메소드로 이뤄진 클래스이다.
        //싱글톤 패턴을 사용해서, 인스턴스 변수와 인스턴스 메소드로 코드를
        //실행해도 되지만 사용성의 편리함을 위해서 클래스변수, 클래스 메소드 쓸 것이다.

        //책들 정보, 유저들 정보를 이 리스트에 전부 담아서 관리할 것
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        //생성자 앞에 static이 붙는 건 처음일 것이다.
        //DataManager에 접근하는 그 순간 바로 호출됨
        //메모리에 올라가는 시기는 프로그램이 시작하자마자 올라감
        //즉 new DataManager() 이렇게 인스턴스 만들기 전부터 메모리에 이미 있다.

        //오타방지를 위한 컬럼(혹은 속성) 미리 만들어두기
        //xml특성상 오타가 굉장히 많고 경우에 따라선 찾기가 매우 어렵다.
        //그래서 상수를 활용하여 미리 만들어두는 것
        //오타 예시 <books>     <book>aaa</books>   </book>
        //고친 것 예시 <books>   <book>aaa</book>   </books>

        /// <summary>
        /// 객체명
        /// </summary>
        const string BOOK = "book";
        const string USER = "user";

        /// <summary>
        /// List명
        /// </summary>
        const string BOOKS = "books";
        const string USERS = "users";

        /// <summary>
        /// 도서용
        /// </summary>
        const string ISBN = "isbn";
        const string NAME = "name";
        const string PUBLISHER = "publisher";
        const string PAGE = "page";
        const string ISBORROWED = "isBorrowed";
        const string BORROWEDAT = "borrowedAt";
        const string USERID = "userId";
        const string USERNAME = "username";

        /// <summary>
        /// 유저용
        /// </summary>
        const string UNAME = "name";
        const string UID = "id";




        static DataManager() //딱 한 번만 호출 됨
        {
            Load();
        }

        //도서정보, 유저정보를 모두 가져와야 함
        public static void Load() //xml 파일을 읽어들여서 도서관 현황을 보여주는 것
        {
            try //파일을 읽어들이는 걸 실패할 경우를 대비한 것
            {
                //파일이 없거나 기타 등등의 이유로...
            }
            catch (Exception ex) //파일 읽는 걸 실패하면 Save 호출 후 Load 다시 호출
            {   //파일이 없을 경우를 대비함
                Save();
                Load();
            }
        }

        public static void Save()
        {
            // 파일이 없을 때도 호출 됨
            // 새로운 정보가 생겨도 호출 됨
            // 책을 추가수정삭제하거나 반납혹은 대여 
            // 회원을 추가수정삭제할 때 호출됨
            // 기존의 정보대신에 새로운 정보를 덮어쓰는 방식을 쓴다.
            // 5명의 회원이 있다면, 그 정보를 싹 날리고 6명의 정보로 덮어쓰기 한다.

            string booksOutput = string.Empty; //"" 이랑 똑같은 것

            booksOutput += $"<{BOOKS}>\n";  //<books>

            foreach(var item in Books)
            {
                booksOutput += $"\t<{BOOK}>\n";
                booksOutput += $"\t\t<{ISBN}>{item.Isbn}</{ISBN}>\n";
                booksOutput += $"\t\t<{NAME}>{item.Name}</{NAME}>\n";
                booksOutput += $"\t\t<{PUBLISHER}>{item.Publisher}</{PUBLISHER}>\n";
                booksOutput += $"\t\t<{PAGE}>{item.Page}</{PAGE}>\n";
                booksOutput += $"\t\t<{BORROWEDAT}>{item.BorrowedAt}</{BORROWEDAT}>\n";
                booksOutput += $"\t\t<{ISBORROWED}>"+ (item.isBorrowed ? 1 : 0) +$"</{ISBORROWED}>\n";
                booksOutput += $"\t\t<{USERID}>{item.UserId}</{USERID}>\n";
                booksOutput += $"\t\t<{USERNAME}>{item.UserName}</{USERNAME}>\n";
                booksOutput += $"\t</{BOOK}>\n";
            }
            booksOutput += $"</{BOOKS}>\n";//</books>
            Console.WriteLine(booksOutput);
            File.WriteAllText($"./{BOOKS}.xml", booksOutput);

            string usersOutput = string.Empty;
            usersOutput += $"<{USERS}>\n";
            foreach(var item in Users)
            {
                usersOutput += $"\t<{USER}>\n";
                usersOutput += $"\t\t<{UID}>{item.Id}</{UID}>\n";
                usersOutput += $"\t\t<{UNAME}>{item.Name}</{UNAME}>\n";
                usersOutput += $"\t</{USER}>\n";
            }
            usersOutput += $"</{USERS}>\n";
            Console.WriteLine(usersOutput);
            File.WriteAllText($"./{USERS}.xml", usersOutput);


            //throw new NotImplementedException();
        }
    }
}
