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
    /// Recurring settings for a task
    /// </summary>
    public class RecurringTaskSettingsDto : ApiModel
    {

        /// <summary>
        /// Type
        /// </summary>
        public int? Type { get; set; }

        /// <summary>
        /// RepeatEvery
        /// </summary>
        public int? RepeatEvery { get; set; }

        /// <summary>
        /// RepeatOn
        /// </summary>
        public int[] RepeatOn { get; set; }

        /// <summary>
        /// RepeatOn2Level
        /// </summary>
        public int? RepeatOn2Level { get; set; }

        /// <summary>
        /// EndsOn
        /// </summary>
        public DateTime? EndsOn { get; set; }

        /// <summary>
        /// EndsAfter
        /// </summary>
        public int? EndsAfter { get; set; }
    }
}
