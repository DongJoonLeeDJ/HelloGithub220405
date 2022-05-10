using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookManager
{
    public class User
    {
        public int Id { get; set; } //PK, Book의 FK와 연결됨
        public string Name { get; set; }
    }
}
