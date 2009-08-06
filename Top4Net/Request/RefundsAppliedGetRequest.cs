using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refunds.apply.get
    /// </summary>
    public class RefundsAppliedGetRequest : ITopRequest
    {
        /// <summary>
        /// 退款状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// guarantee_trade,一口价、拍卖,auto_delivery,自动发货,independent_shop_trade,外部网店的交易。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refunds.apply.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("status", this.Status);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("fields", this.Fields);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}