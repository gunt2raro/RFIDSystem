using Ninject;
using System;
using System.Drawing;

namespace RFIDSystemTest.Warriror
{

    /// <summary>
    /// Injection class
    /// </summary>
    public static class Injection{
        public static IKernel kernel = new StandardKernel();
    }// End of Inject class

    /// <summary>
    /// The words
    /// </summary>
    public static class TWords {

        public static string SERVICE = "service";
        public static string VARDATA = "data";
        public static string SLASH = "/";
        public static string ONEPARAM = "/{0}";
        public static string EMPTY = "";
        
    }// End of TWords class
    

    /// <summary>
    /// Data Convert
    /// </summary>
    public static class DataConvert{

        /// <summary>
        /// Json String to DateTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime StringJsonToDateTime(string date)
        {
            try
            {
                return Convert.ToDateTime(date);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new DateTime (0,0,0);
            }

        }
            

        /// <summary>
        /// Date Time To Json String format 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DateTimeToJsonString( DateTime dt ) {

            return dt.ToString("yyyy-MM-dd");

        }// End of Date Time To Json String function

        /// <summary>
        /// Date time to json string with time
        /// </summary>
        /// <returns></returns>
        public static string DateTimeToJsonStringWithTime( DateTime dt ) {

            return dt.ToString("yyyy-MM-ddTHH:mm:ssZ");

        }// End of DateTime to json string function

        /// <summary>
        /// Image to byte function
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }// End of ImageToByte function

    }// End of DataConvert class
    
    /// <summary>
    /// Http method enum
    /// </summary>
    public enum HttpMethod
    {
        GET,
        PUT,
        POST,
        DELETE
    }//End of http enum

    public enum DataType {
        JSON, 
        xML,
        HTML,
        PLAIN
    }// End of Data types
}//End of namespace
