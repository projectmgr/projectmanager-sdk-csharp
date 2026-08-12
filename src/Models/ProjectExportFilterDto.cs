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
    /// Filter settings for Projects export
    /// </summary>
    public class ProjectExportFilterDto : ApiModel
    {

        /// <summary>
        /// Specify the project group filter for the export
        /// </summary>
        public Guid? GroupId { get; set; }

        /// <summary>
        /// Specify whether to include only favorite projects in the export
        /// </summary>
        public bool? FavoritesOnly { get; set; }

        /// <summary>
        /// Specify the status filter for the export
        /// </summary>
        public string[] Status { get; set; }

        /// <summary>
        /// Specify the project manager filter for the export
        /// </summary>
        public string[] Manager { get; set; }

        /// <summary>
        /// Specify the project customer filter for the export
        /// </summary>
        public string[] Customer { get; set; }

        /// <summary>
        /// Specify the project charge code filter for the export
        /// </summary>
        public string[] ChargeCode { get; set; }

        /// <summary>
        /// Specify the priority filter for the export
        /// </summary>
        public string[] Priority { get; set; }
    }
}
