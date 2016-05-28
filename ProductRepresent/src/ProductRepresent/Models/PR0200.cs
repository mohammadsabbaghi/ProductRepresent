using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRepresent.Models
{
    /// <summary>
    /// کلاس مربوط به گروه های کاری موجود در سایت
    /// </summary>
    public class PR0200
    {
        /// <summary>
        /// کد گروه کاری
        /// </summary>
        public int PR0201 { get; set; }
        /// <summary>
        /// کد موضوع سایت
        /// </summary>
        public int PR0202 { get; set; }
        /// <summary>
        /// تصویر گروه کاری
        /// </summary>
        public byte PR0203 { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string PR0204 { get; set; }
        /// <summary>
        /// وضعیت
        /// </summary>
        public bool PR0205 { get; set; }
    }
}
