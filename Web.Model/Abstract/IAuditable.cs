using System;
using System.Collections.Generic;
using Web.Model.Models;

namespace Web.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { get; set; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string Metakeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
        
    }
}