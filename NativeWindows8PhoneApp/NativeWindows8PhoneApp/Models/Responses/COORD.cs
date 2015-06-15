using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace NativeWindows8PhoneApp.Models.Responses
{
    [DataContract]
    public class COORD
    {
        [DataMember(Name = "lon")]
        public double Longitude { get; set; }

        [DataMember(Name = "lat")]
        public double Latitude { get; set; }
    }
}
