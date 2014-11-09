using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SimpleBlog.Util
{
    public static class Util
    {
        // Useful methods

        /// <summary>
        /// Performs a SHA256 hash in a given string.
        /// </summary>
        /// <param name="value">The desired string</param>
        /// <returns>The SHA256 converted value</returns>
        public static string SHA256(this string value)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(value), 0, Encoding.UTF8.GetByteCount(value));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }
    }
}