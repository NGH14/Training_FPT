using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}