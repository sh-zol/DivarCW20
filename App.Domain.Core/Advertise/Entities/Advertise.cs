using App.Domain.Core.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Entities
{
    public class Advertise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId {  get; set; }
        public int CityId {  get; set; }
        public int UserId {  get; set; }
        public List<User.Entities.User> UserBookmarks {  get; set; }
      //  public List<BookMark> bookMarks { get; set; }
        public Category Category { get; set; }
        public City City {  get; set; }
        public User.Entities.User User { get; set; }
    }
}
