using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Intrastructure
{
    public interface IDbFactory:IDisposable
    {
        APIDbContext Init();
    }
}
