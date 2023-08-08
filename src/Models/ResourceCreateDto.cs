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
    /// A Resource represents a person, material, or tool that is used within your Projects.
    /// When you attach a Resources to more than one Task, the software will schedule the usage
    /// of your Resource so that it is not allocated to more than one Task at the same time.
    /// The users in your Workspace are also considered Resources.  To invite a new User to your
    /// Workspace, create a new Resource for that user.
    /// </summary>
    public class ResourceCreateDto
    {

        /// <summary>
        /// The first name of the person Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address of this Resource.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The basic hourly rate for this Resource.
        /// </summary>
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// The phone number associated with this Resource.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The city where this Resource is located.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state or region where this Resource is located.  This value is not constrained
        /// to a list of known states or regions.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// A text field indicating the country in which this Resource is located.
        /// This value must be one of the following: US, NZ, AU.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Free-form text notes about this Resource.  You may use this field to store extra
        /// information about the Resource.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// The Role Id associated with this Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public Guid? RoleId { get; set; }

        /// <summary>
        /// The list of ResourceTeams to which this Resource belongs.
        /// </summary>
        public Guid[] TeamIds { get; set; }

        /// <summary>
        /// The list of ResourceSkills possessed by this Resource.
        /// </summary>
        public Guid[] SkillIds { get; set; }
    }
}
