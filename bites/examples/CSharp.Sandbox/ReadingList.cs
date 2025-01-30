using System;
using System.Text;

namespace CSharp.Sandbox{
    class ReadingList{
        string[] unread;

        public ReadingList(string[] unread)
        {
            this.unread = unread;
        }

        internal void Add(string title)
        {
            Array.Resize(ref unread, unread.Length + 1);
            unread[unread.Length - 1] = title;
        }

        internal string DisplayReadingList(){
            StringBuilder sb = new StringBuilder();

            foreach(string book in unread)
            {
                sb.AppendLine(book);
            }

            return sb.ToString();
        }
    }
}