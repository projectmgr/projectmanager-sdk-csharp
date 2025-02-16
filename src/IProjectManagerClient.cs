/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 *             
 * @copyright  ProjectManager.com, Inc.
 * @version    126.0.205
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
        /// API methods related to ApiKey
        /// </summary>
        IApiKeyClient ApiKey { get; }
        /// <summary>
        /// API methods related to Changeset
        /// </summary>
        IChangesetClient Changeset { get; }
        /// <summary>
        /// API methods related to Dashboard
        /// </summary>
        IDashboardClient Dashboard { get; }
        /// <summary>
        /// API methods related to Discussion
        /// </summary>
        IDiscussionClient Discussion { get; }
        /// <summary>
        /// API methods related to File
        /// </summary>
        IFileClient File { get; }
        /// <summary>
        /// API methods related to Holiday
        /// </summary>
        IHolidayClient Holiday { get; }
        /// <summary>
        /// API methods related to HomeFile
        /// </summary>
        IHomeFileClient HomeFile { get; }
        /// <summary>
        /// API methods related to Integration
        /// </summary>
        IIntegrationClient Integration { get; }
        /// <summary>
        /// API methods related to IntegrationCategory
        /// </summary>
        IIntegrationCategoryClient IntegrationCategory { get; }
        /// <summary>
        /// API methods related to IntegrationProvider
        /// </summary>
        IIntegrationProviderClient IntegrationProvider { get; }
        /// <summary>
        /// API methods related to License
        /// </summary>
        ILicenseClient License { get; }
        /// <summary>
        /// API methods related to Me
        /// </summary>
        IMeClient Me { get; }
        /// <summary>
        /// API methods related to Notification
        /// </summary>
        INotificationClient Notification { get; }
        /// <summary>
        /// API methods related to NptFiles
        /// </summary>
        INptFilesClient NptFiles { get; }
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
        /// API methods related to ProjectFile
        /// </summary>
        IProjectFileClient ProjectFile { get; }
        /// <summary>
        /// API methods related to ProjectFolder
        /// </summary>
        IProjectFolderClient ProjectFolder { get; }
        /// <summary>
        /// API methods related to ProjectMembers
        /// </summary>
        IProjectMembersClient ProjectMembers { get; }
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
        /// API methods related to ProjectVersion
        /// </summary>
        IProjectVersionClient ProjectVersion { get; }
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
        /// API methods related to Risk
        /// </summary>
        IRiskClient Risk { get; }
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
        /// API methods related to TaskFile
        /// </summary>
        ITaskFileClient TaskFile { get; }
        /// <summary>
        /// API methods related to TaskMetadata
        /// </summary>
        ITaskMetadataClient TaskMetadata { get; }
        /// <summary>
        /// API methods related to TaskStatus
        /// </summary>
        ITaskStatusClient TaskStatus { get; }
        /// <summary>
        /// API methods related to TaskTag
        /// </summary>
        ITaskTagClient TaskTag { get; }
        /// <summary>
        /// API methods related to TaskTodo
        /// </summary>
        ITaskTodoClient TaskTodo { get; }
        /// <summary>
        /// API methods related to Teams
        /// </summary>
        ITeamsClient Teams { get; }
        /// <summary>
        /// API methods related to Timesheet
        /// </summary>
        ITimesheetClient Timesheet { get; }
        /// <summary>
        /// API methods related to UserRole
        /// </summary>
        IUserRoleClient UserRole { get; }
        /// <summary>
        /// API methods related to WorkSpace
        /// </summary>
        IWorkSpaceClient WorkSpace { get; }
    }
}