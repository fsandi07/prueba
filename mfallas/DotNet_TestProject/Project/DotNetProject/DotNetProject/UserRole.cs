//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole
    {
        public int roleId { get; set; }
        public string displayName { get; set; }
        public string roleDescription { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}