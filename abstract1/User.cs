using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT1.abstract1
{
    internal abstract class User
    {
        public string username { get; set; }
        protected User(string username)
        {
            this.username = username;
        }
        public abstract Discount GetDiscount();
    }
    class RegularUser : User
    {
        public RegularUser(string username) : base(username)
        {
            this.username = username;
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
    class PremiumUser : User
    {
        public PremiumUser(string username) : base(username)
        {
            this.username = username;
        }
        public override Discount GetDiscount()
        {
            return new FlatDiscount();
        }
    }
    class GuestUser : User
    {
        public GuestUser(string username) : base(username)
        {
            this.username = username;
        }
        public override Discount GetDiscount()
        { 
            return null ;
        }
    }
}
