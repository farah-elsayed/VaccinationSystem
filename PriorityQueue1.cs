using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    class PriorityQueue1<User> : IEnumerable<User> where User : IComparable<User>
    {

        LinkedList<User> users = new LinkedList<User>();

        public int count()
        {
            return users.Count();
        }

        public void enqueue(User user)
        {
            if (users.Count == 0)
            {
                users.AddLast(user);
            }
            else
            {
                var current = users.First;
                while (current != null && current.Value.CompareTo(user) > 0)
                {
                    current = current.Next;
                }
                if (current == null)
                {
                    users.AddLast(user);
                }
                else
                {
                    users.AddBefore(current, user);
                }
            }
            
           
        }
        public User deque()
        {
            if (users.Count == 0)
            {
                throw new InvalidOperationException("queue is empty");
            }
            User user = users.First.Value;
            users.RemoveFirst();
            return user;
        }
        public bool empty()
        {
            return (users.Count == 0);
        }
        public IEnumerator<User> GetEnumerator()
        {
            throw new NotImplementedException();
        }
         public User Peek()
        {
            if(users.Count == 0 )
            {
                throw new InvalidOperationException("Queue is Empty");
            }
            return users.First.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
