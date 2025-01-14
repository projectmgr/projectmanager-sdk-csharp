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
    /// API methods related to ResourceTeam
    /// </summary>
    public interface IResourceTeamClient
    {

        /// <summary>
        /// Retrieves all ResourceTeams defined within your Workspace that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A ResourceTeam is a grouping of Resources that allows you to keep track of assignments
        /// in a manner consistent with your business needs.  You can assign Resources to be members
        /// of zero, one, or many ResourceTeams.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<ResourceTeamDto[]>> RetrieveResourceTeams(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Create a Resource Team.
        /// </summary>
        /// <param name="body">The name of the team to create.</param>
        Task<AstroResult<ResourceTeamDto>> CreateResourceTeam(CreateResourceTeamDto body);

        /// <summary>
        /// The endpoint is used to delete a resource team. Users assigned to this team will no longer be assigned thereafter.
        /// </summary>
        /// <param name="resourceTeamId">The Id of the team to be removed.</param>
        Task<AstroResult<string>> DeleteResourceTeam(Guid resourceTeamId);

        /// <summary>
        /// Update a Resource Team.
        /// </summary>
        /// <param name="teamresourceId">The id of the resource team</param>
        /// <param name="body">The name of the team to Update.</param>
        Task<AstroResult<ResourceTeamDto>> UpdateResourceTeam(Guid teamresourceId, UpdateResourceTeamDto body);
    }
}
