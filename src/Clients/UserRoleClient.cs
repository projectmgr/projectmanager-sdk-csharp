/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
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
    /// API methods related to UserRole
    /// </summary>
    public class UserRoleClient : IUserRoleClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserRoleClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the list of UserRoles defined within this Workspace.
        ///
        /// A UserRole is a name for a privilege level granted to a specific User.  The &#39;Global Admin&#39; UserRole is granted to the owner of the Workspace, and this UserRole cannot be changed. You can choose which UserRole applies to a User within your Workspace.
        ///
        /// </summary>
        public async Task<AstroResult<UserRoleDto[]>> RetrieveUserRoles()
        {
            var url = $"/api/data/users/roles";
            return await _client.Request<UserRoleDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
