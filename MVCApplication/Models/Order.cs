//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Nullable<int> moviePos { get; set; }
        public Nullable<int> theaterID { get; set; }
        public Nullable<int> showTime { get; set; }
        public Nullable<int> clientIdentification { get; set; }
        public Nullable<int> price { get; set; }
        public int uuid { get; set; }
        public string movieID { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual Theater Theater { get; set; }
    }
}
