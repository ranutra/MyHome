//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyHome.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public int SenderId { get; set; }
        public int RecipentId { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
