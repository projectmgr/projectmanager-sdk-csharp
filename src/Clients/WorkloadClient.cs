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
    /// API methods related to Workload
    /// </summary>
    public class WorkloadClient : IWorkloadClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public WorkloadClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve information about the expected workload for a Resource.  The workload for a Resource is a list of
        /// tasks, days, and the amount of time spent on each task per day.  You can examine a Resource&#39;s workload to
        /// identify when that Resource is required to contribute to specific tasks.
        ///
        /// To query for workload for a Resource, you must first know the unique identifier of the Resource.  You may
        /// use the QueryResource API to identify the resource, and then use its `id` field to call `QueryResourceWorkload`.
        ///
        /// Workload is defined in two ways: either automatically by the ProjectManager.com system, or manually by editing
        /// the workload page within the ProjectManager.com app.  When you query for workload information, each entry will
        /// specify whether the assignment was created manually or via the system.  If a task does not have any workload
        /// allocated, it will not be returned by this API.
        ///
        /// The `QueryResourceWorkload` API uses Gridify-style querying. For a full description of query rules, see
        /// [Querying Tutorial](https://developer.projectmanager.com/getting-started/querying-tutorial).  When querying
        /// for workload, you can use filters, sorting, pagination, and you can also request additional
        /// data to be included in the API result.  The QueryResourceWorkload API returns a maximum of 1000 results per
        /// request as a single page.  To retrieve all workload for a Resource, you must fetch pages starting with the
        /// number 1 until no additional data is returned.
        /// </summary>
        /// <param name="resourceId">The id of the Resource</param>
        /// <param name="filter">A Gridify formatted filter used to search by `task.projectId` and/or `date` and/or `minutes`</param>
        /// <param name="sort">A Gridify formatted ordering used to sort by `date`, `task.name` and/or `createdDate`. Defaults to `date asc`.</param>
        /// <param name="include">A comma separated list of additional data to include in each result. Set to `task` to include basic Task details, and/or `assignment` to include the assignment's total assigned minutes.</param>
        /// <param name="page">The page number to retrieve, starting at 1. Defaults to 1. Pages over individual allocations.</param>
        /// <param name="pageSize">The number of allocations, no less than 1 or more than 1000, per page. Defaults to 1000.</param>
        public async Task<AstroResult<ResourceWorkloadAllocationDto[]>> QueryResourceWorkload(Guid resourceId, string filter = null, string sort = null, string include = null, int? page = null, int? pageSize = null)
        {
            var url = $"/api/data/workload/resources/{resourceId}";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (sort != null) { options["sort"] = sort; }
            if (include != null) { options["include"] = include; }
            if (page != null) { options["page"] = page; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            return await _client.Request<ResourceWorkloadAllocationDto[]>(HttpMethod.Get, url, options);
        }
    }
}
