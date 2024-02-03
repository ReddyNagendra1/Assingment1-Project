using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1_N01659359.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// multipling the given input with it self  
        /// </summary>
        // <param name="id">The input number multiplies by the same number</param>
        /// <returns>The input number get multipliedby itself</returns>
        /// Get localhost:xx/api/3 => 9
        public int Get(int id)
        {
            int square = id*id;

            return square;
        }
    }
}
