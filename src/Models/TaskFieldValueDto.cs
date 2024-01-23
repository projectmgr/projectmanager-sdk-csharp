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
    /// A model that contains the value for a TaskField.
    /// </summary>
    public class TaskFieldValueDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskField.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique Short Id of this TaskField.
        /// </summary>
        public string Shortid { get; set; }

        /// <summary>
        /// The name of this Project Field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this TaskField.  Valid types are the following:
        /// * Text
        /// * Number
        /// * Date
        /// * Checkbox
        /// * Currency
        /// * Dropdown
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value currently set for this TaskFieldValue.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this TaskField was created.
        /// </summary>
        public DateTime? Createddate { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this TaskField was last modified.
        /// </summary>
        public DateTime? Modifieddate { get; set; }

        /// <summary>
        /// The Task to which this Value belongs.
        /// </summary>
        public TaskFieldValueTaskDto Task { get; set; }
    }
}
