using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// NonReplyStatOnDay Data Structure.
    /// </summary>
    [Serializable]
    public class NonReplyStatOnDay : TopObject
    {
        /// <summary>
        /// （某天的）未回复统计
        /// </summary>
        [XmlElement("nonreply_date")]
        public string NonreplyDate { get; set; }

        /// <summary>
        /// 未回复统计列表
        /// </summary>
        [XmlArray("nonreply_stat_list")]
        [XmlArrayItem("non_reply_statistics")]
        public List<NonReplyStatistics> NonreplyStatList { get; set; }
    }
}
