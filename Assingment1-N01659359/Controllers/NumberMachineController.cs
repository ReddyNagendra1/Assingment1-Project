using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1_N01659359.Controllers
{
    public class NumberMachineController : ApiController
    {
        
        /// performing 4 basic mathematical operation 
        /// </summary>
        /// <example>
        /// add : 3 + 3; => 6
        /// sub : 3 - 3; => 0
        /// mul : 3 * 3; => 9
        /// div : 3 / 3; => 1
        /// </example>
       

        public string Get(int id)
        {
            //Adding two same numbers
            int add = id + id;


            //Subtracting two same number
            int sub = id - id;


            //Multiplying the two same number 
            int mul = id * id;


            //dividing the number by 2 
            int div = id / 2;

            return $"Addition : {add}, Subtraction : {sub}, Multiplication : {mul}, Division : {div}";
        }
    }
}