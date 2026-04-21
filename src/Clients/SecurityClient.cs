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
    /// API methods related to Security
    /// </summary>
    public class SecurityClient : ISecurityClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public SecurityClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns every business role in the current workspace, including built-in and custom roles.
        ///
        /// Each role includes a permissions object with entitlement and grant state for the account security matrix.
        /// </summary>
        public async Task<AstroResult<BusinessRolesListDto>> ListBusinessRoles()
        {
            var url = $"/api/data/security/businessroles";
            return await _client.Request<BusinessRolesListDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Chargebee entitlements are evaluated read-only when saving permission grants; this call does not change subscription state.
        /// </summary>
        /// <param name="body">Role name, optional description, and permission settings for the new role.</param>
        public async Task<AstroResult<RoleDto>> CreateBusinessRole(RoleCreateDto body)
        {
            var url = $"/api/data/security/businessroles";
            return await _client.RequestWithBody<RoleDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Send property change sets using the same pattern as other workspace batch-update APIs.
        ///
        /// For permissions, include a permissions property with a partial or full permissions object; omitted keys are merged with the current role.
        /// Keys may use the same names as GET `permissions` (e.g. `editUsers`) or RetrieveMe / POST-create style (e.g. `editUser`).
        /// The response body matches create when successful.
        /// </summary>
        /// <param name="roleId">Business role identifier.</param>
        /// <param name="body">List of property name and value pairs to apply.</param>
        public async Task<AstroResult<RoleDto>> UpdateBusinessRole(Guid roleId, RoleUpdateChangeItemDto[] body)
        {
            var url = $"/api/data/security/businessroles/{roleId}";
            return await _client.RequestWithBody<RoleDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Built-in roles cannot be deleted. Users assigned to the role may need to be reassigned before the role can be removed.
        /// </summary>
        /// <param name="roleId">Identifier of the custom role to remove.</param>
        public async Task<AstroResult<string>> DeleteBusinessRole(Guid roleId)
        {
            var url = $"/api/data/security/businessroles/{roleId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Sends another validation email to the authenticated user&#39;s workspace email address.
        /// </summary>
        public async Task<AstroResult<string>> ResendEmailValidation()
        {
            var url = $"/api/data/security/email/validation/resend";
            return await _client.Request<string>(HttpMethod.Get, url, null);
        }
    }
}
