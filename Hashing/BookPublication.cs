using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashing
{
    public static class HashTableOfBook 
    {
        public static Hashtable bookTable = new Hashtable();
        public static void ComputeHashtable(int key, BookPublication bp)
        {

            if (!bookTable.ContainsKey(key))
                bookTable.Add(key, bp);
        }

    }
    public class BookPublication
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public DateTime Date { get; set; }
       // Hashtable bookTable = new Hashtable();
        public BookPublication()
        {
          //bookTable = new Hashtable();
        }
       
        public BookPublication(long id,string title,string author,string publication,DateTime date)
        {
            BookId = id;
            Title = title;
            Author = author;
            Publication = publication;
            Date = date;
        }
        //public void ComputeHashtable(int key,BookPublication bp) 
        //{
            
        //    if (!bookTable.ContainsKey(key))
        //        bookTable.Add(key, bp);            
        //}

        public BookPublication GetDetailsfromKey(int key,Hashtable bookTable)
        {
            if (bookTable.ContainsKey(key))
                return (BookPublication)bookTable[key];
            else
                return null;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = (BookId != null ? BookId.GetHashCode() : 0);
                result = (result * 397) ^ (Title != null ? Title.GetHashCode() : 0);
                result = (result * 397) ^ (Author != null ? Author.GetHashCode() : 0);
                result = (result * 397) ^ (Publication != null ? Publication.GetHashCode() : 0);
                result = (result * 397) ^ (Date != null ? Date.GetHashCode() : 0);                
                return result;
            }
        }
    }
}
