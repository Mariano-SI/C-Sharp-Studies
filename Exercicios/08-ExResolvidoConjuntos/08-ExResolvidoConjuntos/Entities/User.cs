using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ExResolvidoConjuntos.Entities
{
    internal class User
    {
        public string UserName { get; set; }
        public DateTime AcessTime { get; set; }

        public User(string userName, DateTime acessTime)
        {
            UserName = userName;
            AcessTime = acessTime;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is User))
            {
                throw new ArgumentException("Obj must be a User");
            }

            User other = obj as User;

            return UserName.Equals(other.UserName);
        }
    }
}
