using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LibraryApp
{
    public class VirtualDatabase 
    {
        private static ArrayList database = new ArrayList();

       static bool isDublicateUsernameBool, isValidUsernameBool, IsValidPasswordBool;

        public static bool IsValidUsername(string username)
        {
            if (username.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDublicateUsername(string username)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Users itemTemp = (Users)database[i];
                if (username == itemTemp.Username)
                {
                    isDublicateUsernameBool = true;
                    return true;
                }
                else
                {
                    isDublicateUsernameBool = false;
                }
            }
            return false;
        }
        
        public static bool IsContatinAuthorId(int id)
        {
            for(int i = 0; i < database.Count; i++)
            {
                Authors authorTemp = (Authors)database[i];
                if (authorTemp.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void NewUsers(params Users[] user)
        {
            for (int i = 0; i < user.Length; i++)
            {
                Users userTemp = (Users)user[i];
                if (userTemp.Username != null)
                {
                    database.Add(user[i]);
                }

            }
        }

        public void NewAuthors(params Authors[] author)
        {
            for (int i = 0; i < author.Length; i++)
            {
                Authors userTemp = (Authors)author[i];
                    database.Add(author[i]);
            }
        }

        public void NewBooks(params Books[] book)
        {
            for (int i = 0; i < book.Length; i++)
            {
                Books userTemp = (Books)book[i];
                database.Add(book[i]);
            }
        }
    }
}
