using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySql
{
    public class Book
    {
        /// <summary>
        /// 主键
        /// </summary>
        private long _id;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// 发行时间
        /// </summary>
        private DateTime _pubTime;

        public DateTime PubTime
        {
            get { return _pubTime; }
            set { _pubTime = value; }
        }

        /// <summary>
        /// 单价
        /// </summary>
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// 作者名字
        /// </summary>
        private string _autorName;

        public string AutorName
        {
            get { return _autorName; }
            set { _autorName = value; }
        }

    }
}
