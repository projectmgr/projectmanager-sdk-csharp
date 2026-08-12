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
    /// Represents the values to apply to a single Resource as part of a bulk Resource update API call.
    ///
    /// This is a deliberately reduced version of Astro.Api.Dto.Resources.ResourceUpdateDto. Only fields that are
    /// sensible to update across many Resources at once are included. The following fields are intentionally
    /// omitted because they represent per-person identity or carry per-Resource side effects that should not
    /// be applied in bulk:
    ///
    /// - Email: cannot be changed once assigned and is unique per person.
    /// - RoleId: triggers invite-permission, account-owner and last-global-admin logic.
    /// - IsActive: triggers last-global-admin and license-count logic.
    /// - HourlyRate: triggers workspace-wide hourly rate recalculations.
    /// - ClearAvatar: removes the stored avatar image and deletes the asset from S3.
    /// </summary>
    public class ResourceBulkUpdateDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Resource to update.
        /// </summary>
        public Guid? ResourceId { get; set; }

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
        /// The list of ResourceTeams to which this Resource belongs.
        /// </summary>
        public Guid[] TeamIds { get; set; }

        /// <summary>
        /// The list of ResourceSkills possessed by this Resource.
        /// </summary>
        public Guid[] SkillIds { get; set; }

        /// <summary>
        /// The Approver Id associated with this Resource.
        ///
        /// Applies to personnel Resources only.
        /// </summary>
        public Guid? ApproverId { get; set; }

        /// <summary>
        /// Collaboration Color for this resource.
        ///
        /// eg. teal, cyan, lightblue, blurple, purple, pink, orange, gray
        /// </summary>
        public string ColorName { get; set; }

        /// <summary>
        /// Translation Language for this resource.
        ///
        /// e.g. en-US, en-GB, fr-FR, es-ES
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Public avatar image index (1-42). The avatar URL is generated as /assets/images/avatars/{index:000}.png.
        /// Only numeric public avatars are accepted; custom URLs are not supported.
        /// </summary>
        public int? PublicAvatarId { get; set; }

        /// <summary>
        /// Default planned effort in hours. When set, updates the resource; when omitted, existing value is unchanged.
        /// </summary>
        public decimal? DefaultPlannedHours { get; set; }

        /// <summary>
        /// Per-day working hours. When non-null, updates or creates the resource calendar; set only days to change—they merge over workspace defaults.
        /// </summary>
        public ResourceWorkingDaysHours WorkingDays { get; set; }
    }
}
