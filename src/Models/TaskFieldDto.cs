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
    public class TaskFieldDto : ApiModel
    {

        /// <summary>
        /// The unique Short Id of this TaskField.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The value currently set for this TaskField for this Task.
        /// </summary>
        public string Value { get; set; }
    }
}
