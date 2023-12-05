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
        public string ShortId { get; set; }

        /// <summary>
        /// The value currently set for this TaskFieldValue.
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

        /// <summary>
        /// The Task to which this Value belongs.
        /// </summary>
        public TaskFieldValueTaskDto Task { get; set; }
    }
}
