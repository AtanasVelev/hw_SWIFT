using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    class Novel : SchoolBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public Novel(string Author, string Title):base(101,1875,"Ivann")
        {
            this.Author = Author;
            this.Title = Title;
        }
            
    }
}
