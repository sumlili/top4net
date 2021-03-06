using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// OnlineTimesOnDay Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineTimesOnDay : TopObject
    {
        /// <summary>
        /// 在线日期
        /// </summary>
        [XmlElement("online_date")]
        public string OnlineDate { get; set; }

        /// <summary>
        /// 在线时长列表
        /// </summary>
        [XmlArray("online_time_list")]
        [XmlArrayItem("online_times")]
        public List<OnlineTimes> OnlineTimeList { get; set; }
    }
}
