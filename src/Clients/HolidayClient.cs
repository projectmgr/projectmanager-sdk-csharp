/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Holiday
    /// </summary>
    public class HolidayClient : IHolidayClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public HolidayClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve a list of resource holidays that match an [OData formatted query](https://www.odata.org/).
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<ResourceHolidayDto[]>> Queryresourceholidays(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/holidays/resource";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (select != null) { options["$select"] = select; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<ResourceHolidayDto[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieve a list of country holidays that match an [OData formatted query](https://www.odata.org/).
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<CountryHolidayDto[]>> Querycountryholidays(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/holidays/country";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (select != null) { options["$select"] = select; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<CountryHolidayDto[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieve a list of global holidays that match an [OData formatted query](https://www.odata.org/).
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<GlobalHolidayDto[]>> Queryglobalholidays(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/holidays/global";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (select != null) { options["$select"] = select; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<GlobalHolidayDto[]>(HttpMethod.Get, url, options, null, null);
        }
    }
}
