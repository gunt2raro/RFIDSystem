﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static string SLASH = "/";
        public static string ONEPARAM = "/{0}";
        public static string EMPTY = "";
    }// End of TWords class

    /// <summary>
    /// Data Convert
    /// </summary>
    public static class DataConvert{

        /// <summary>
        /// Date Time To Json String format 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DateTimeToJsonString( DateTime dt ) {

            return dt.ToString("yyyy-MM-dd");

        }// End of Date Time To Json String function

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

}//End of namespace
