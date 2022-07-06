using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.DTOS
{
    public class PagingBase //dùng chung nên để ở dtos, cái nào muốn dùng thêm thì kế thừa và thêm các trường là sử dụng đc

    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
