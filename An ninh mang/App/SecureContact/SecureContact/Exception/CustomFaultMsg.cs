using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SecureContact
{
    [DataContract]
    public class CustomFaultMsg
    {
        public CustomFaultMsg()
        {}

        public CustomFaultMsg(string message):this()
        {
            Message = message;
        }

        [DataMember]
        public string Message { get; set; }
    }
}