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
    /// A Resource represents a person, material, or tool that is used within your Projects.
    /// When you attach a Resources to more than one Task, the software will schedule the usage
    /// of your Resource so that it is not allocated to more than one Task at the same time.
    /// The users in your Workspace are also considered Resources.  To invite a new User to your
    /// Workspace, create a new Resource for that user.
    /// </summary>
    public class ResourceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Resource.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The resource initials.
        /// </summary>
        public string Initials { get; set; }

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
        /// If this Resource is a person who can log on to ProjectManager.com, this value should be the email address of the
        /// person.  If this Resource is not a person, but you wish to receive email alerts for usage of this Resource, you
        /// can also add an email address here and notifications will be sent when this Resource is used.
        ///
        /// Otherwise this value should be `null`.
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
        /// A text field indicating the country in which this Resource is located.  This value
        /// is not constrained to the list of known ISO 3166 country names or codes.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Returns the name of the country
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Free-form text notes about this Resource.  You may use this field to store extra
        /// information about the Resource.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// When managing users, you can choose who will approve a person&#39;s Timesheets. This
        /// is a ResourceApprover.  You can specify this person within the Resource object.
        /// </summary>
        public ResourceApproverDto Approver { get; set; }

        /// <summary>
        /// The list of ResourceTeams to which this Resource belongs.
        /// </summary>
        public ResourceTeamDto[] Teams { get; set; }

        /// <summary>
        /// The list of ResourceSkills possessed by this Resource.
        /// </summary>
        public ResourceSkillDto[] Skills { get; set; }

        /// <summary>
        /// The last time when this Resource was online.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public DateTime? OnlineDateTime { get; set; }

        /// <summary>
        /// The Role privileges associated with this Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// True if this Resource is currently active and valid.  If this value is false,
        /// this Resource is considered to be deactivated and not available for further use.
        ///
        /// For personnel Resources, setting this value to False will make this user unable
        /// to access this Workspace.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// The date this resource was created
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Set to a unique identifier of the user who created this Resource.
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// The date this resource was last modified
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Set to a unique identifier of the user who last modified this Resource.
        /// </summary>
        public Guid? ModifiedBy { get; set; }

        /// <summary>
        /// Collaboration Color for this resource.
        ///
        /// eg. teal, cyan, lightblue, blurple, purple, pink, orange, gray
        /// </summary>
        public string ColorName { get; set; }

        /// <summary>
        /// Read only Hex code of the ColorName
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The resources avatar url, if any.
        /// </summary>
        public string AvatarUrl { get; set; }
    }
}
