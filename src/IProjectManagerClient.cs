/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 *             
 * @copyright  2023-2023 ProjectManager.com, Inc.
 * @version    11.1.1438
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */

using ProjectManager.SDK.Interfaces;


namespace ProjectManager.SDK 
{
    /// <summary>
    /// A client object that connects to the ProjectManager API
    /// </summary>
    public interface IProjectManagerClient
    {
        /// <summary>
        /// API methods related to Changeset
        /// </summary>
        IChangesetClient Changeset { get; }
        /// <summary>
        /// API methods related to Discussion
        /// </summary>
        IDiscussionClient Discussion { get; }
        /// <summary>
        /// API methods related to Project
        /// </summary>
        IProjectClient Project { get; }
        /// <summary>
        /// API methods related to ProjectChargeCode
        /// </summary>
        IProjectChargeCodeClient ProjectChargeCode { get; }
        /// <summary>
        /// API methods related to ProjectCustomer
        /// </summary>
        IProjectCustomerClient ProjectCustomer { get; }
        /// <summary>
        /// API methods related to ProjectField
        /// </summary>
        IProjectFieldClient ProjectField { get; }
        /// <summary>
        /// API methods related to ProjectFolder
        /// </summary>
        IProjectFolderClient ProjectFolder { get; }
        /// <summary>
        /// API methods related to ProjectPriority
        /// </summary>
        IProjectPriorityClient ProjectPriority { get; }
        /// <summary>
        /// API methods related to ProjectStatus
        /// </summary>
        IProjectStatusClient ProjectStatus { get; }
        /// <summary>
        /// API methods related to ProjectTemplate
        /// </summary>
        IProjectTemplateClient ProjectTemplate { get; }
        /// <summary>
        /// API methods related to Resource
        /// </summary>
        IResourceClient Resource { get; }
        /// <summary>
        /// API methods related to ResourceSkill
        /// </summary>
        IResourceSkillClient ResourceSkill { get; }
        /// <summary>
        /// API methods related to ResourceTeam
        /// </summary>
        IResourceTeamClient ResourceTeam { get; }
        /// <summary>
        /// API methods related to Tag
        /// </summary>
        ITagClient Tag { get; }
        /// <summary>
        /// API methods related to Task
        /// </summary>
        ITaskClient Task { get; }
        /// <summary>
        /// API methods related to TaskAssignee
        /// </summary>
        ITaskAssigneeClient TaskAssignee { get; }
        /// <summary>
        /// API methods related to TaskField
        /// </summary>
        ITaskFieldClient TaskField { get; }
        /// <summary>
        /// API methods related to TaskStatus
        /// </summary>
        ITaskStatusClient TaskStatus { get; }
        /// <summary>
        /// API methods related to TaskTag
        /// </summary>
        ITaskTagClient TaskTag { get; }
    }
}