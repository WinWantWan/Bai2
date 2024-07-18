using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001216261_CuDucTruong_buoi5
{
    public enum LoginResult
    {
        /// <summary>
        /// Wrong username or password
        /// </summary>
        Invalid,
        /// <summary>
        /// User had been disabled
        /// </summary>
        Disabled,
        /// <summary>
        /// Loging success
        /// </summary>
        Success
    }
}
