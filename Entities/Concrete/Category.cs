using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
