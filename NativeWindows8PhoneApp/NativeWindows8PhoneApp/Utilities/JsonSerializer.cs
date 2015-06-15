using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NativeWindows8PhoneApp.Utilities
{
    /// <summary>
    /// Using a third party library for json conversion
    /// Newtonsoft.Json
    /// </summary>
    public static class JsonSerializer
    {   
        /// <summary>
        /// Method for Serialization.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Serializer<TSource>(TSource source)
        {
            return (string)JsonConvert.SerializeObject(source);
        }
        /// <summary>
        /// Method for Deserialization.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static TResult Deserialize<TResult>(string json)
        {
            TResult deserializedObject;
            deserializedObject = (TResult)JsonConvert.DeserializeObject<TResult>(json);
            return deserializedObject;
        }
     }    
}
