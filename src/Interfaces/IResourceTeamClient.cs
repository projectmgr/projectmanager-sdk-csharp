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
        /// Retrieves all ResourceTeams defined within your Workspace.
        ///
        /// A ResourceTeam is a grouping of Resources that allows you to keep track of assignments in a manner consistent with your business needs.  You can assign Resources to be members of zero, one, or many ResourceTeams.
        ///
        /// </summary>
        Task<AstroResult<BusinessTeamDto[]>> RetrieveResourceTeams();
    }
}
