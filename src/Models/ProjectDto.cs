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
    /// </summary>
    public class ProjectDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Project.  This value is set by the system and cannot
        /// be set with a CreateProject or changed with an UpdateProject call.
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
        /// This code is assigned on creation and cannot be changed.
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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// The latest planned or actual finish date of tasks on the project.
        ///
        /// This field is calculated automatically and cannot be changed.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// The target planned completion date for this Project, or null if one has
        /// not been selected.  This value can be updated in the Project Settings
        /// page or the Portfolio Project page within the application.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string TargetDate { get; set; }

        /// <summary>
        /// A calculated field of the estimated date on which this Project is
        /// expected to start.
        ///
        /// This date is calculated based on the earliest estimated start date for
        /// a Task within this Project. This value is null if no Tasks have an
        /// estimated start date within this Project.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedStartDate { get; set; }

        /// <summary>
        /// A calculated field of the estimated date on which this Project is
        /// expected to finish.
        ///
        /// This date is calculated based on the latest planned finish date for a
        /// Task within this Project. This value is null if no Tasks have an
        /// estimated finish date within this Project.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedFinishDate { get; set; }

        /// <summary>
        /// A calculated field of the actual date on which this Project started.
        ///
        /// This date is calculated based on the earliest actual start date for a
        /// Task within this Project. This value is null if no Tasks have an actual
        /// start date within this Project.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualStartDate { get; set; }

        /// <summary>
        /// A calculated field of the actual date on which this Project finished.
        ///
        ///  This date is calculated based on the latest actual finish date for a
        ///  Task within this Project. This value is null if no Tasks have an
        ///  actual finish date within this Project.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualFinishDate { get; set; }

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
        ///
        /// This field is automatically determined by the system when this Project is modified
        /// and cannot be directly changed by the user.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The timestamp in UTC when the Project was created.
        ///
        /// This field is automatically determined by the system when this Project is created
        /// and cannot be changed by the user.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// True if this Project is a template that will be reused as a framework
        /// for future Projects.
        /// </summary>
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// True if this Project is marked as favorite for current user
        /// </summary>
        public bool? Favorite { get; set; }

        /// <summary>
        /// The TemplateId that this project was created from.
        /// Will be null if no template was selected at project creation.
        /// </summary>
        public Guid? CreationTemplateId { get; set; }

        /// <summary>
        /// The members of the project
        /// </summary>
        public ProjectMemberDto[] Members { get; set; }

        /// <summary>
        /// Project fields array with values
        /// </summary>
        public ProjectFieldValueDto[] FieldValues { get; set; }

        /// <summary>
        /// The list of files associated with this Project, if any.
        ///
        /// This field will be present when you fetch a single object.
        /// When you query for multiple objects, this field is not included in results by default.
        /// To expand this field, specify the name of this field in the `$expand` parameter.
        /// </summary>
        public ProjectFileDto[] Files { get; set; }

        /// <summary>
        /// The percentage of the project tasks completed
        /// </summary>
        public int? PercentComplete { get; set; }

        /// <summary>
        /// True if allow actual dates to update planned dates
        /// </summary>
        public bool? UpdatePlannedWithActual { get; set; }

        /// <summary>
        /// An optional external reference identifier for this Project.
        /// This value can be used to link the Project to records in external systems,
        /// such as ERP, CRM, or other integrations.
        /// </summary>
        public string ExternalReferenceId { get; set; }
    }
}
