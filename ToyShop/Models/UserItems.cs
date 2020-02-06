using System;
using System.Collections.Generic;

namespace ToyShop.Models
{
    public partial class UserItems
    {
        public int UserItemId { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }

        public virtual Items Item { get; set; }
        public virtual Users User { get; set; }
    }
}
