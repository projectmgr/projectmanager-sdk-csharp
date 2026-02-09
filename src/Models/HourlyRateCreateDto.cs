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
    /// The payload to create a hourly rate
    /// </summary>
    public class HourlyRateCreateDto : ApiModel
    {

        /// <summary>
        /// The ResourceId that the rate is for
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// The SkillId that the rate is for
        /// </summary>
        public Guid? SkillId { get; set; }

        /// <summary>
        /// The ProjectId that the rate is for
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The hourly rate value, the rate will be created for all periods with this value.
        ///
        /// Either hourlyRate or copyFromRateId has to be specified but not both.
        /// </summary>
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// The rateId to copy from. The values for each rate period will match the values for the source rate.
        ///
        /// Either hourlyRate or copyFromRateId has to be specified but not both.
        /// </summary>
        public Guid? CopyFromRateId { get; set; }
    }
}
