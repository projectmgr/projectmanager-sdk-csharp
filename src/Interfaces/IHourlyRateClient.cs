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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to HourlyRate
    /// </summary>
    public interface IHourlyRateClient
    {

        /// <summary>
        /// Create a hourly rate
        /// </summary>
        /// <param name="body">The rate data.</param>
        Task<AstroResult<HourlyRateDto>> CreateHourlyRate(HourlyRateCreateDto body);

        /// <summary>
        /// All hourly rates including Inactive rates
        /// </summary>
        Task<AstroResult<HourlyRateDto[]>> GetHourlyRates();

        /// <summary>
        /// Update a hourly rate
        /// </summary>
        /// <param name="rateId">the id of the rate</param>
        /// <param name="body">the data to update the rate with</param>
        Task<AstroResult<HourlyRateDto>> UpdateHourlyRate(Guid rateId, HourlyRateUpdateDto body);

        /// <summary>
        /// Get Hourly Rate
        /// </summary>
        /// <param name="rateId">The unique identifier for the rate</param>
        Task<AstroResult<HourlyRateDetailsDto>> GetHourlyRate(Guid rateId);

        /// <summary>
        /// Delete a hourly rate
        /// </summary>
        /// <param name="rateId">The rate Id.</param>
        Task<AstroResult<string>> DeleteHourlyRate(Guid rateId);

        /// <summary>
        /// Update Hourly Rate Value
        /// </summary>
        /// <param name="rateValueId">The rate valueId</param>
        /// <param name="body">The rate value data</param>
        Task<AstroResult<HourlyRateValueDto>> UpdateHourlyRateValue(Guid rateValueId, HourlyRateValueUpdateDto body);
    }
}
