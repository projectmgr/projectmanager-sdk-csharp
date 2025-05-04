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
    /// Indicate which days of the week are considered working days for this project.
    /// This value can be set when the project is created but may not be updated afterwards.
    /// </summary>
    public class ProjectWorkingDaysDto : ApiModel
    {

        /// <summary>
        /// Set this value to true if Monday is considered a working day for this project.
        /// </summary>
        public bool? Monday { get; set; }

        /// <summary>
        /// Set this value to true if Tuesday is considered a working day for this project.
        /// </summary>
        public bool? Tuesday { get; set; }

        /// <summary>
        /// Set this value to true if Wednesday is considered a working day for this project.
        /// </summary>
        public bool? Wednesday { get; set; }

        /// <summary>
        /// Set this value to true if Thursday is considered a working day for this project.
        /// </summary>
        public bool? Thursday { get; set; }

        /// <summary>
        /// Set this value to true if Friday is considered a working day for this project.
        /// </summary>
        public bool? Friday { get; set; }

        /// <summary>
        /// Set this value to true if Saturday is considered a working day for this project.
        /// </summary>
        public bool? Saturday { get; set; }

        /// <summary>
        /// Set this value to true if Sunday is considered a working day for this project.
        /// </summary>
        public bool? Sunday { get; set; }
    }
}
