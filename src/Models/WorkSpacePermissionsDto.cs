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
    /// Information about a currently logged in user.
    ///
    /// You can call the RetrieveMe API to gather information about the current user.
    /// </summary>
    public class WorkSpacePermissionsDto : ApiModel
    {

        /// <summary>
        /// True if this user can Add people to the account
        /// </summary>
        public bool? InviteUser { get; set; }

        /// <summary>
        /// True if this user can Edit the accounts and billing page
        /// </summary>
        public bool? EditAccount { get; set; }

        /// <summary>
        /// True if this user can Edit role security settings
        /// </summary>
        public bool? EditRole { get; set; }

        /// <summary>
        /// True if this user can Access all account data
        /// </summary>
        public bool? EditAllProjects { get; set; }

        /// <summary>
        /// True if this user can See hourly rates, costs and budgets
        /// </summary>
        public bool? EditCost { get; set; }

        /// <summary>
        /// True if this user can Set team holidays
        /// </summary>
        public bool? EditHoliday { get; set; }

        /// <summary>
        /// True if this user can Create and edit tags, skills, and teams
        /// </summary>
        public bool? EditUserField { get; set; }

        /// <summary>
        /// True if this user can Edit team timesheets
        /// </summary>
        public bool? EditAllTimesheets { get; set; }

        /// <summary>
        /// True if this user can Approve timesheets
        /// </summary>
        public bool? ApproveTimesheet { get; set; }

        /// <summary>
        /// True if this user can Set up board workflow
        /// </summary>
        public bool? SetUpBoardWorkflow { get; set; }

        /// <summary>
        /// True if this user can Edit project and portfolio settings
        /// </summary>
        public bool? EditProjectField { get; set; }

        /// <summary>
        /// True if this user can Export projects
        /// </summary>
        public bool? ExportProject { get; set; }

        /// <summary>
        /// True if this user can Access the Manage Users page
        /// </summary>
        public bool? ViewUser { get; set; }

        /// <summary>
        /// True if this user can Manage Integrations
        /// </summary>
        public bool? EditIntegration { get; set; }

        /// <summary>
        /// True if this user Can create projects and groups
        /// </summary>
        public bool? CreateProject { get; set; }

        /// <summary>
        /// True if this user can Edit user profiles, roles and emails
        /// </summary>
        public bool? EditUser { get; set; }

        /// <summary>
        /// True if this user can View personal board
        /// </summary>
        public bool? ViewMyBoard { get; set; }
    }
}
