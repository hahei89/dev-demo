using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev_demo.Ucontrols
{
    public partial class UPager : UserControl
    {
        private int count;

        /// <summary>
        /// 记录数
        /// </summary>
        public int Count
        {
            get { return count; }
            set 
            { 

                count = value;
                // InitPageInfo();
            }
        }

        /// <summary>
        /// 当前页开始索引
        /// </summary>
        private int startIndex;

        public int StartIndex
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
            set { startIndex = value; }
        }
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        /// <summary>
        /// 当前页索引
        /// </summary>
        private int currentPage;

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        private int pageNum;
        public int PageNum
        {
            get
            {
                if (Count == 0)
                {
                    pageNum = 0;
                }
                else 
                {
                    pageNum = (int)Math.Ceiling((double)count / pageSize);
                }
                return pageNum;
            }
        }

        public UPager()
        {
            InitializeComponent();
        }
    }
}
