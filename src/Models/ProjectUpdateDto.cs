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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks
    /// represent individual items of work that team members must complete.  The sum total of Tasks
    /// within a Project represents the work to be completed for that Project.
    ///
    /// Fields that cannot be modified during an UpdateProject call are not visible on this data
    /// model.
    /// </summary>
    public class ProjectUpdateDto : ApiModel
    {

        /// <summary>
        /// The name of the Project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The short name of the Project.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// An optional description of the Project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The target planned completion date for this Project, or null if one has
        /// not been selected.  This value can be updated in the Project Settings
        /// page or the Portfolio Project page within the application.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string TargetDate { get; set; }

        /// <summary>
        /// To move this Project into a ProjectFolder, set this to the unique identifier of the
        /// ProjectFolder.
        /// </summary>
        public Guid? FolderId { get; set; }

        /// <summary>
        /// To assign this Project to a ProjectCustomer, set this to the unique identifier of the
        /// ProjectCustomer.
        ///
        /// If set to an empty guid the Project will be unassigned from the current ProjectCustomer.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// To assign this Project to a ProjectManager, set this to the unique identifier of the
        /// ProjectManager.
        /// </summary>
        public Guid? ManagerId { get; set; }

        /// <summary>
        /// To set the ChargeCode for this Project, set this to the unique identifier of the
        /// ChargeCode to use for this Project.
        /// </summary>
        public Guid? ChargeCodeId { get; set; }

        /// <summary>
        /// To change the ProjectStatus of this Project, set this to the unique identifier of the
        /// ProjectStatus.
        /// </summary>
        public Guid? StatusId { get; set; }

        /// <summary>
        /// To change the ProjectPriority of this Project, set this to the unique identifier of the
        /// ProjectPriority.
        /// </summary>
        public Guid? PriorityId { get; set; }

        /// <summary>
        /// To change the hourly rate of this Project, set this to the new amount.
        /// </summary>
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// To change the budget of this Project, set this to the new amount.
        /// </summary>
        public decimal? Budget { get; set; }

        /// <summary>
        /// To update the Project&#39;s status text, set this to the new status text.
        /// </summary>
        public string StatusUpdate { get; set; }

        /// <summary>
        /// Mark this project as favorite for the logged in user.
        /// </summary>
        public bool? Favorite { get; set; }

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
        /// True if allow actual dates to update planned dates
        /// </summary>
        public bool? UpdatePlannedWithActual { get; set; }

        /// <summary>
        /// To update the project notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// An optional external reference identifier for this Project.
        /// This value can be used to link the Project to records in external systems,
        /// such as ERP, CRM, or other integrations.
        /// </summary>
        public string ExternalReferenceId { get; set; }
    }
}
