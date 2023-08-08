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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks
    /// represent individual items of work that team members must complete.  The sum total of Tasks
    /// within a Project represents the work to be completed for that Project.
    /// </summary>
    public class ProjectDto
    {

        /// <summary>
        /// The unique identifier of the Project.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the Project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An optional description of the Project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A shortened name that will be used when reporting on Projects.  This short
        /// name can be edited in the Project Settings page within the application
        /// and can be any text you wish.
        /// </summary>
        public string ShortCode { get; set; }

        /// <summary>
        /// A short identifier that uniquely identifies this Project within your Workspace
        /// using a single letter followed by a number.  This code can be used for APIs
        /// that accept Project unique identifiers.
        ///
        /// You can observe the short ID within the application by observing the URL of
        /// the page you visit when you click on this project.  The page&#39;s URL will appear
        /// in the form `https://pm.app.projectmanager.com/project/board/D16` - in this
        /// example, the `ShortId` is `D16`.
        ///
        /// This code is automatically assigned for you and cannot be changed.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// If this Project is grouped within a ProjectFolder, this contains the ProjectFolder information.
        /// </summary>
        public ProjectFolderDto Folder { get; set; }

        /// <summary>
        /// The ProjectStatus chosen for this Project.
        /// </summary>
        public ProjectStatusDto Status { get; set; }

        /// <summary>
        /// The earliest planned or actual start date of tasks on the project.
        ///
        /// This field is calculated automatically and cannot be changed.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The latest planned or actual finish date of tasks on the project.
        ///
        /// This field is calculated automatically and cannot be changed.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The target planned completion date for this Project, or null if one has
        /// not been selected.  This value can be updated in the Project Settings
        /// page or the Portfolio Project page within the application.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string TargetDate { get; set; }

        /// <summary>
        /// The ProjectPriority level of this Project, if defined.
        /// </summary>
        public ProjectPriorityDto Priority { get; set; }

        /// <summary>
        /// The ChargeCode of this Project, if defined.
        /// </summary>
        public ProjectChargeCodeDto ChargeCode { get; set; }

        /// <summary>
        /// Information about the manager of this project, if one has been assigned.
        /// </summary>
        public ProjectManagerDto Manager { get; set; }

        /// <summary>
        /// Information about the manager of this project, if one has been specified.
        /// </summary>
        public ProjectCustomerDto Customer { get; set; }

        /// <summary>
        /// The proposed budget for this Project.
        /// </summary>
        public decimal? Budget { get; set; }

        /// <summary>
        /// The default hourly rate for work on this Project.  This rate will be used
        /// if an assignee working on this Project does not have an hourly rate configured
        /// in their profile.
        /// </summary>
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// Contains an optional status update for Projects that can be used to summarize
        /// the status of multiple Projects at a glance.
        ///
        /// You can edit the StatusUpdate field on the Portfolio page of the application.
        /// </summary>
        public string StatusUpdate { get; set; }

        /// <summary>
        /// The timestamp in UTC when the Project was most recently modified.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The timestamp in UTC when the Project was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// True if this Project is a template that will be reused as a framework
        /// for future Projects.
        /// </summary>
        public bool? IsTemplate { get; set; }
    }
}
