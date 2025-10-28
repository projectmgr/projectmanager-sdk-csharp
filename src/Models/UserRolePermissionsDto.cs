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
    /// The permissions available to the role
    /// </summary>
    public class UserRolePermissionsDto : ApiModel
    {

        /// <summary>
        /// Add people to the account
        /// </summary>
        public UserRolePermissionDto InvitePeople { get; set; }

        /// <summary>
        /// Edit accounts and billing page
        /// </summary>
        public UserRolePermissionDto EditAccountPage { get; set; }

        /// <summary>
        /// Edit role security settings
        /// </summary>
        public UserRolePermissionDto EditSecurityPage { get; set; }

        /// <summary>
        /// See hourly rates, costs and budgets
        /// </summary>
        public UserRolePermissionDto SeeHourlyRatesCostsBudgets { get; set; }

        /// <summary>
        /// Set team holidays
        /// </summary>
        public UserRolePermissionDto SetTeamHolidays { get; set; }

        /// <summary>
        /// Create and edit tags, skills and teams
        /// </summary>
        public UserRolePermissionDto EditTagsSkillsTeams { get; set; }

        /// <summary>
        /// Edit team timesheets
        /// </summary>
        public UserRolePermissionDto EditTeamTimesheets { get; set; }

        /// <summary>
        /// Approve timesheets
        /// </summary>
        public UserRolePermissionDto ApproveTimesheets { get; set; }

        /// <summary>
        /// Manage project portfolio
        /// </summary>
        public UserRolePermissionDto EditImportantProjectInfo { get; set; }

        /// <summary>
        /// Ability to export projects
        /// </summary>
        public UserRolePermissionDto SeeExportProject { get; set; }

        /// <summary>
        /// Access the Manage Users page
        /// </summary>
        public UserRolePermissionDto SeeManageUsers { get; set; }

        /// <summary>
        /// Manage integrations
        /// </summary>
        public UserRolePermissionDto ManageIntegrations { get; set; }

        /// <summary>
        /// Create Projects
        /// </summary>
        public UserRolePermissionDto CreateProjectAndProjectGroups { get; set; }

        /// <summary>
        /// Edit user profiles, roles and emails
        /// </summary>
        public UserRolePermissionDto EditUsers { get; set; }

        /// <summary>
        /// View personal board
        /// </summary>
        public UserRolePermissionDto ViewPersonalBoard { get; set; }

        /// <summary>
        /// Access all projects and timesheets
        /// </summary>
        public UserRolePermissionDto EditAllProjects { get; set; }

        /// <summary>
        /// Edit own email address
        /// </summary>
        public UserRolePermissionDto ChangeOwnEmail { get; set; }
    }
}
