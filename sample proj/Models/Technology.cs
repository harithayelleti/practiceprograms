//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SamplePorj1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technology
    {
        public int JobId { get; set; }
        public string Technologyname { get; set; }
    
        public virtual Job Job { get; set; }
    }
}
