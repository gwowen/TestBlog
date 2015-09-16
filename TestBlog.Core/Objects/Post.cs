using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlog.Core.Objects
{
    public class Post
    {
        public virtual int Id
        { get; set; }

        public virtual string Title
        { get; set; }

        public virtual string ShortDescription
        { get; set; }

        public virtual string Description
        { get; set; }

        public virtual string Meta
        { get; set; }

        //for my own editification:
        //URL Slug
        //A URL slug is a SEO- and user-friendly string-part in a URL to identify, 
        //describe and access a resource. Often the title of a page/article is a valid candidate.

        public virtual string UrlSlug
        { get; set; }

        public virtual bool Published
        { get; set; }

        public virtual DateTime PostedOn
        { get; set; }

        public virtual DateTime? Modified
        { get; set; }

        public virtual Category Category
        { get; set; }

        public virtual IList<Tag> Tag
        { get; set; }
    }
}
