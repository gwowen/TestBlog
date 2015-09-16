using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TestBlog.Core.Objects;

namespace TestBlog.Core.Mappings
{
    public class TagMap: ClassMap<Tag>
    {
        public TagMap()
        {
            Id(x => x.Id);

            Map(x => x.Name)
                .Length(50)
                .Not.Nullable();
        }
    }
}
