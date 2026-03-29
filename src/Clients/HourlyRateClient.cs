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
    /// API methods related to HourlyRate
    /// </summary>
    public class HourlyRateClient : IHourlyRateClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public HourlyRateClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Create a hourly rate
        /// </summary>
        /// <param name="body">The rate data.</param>
        public async Task<AstroResult<HourlyRateDto>> CreateHourlyRate(HourlyRateCreateDto body)
        {
            var url = $"/api/data/hourly-rates";
            return await _client.RequestWithBody<HourlyRateDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// All hourly rates including Inactive rates
        /// </summary>
        public async Task<AstroResult<HourlyRateDto[]>> GetHourlyRates()
        {
            var url = $"/api/data/hourly-rates";
            return await _client.Request<HourlyRateDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Update Hourly Rate Value
        /// </summary>
        /// <param name="rateValueId">The rate valueId</param>
        /// <param name="body">The rate value data</param>
        public async Task<AstroResult<HourlyRateValueDto>> UpdateHourlyRateValue(Guid rateValueId, HourlyRateValueUpdateDto body)
        {
            var url = $"/api/data/hourly-rates/values/{rateValueId}";
            return await _client.RequestWithBody<HourlyRateValueDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Get Hourly Rate
        /// </summary>
        /// <param name="rateId">The unique identifier for the rate</param>
        public async Task<AstroResult<HourlyRateDetailsDto>> GetHourlyRate(Guid rateId)
        {
            var url = $"/api/data/hourly-rates/{rateId}";
            return await _client.Request<HourlyRateDetailsDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Delete a hourly rate
        /// </summary>
        /// <param name="rateId">The rate Id.</param>
        public async Task<AstroResult<string>> DeleteHourlyRate(Guid rateId)
        {
            var url = $"/api/data/hourly-rates/{rateId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
