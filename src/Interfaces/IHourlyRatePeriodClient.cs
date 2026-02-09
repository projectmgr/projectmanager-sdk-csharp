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
    /// API methods related to HourlyRatePeriod
    /// </summary>
    public interface IHourlyRatePeriodClient
    {

        /// <summary>
        /// Gets a list of all rate periods in a work space
        /// </summary>
        Task<AstroResult<HourlyRatePeriodDto[]>> GetRatePeriods();

        /// <summary>
        /// Creates a rate period
        /// </summary>
        /// <param name="body">The rate period start date.</param>
        Task<AstroResult<HourlyRatePeriodDto>> CreateRatePeriod(HourlyRatePeriodCreateDto body);
    }
}
