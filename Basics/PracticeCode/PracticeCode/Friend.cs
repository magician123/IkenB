using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace PracticeCode
{
    public class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
            friend.Friends.Add(this);
        }

        public bool CanBeConnected(Friend friends)
        {
            bool canConnect = true;

            return canConnect;
        }

        //public static void Main(string[] args)
        //{
        //    Friend a = new Friend("A");
        //    Friend b = new Friend("B");
        //    Friend c = new Friend("C");

        //    a.AddFriendship(b);
        //    b.AddFriendship(c);

        //    Console.WriteLine(a.CanBeConnected(c));
        //}
    }
}
