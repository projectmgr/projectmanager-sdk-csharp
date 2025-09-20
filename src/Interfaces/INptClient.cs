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
    /// API methods related to Npt
    /// </summary>
    public interface INptClient
    {

        /// <summary>
        /// Retrieve a Non-Project Task (NPT) by its unique identifier or by its short ID.
        /// An NPT has both a unique identifier, which is a GUID, and a short ID, which is a small text label that is unique only within your Workspace.
        ///
        /// A Non-Project Task (NPT) is an individual element of work that is outside of a project.
        /// Many people use NPTs to track personal work or general administrative work.  NPTs have nearly
        /// all the same features as other tasks, but since they are not part of a project, they can
        /// be tracked separately by individuals.
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        Task<AstroResult<NptDetailsDto>> GetNpt(string nptId);

        /// <summary>
        /// Updates a Non-Project Task (NPT) by its unique identifier, which is a GUID.
        ///
        /// A Non-Project Task (NPT) is an individual element of work that is outside of a project.
        /// Many people use NPTs to track personal work or general administrative work.  NPTs have nearly
        /// all the same features as other tasks, but since they are not part of a project, they can
        /// be tracked separately by individuals.
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        /// <param name="body">the fields to update</param>
        Task<AstroResult<NptDto>> UpdateNpt(Guid nptId, NptUpdateDto body);

        /// <summary>
        /// Removes a Non-Project Task (NPT) by its unique identifier, which is a GUID.
        ///
        /// A Non-Project Task (NPT) is an individual element of work that is outside of a project.
        /// Many people use NPTs to track personal work or general administrative work.  NPTs have nearly
        /// all the same features as other tasks, but since they are not part of a project, they can
        /// be tracked separately by individuals.
        /// </summary>
        /// <param name="nptId">the id of the npt to remove</param>
        Task<AstroResult<string>> RemoveNpt(Guid nptId);

        /// <summary>
        /// Creates a new Non-Project Task (NPT) for the current user. If you specify an assignee for this NPT, that user will be assigned to this task.
        /// If you do not specify an assignee, the NPT will be automatically assigned to you.
        ///
        /// A Non-Project Task (NPT) is an individual element of work that is outside of a project.
        /// Many people use NPTs to track personal work or general administrative work.  NPTs have nearly
        /// all the same features as other tasks, but since they are not part of a project, they can
        /// be tracked separately by individuals.
        /// </summary>
        /// <param name="body">The data used to create the Npt</param>
        Task<AstroResult<NptDto>> CreateNpt(NptCreateDto body);
    }
}
