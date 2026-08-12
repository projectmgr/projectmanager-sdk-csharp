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
    /// Request body for creating a holiday. One occurrence per calendar day from DateFrom through DateTo (inclusive).
    /// Omit both lists for a global holiday; set ResourceIds for people scope; set CountryId for country scope (ISO 3166-1 alpha-2).
    /// </summary>
    public class HolidayCreateDto : ApiModel
    {

        /// <summary>
        /// Reason or label for the holiday (for example, public holiday name or company shutdown).
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// First calendar day of the holiday (inclusive).
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DateFrom { get; set; }

        /// <summary>
        /// Last calendar day of the holiday (inclusive). Must be on or after DateFrom.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DateTo { get; set; }

        /// <summary>
        /// Resources this holiday applies to (people scope). Mutually exclusive with CountryId.
        /// </summary>
        public Guid[] ResourceIds { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country identifiers this holiday applies to (country scope). Mutually exclusive with ResourceIds.
        /// </summary>
        public string[] CountryId { get; set; }
    }
}
