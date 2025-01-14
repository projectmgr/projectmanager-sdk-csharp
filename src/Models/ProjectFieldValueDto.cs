/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A model that contains the value for a ProjectField.
    /// </summary>
    public class ProjectFieldValueDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Project Field.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique Short Id of this Project Field.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The name of this Project Field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this Project Field.  Valid types are the following:
        /// * Text
        /// * Number
        /// * Date
        /// * Checkbox
        /// * Currency
        /// * Dropdown
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value currently set for this Project Field Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this TaskField was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this TaskField was last modified.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
