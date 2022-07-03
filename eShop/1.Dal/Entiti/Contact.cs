
using _1.Dal.Entiti.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Entiti
{
    public class Contact
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public Status Status { set; get; }
    }
}
