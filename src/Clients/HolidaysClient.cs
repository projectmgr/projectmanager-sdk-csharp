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
    /// API methods related to Holidays
    /// </summary>
    public class HolidaysClient : IHolidaysClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public HolidaysClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns all Holidays defined in the current workspace, sorted by name.
        ///
        /// This &quot;list&quot; API returns basic information about Holidays and may be restricted to partial information. To
        /// receive all information about a specific Holiday, use RetrieveHoliday.
        ///
        /// A Holiday is a defined date when one or more Resources are not available for work.  Holidays may be defined by
        /// Workspace, by Country, or by Resource. A Workspace Holiday means that no Resources in the Workspace are working for
        /// that date. A Country Holiday means that no Resources in the Workspace located within the country are working for
        /// that date.  A Resource Holiday means that the specified Resource is not working on that date.
        /// </summary>
        public async Task<AstroResult<HolidayListItemDto[]>> ListHolidays()
        {
            var url = $"/api/data/holidays";
            return await _client.Request<HolidayListItemDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates one or more Holiday for a Resource, a Country, or the entire Workspace.
        ///
        /// A Holiday can be created based on multiple crtieria, including a date range, a list of Resource identifiers, and
        /// a list of countries.  You may use one or more of these criteria when calling CreateHolidays, and the API will
        /// expand your criteria into individual Holiday records for each combination of criteria.
        ///
        /// A Holiday is a defined date when one or more Resources are not available for work.  Holidays may be defined by
        /// Workspace, by Country, or by Resource. A Workspace Holiday means that no Resources in the Workspace are working for
        /// that date. A Country Holiday means that no Resources in the Workspace located within the country are working for
        /// that date.  A Resource Holiday means that the specified Resource is not working on that date.
        /// </summary>
        /// <param name="body">The information about the Holiday to create</param>
        public async Task<AstroResult<HolidayDetailDto[]>> CreateHolidays(HolidayCreateDto body)
        {
            var url = $"/api/data/holidays";
            return await _client.RequestWithBody<HolidayDetailDto[]>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Retrieve all detail about a single Holiday defined by its unique identifier.
        ///
        /// A Holiday is a defined date when one or more Resources are not available for work.  Holidays may be defined by
        /// Workspace, by Country, or by Resource. A Workspace Holiday means that no Resources in the Workspace are working for
        /// that date. A Country Holiday means that no Resources in the Workspace located within the country are working for
        /// that date.  A Resource Holiday means that the specified Resource is not working on that date.
        /// </summary>
        /// <param name="id">Unique identifier of the holiday</param>
        public async Task<AstroResult<HolidayDetailDto>> RetrieveHoliday(Guid id)
        {
            var url = $"/api/data/holidays/{id}";
            return await _client.Request<HolidayDetailDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Update the name of a Holiday based on the information provided.
        ///
        /// The Holiday record has a &quot;name&quot; or &quot;reason&quot; that can be used to identify the name of the Holiday.  When a
        /// Holiday is specific to an individual person, it may have a reason identifying why the resource is taking
        /// paid time off.  You can update this name or reason, but you cannot change the other values for a Holiday.  To
        /// change a Holiday&#39;s date, resource ID, or country, you must delete the Holiday and create a new one.
        ///
        /// A Holiday is a defined date when one or more Resources are not available for work.  Holidays may be defined by
        /// Workspace, by Country, or by Resource. A Workspace Holiday means that no Resources in the Workspace are working for
        /// that date. A Country Holiday means that no Resources in the Workspace located within the country are working for
        /// that date.  A Resource Holiday means that the specified Resource is not working on that date.
        /// </summary>
        /// <param name="id">Unique identifier of the holiday</param>
        /// <param name="body">Information to be updated for the Holiday</param>
        public async Task<AstroResult<HolidayDetailDto>> UpdateHolidayName(Guid id, HolidayUpdateDto body)
        {
            var url = $"/api/data/holidays/{id}";
            return await _client.RequestWithBody<HolidayDetailDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Removes the Holiday identified by its unique identifier.
        ///
        /// Some information about a Holiday cannot be updated once the Holiday is created.  If you want to change the name
        /// or reason for a Holiday, you can use `UpdateHoliday`.  To change other information, you should delete the old
        /// Holiday and create a new one with the correct information.
        ///
        /// A Holiday is a defined date when one or more Resources are not available for work.  Holidays may be defined by
        /// Workspace, by Country, or by Resource. A Workspace Holiday means that no Resources in the Workspace are working for
        /// that date. A Country Holiday means that no Resources in the Workspace located within the country are working for
        /// that date.  A Resource Holiday means that the specified Resource is not working on that date.
        /// </summary>
        /// <param name="id">Unique identifier of the holiday</param>
        public async Task<AstroResult<string>> DeleteHoliday(Guid id)
        {
            var url = $"/api/data/holidays/{id}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
