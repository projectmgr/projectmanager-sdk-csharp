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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks
    /// represent individual items of work that team members must complete.  The sum total of Tasks
    /// within a Project represents the work to be completed for that Project.
    ///
    /// Fields that cannot be selected during a CreateProject API call are not visible on this
    /// data model.
    /// </summary>
    public class ProjectCreateDto : ApiModel
    {

        /// <summary>
        /// The name of the Project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An optional description of the Project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the folder of this project, or null if not assigned.
        /// </summary>
        public Guid? FolderId { get; set; }

        /// <summary>
        /// If you wish to grant access to this Project to a selected list of people during creation,
        /// provide a list of ProjectMembers here.  If you do not specify anyone, this Project will
        /// be available to only yourself.
        /// </summary>
        public ProjectCreateAccessDto ProjectAccess { get; set; }

        /// <summary>
        /// The unique identifier of the customer for this project, or null if not customer specific
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The unique identifier of the manager of this project, or null if not assigned.
        /// </summary>
        public Guid? ManagerId { get; set; }

        /// <summary>
        /// The unique identifier of the ChargeCode for this Project, if one has been selected.
        /// </summary>
        public Guid? ChargeCodeId { get; set; }

        /// <summary>
        /// The ProjectStatus chosen for this Project, if one has been selected.
        /// </summary>
        public Guid? StatusId { get; set; }

        /// <summary>
        /// The ProjectPriority level of this Project, if one has been selected.
        /// </summary>
        public Guid? PriorityId { get; set; }

        /// <summary>
        /// The default hourly rate for work on this Project.  This rate will be used
        /// if an assignee working on this Project does not have an hourly rate configured
        /// in their profile.
        /// </summary>
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// The proposed budget for this Project.
        /// </summary>
        public decimal? Budget { get; set; }

        /// <summary>
        /// Contains an optional status update for Projects that can be used to summarize
        /// the status of multiple Projects at a glance.
        ///
        /// You can edit the StatusUpdate field on the Portfolio page of the application.
        /// </summary>
        public string StatusUpdate { get; set; }

        /// <summary>
        /// True if this Project is a template that will be reused as a framework
        /// for future Projects.
        ///
        /// You can save a Project as a template and reuse it in the future for creating
        /// additional Projects.  If this Project is a template, set this to `true` and this
        /// template will be available to choose from when creating a new Project within the
        /// application.
        /// </summary>
        public bool? Template { get; set; }

        /// <summary>
        /// When creating a Project, you can optionally specify a Template to use to construct
        /// the Project using a collection of pre-designed Tasks.
        ///
        /// Specifying a value in the TemplateId field will copy default settings for Tasks from
        /// your template Project into the newly created Project.
        ///
        /// This field does not support custom templates.  You must choose from a list of
        /// ProjectManager-supplied templates.
        /// </summary>
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// The target planned completion date for this Project, or null if one has
        /// not been selected.  This value can be updated in the Project Settings
        /// page or the Portfolio Project page within the application.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string TargetDate { get; set; }

        /// <summary>
        /// True if this Project is marked as favorite for current user
        /// </summary>
        public bool? Favorite { get; set; }

        /// <summary>
        /// Create default task status upfront
        /// </summary>
        public TaskStatusCreateDto[] TaskStatusCreate { get; set; }
    }
}
