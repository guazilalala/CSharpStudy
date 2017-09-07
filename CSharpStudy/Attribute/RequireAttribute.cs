using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeStudy
{
    /// <summary>
    /// 【必填】特性，继承自Attribute
    /// </summary>
    public sealed class RequireAttribute : Attribute
    {
        private bool isRequire;
        public bool IsRequire
        {
            get { return isRequire; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="isRequire"></param>
        public RequireAttribute(bool isRequire)
        {
            this.isRequire = isRequire;
        }
    }
}
