using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.User.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public List<Advertise.Entities.Advertise> Advertises {  get; set; }
       // public List<Advertise.Entities.BookMark> UserBookMarks {  get; set; }
        public List<Advertise.Entities.Advertise> BookMark { get; set; } 
    }
}
