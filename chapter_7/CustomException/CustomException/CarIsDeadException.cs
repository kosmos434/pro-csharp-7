using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    /// <summary>
    /// this custom exception describes the details of the car-is-dead condition
    /// </summary>
    //public class CarIsDeadException : ApplicationException      // custom exceptions are public by convention
    //{
    //    //private string messageDetails = String.Empty;
    //    public DateTime ErrorTimeStamp { get; set; }
    //    public string CauseOfError { get; set; }

    //    public CarIsDeadException() { }
    //    // feed message to the parent constructor
    //    public CarIsDeadException(string message, string cause, DateTime time)
    //        :base(message)
    //    {
    //        //messageDetails = message;
    //        CauseOfError = cause;
    //        ErrorTimeStamp = time;
    //    }


    // type 'exception' for this code snippet
    [Serializable]
    public class CarIsDeadException : ApplicationException
    {

        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
        protected CarIsDeadException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        // custom members for our exception
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            //messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }

}
