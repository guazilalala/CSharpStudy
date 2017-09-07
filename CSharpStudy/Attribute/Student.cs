using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeStudy
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 名字
        /// </summary>
        private string name;
        [Require(true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        [Require(true)]
        public int Age { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Require(false)]
        public string Address { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Require(true)]
        public string Sex;
    }
}
