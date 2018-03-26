using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BS.WebMvc.UI.Models
{
    public class HomeViewModel
    {
        public ICollection<User> User { get; set; }
        public ICollection<Article> Article { get; set; }
    }
}