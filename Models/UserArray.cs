using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class UserArray
    {
        List<User> UserList = new List<User>();

        public UserArray(List<User> users)
        {
            users = UserList;
        }
        public void addUser(User user)
        {
            UserList.Add(user);
        }
       
        public int getSize()
        {
            return UserList.Count;
        }
        public User getUser(int i)
        {
            return UserList[i];
        }
        public User getUserByUser(User user)
        {for (int i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].Equals(user))
                {
                    return UserList[i];
                }
            }return null;
        }
    }
}
