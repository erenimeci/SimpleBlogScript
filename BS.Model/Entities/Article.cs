using BS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model.Entities
{
    public class Article : IEntity
    {
        public int ID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleText { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual User CreatedBy { get; set; }


    }
}
