using BS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model.Entities
{
    public class User : IEntity
    {
        public User()
        {
            Article = new HashSet<Article>();
        }
        public int ID { get; set; }

        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserPass { get; set; }

        public virtual ICollection<Article> Article { get; set; }


    }
}
