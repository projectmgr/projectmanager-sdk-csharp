/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
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
    /// API methods related to HourlyRatePeriod
    /// </summary>
    public class HourlyRatePeriodClient : IHourlyRatePeriodClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public HourlyRatePeriodClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Gets a list of all rate periods in a work space
        /// </summary>
        public async Task<AstroResult<HourlyRatePeriodDto[]>> GetRatePeriods()
        {
            var url = $"/api/data/hourly-rate-periods";
            return await _client.Request<HourlyRatePeriodDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a rate period
        /// </summary>
        /// <param name="body">The rate period start date.</param>
        public async Task<AstroResult<HourlyRatePeriodDto>> CreateRatePeriod(HourlyRatePeriodCreateDto body)
        {
            var url = $"/api/data/hourly-rate-periods";
            return await _client.RequestWithBody<HourlyRatePeriodDto>(HttpMethod.Post, url, null, body);
        }
    }
}
