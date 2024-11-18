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
    /// API methods related to ProjectCustomer
    /// </summary>
    public class ProjectCustomerClient : IProjectCustomerClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectCustomerClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectCustomers defined within your Workspace.
        ///
        /// A ProjectCustomer is a code used to identify customers associated with your Projects.  Each
        /// ProjectCustomer has a name and a unique identifier.  ProjectCustomers are defined per
        /// Workspace and are shared among Projects.
        /// </summary>
        public async Task<AstroResult<ProjectCustomerDto[]>> RetrieveProjectCustomers()
        {
            var url = $"/api/data/projects/customers";
            return await _client.Request<ProjectCustomerDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Create a project customer
        /// </summary>
        /// <param name="body">The data to create the customer</param>
        public async Task<AstroResult<ProjectCustomerDto>> CreateProjectCustomer(ProjectCustomerCreateDto body)
        {
            var url = $"/api/data/projects/customers";
            return await _client.RequestWithBody<ProjectCustomerDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates a project customer
        /// </summary>
        /// <param name="customerId">The id of the customer to update</param>
        /// <param name="body">The data to update</param>
        public async Task<AstroResult<ProjectCustomerDto>> UpdateProjectCustomer(Guid customerId, ProjectCustomerCreateDto body)
        {
            var url = $"/api/data/projects/customers/{customerId}";
            return await _client.RequestWithBody<ProjectCustomerDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Delete a project customer. They will also be removed from any projects they were assigned too.
        /// </summary>
        /// <param name="customerId">The id of the customer to remove</param>
        public async Task<AstroResult<string>> DeleteProjectCustomer(Guid customerId)
        {
            var url = $"/api/data/projects/customers/{customerId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
