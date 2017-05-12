using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceAjaxPractise
{
    public class User
    {
        Dictionary<int, string> users = null;
        public User()
        {
            users = new Dictionary<int, string>();
            users.Add(1, "Pranay");
            users.Add(2, "Krunal");
            users.Add(3, "Aditya");
            users.Add(4, "Samir");
        }

        public string[] GetUser(int Id)
        {
            var user = users.Where(u => u.Key == Id).Select(u => u.Value);
            return user.ToArray<string>();
        }
    }
}