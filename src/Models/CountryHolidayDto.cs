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
    /// Country holiday entry
    /// </summary>
    public class CountryHolidayDto : ApiModel
    {

        /// <summary>
        /// Holiday id
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Date of holiday
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The Country Id the holiday is associated to
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// The Country Name the holiday is associated to
        /// </summary>
        public string CountryName { get; set; }
    }
}
