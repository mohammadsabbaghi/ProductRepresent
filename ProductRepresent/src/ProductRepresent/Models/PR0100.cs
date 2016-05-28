using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRepresent.Models
{
    /// <summary>
    /// کلاس مربوط به موضوع سایت
    /// </summary>
    public class PR0100
    {
        /// <summary>
        /// کد موضوع سایت
        /// </summary>
        public int PR0101 { get; set; }
        /// <summary>
        /// عنوان موضوع سایت
        /// </summary>
        public string PR0102 { get; set; }
        /// <summary>
        /// تصویر مربوط به آن موضوع
        /// </summary>
        public byte PR0103 { get; set; }
        /// <summary>
        /// آدرس سایت
        /// </summary>
        public string PR0104 { get; set; }
        /// <summary>
        /// وضعیت
        /// </summary>
        public bool PR0105 { get; set; }
    }
}
