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
    /// A holiday returned when fetching by id or after create or update.
    /// </summary>
    public class HolidayDetailDto : ApiModel
    {

        /// <summary>
        /// The public identifier of the holiday.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Reason or label for the holiday.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Holiday scope: global, people, or country.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Start of the holiday date span (metadata).
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DateFrom { get; set; }

        /// <summary>
        /// End of the holiday date span (metadata).
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DateTo { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country identifiers when Type is country; otherwise empty.
        /// </summary>
        public string[] CountryId { get; set; }

        /// <summary>
        /// Affected resources. For country and global holidays, all active non-guest resources in scope; for people holidays, the assigned resource(s).
        /// </summary>
        public HolidayResourceDto[] Resources { get; set; }
    }
}
