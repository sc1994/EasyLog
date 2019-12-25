using System;
using System.Collections.Generic;

namespace EasyLog.WriteLog
{
    public interface IFilterGetWay
    {

    }

    public class FilterGetWayByString : IFilterGetWay
    {
        /// <summary>
        /// 过滤方式 
        /// </summary>
        public FilterGetWayStringEnum FilterWay { get; set; }

        public Func<string, string> GetFilterFunc { get; set; }
    }

    public class FilterGetWayByDictionary : IFilterGetWay
    {
        /// <summary>
        /// 过滤方式 
        /// </summary>
        public FilterGetWayDictionaryEnum FilterWay { get; set; }

        public Func<IDictionary<string, string>, string> GetFilterFunc { get; set; }
    }

    public enum FilterGetWayStringEnum
    {
        Url,
        RequestBody,
        ResponseBody
    }

    public enum FilterGetWayDictionaryEnum
    {
        RequestHeaders,
        RequestCookies,
        ResponseHeaders,
        ResponseCookies
    }
}