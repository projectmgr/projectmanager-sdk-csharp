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
    /// Export settings for Projects export
    /// </summary>
    public class ProjectExportSettingsDto : ApiModel
    {

        /// <summary>
        /// Format to export to, currently csv and excel are supported
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Include closed projects to export
        /// </summary>
        public bool? IncludeClosed { get; set; }

        /// <summary>
        /// The list of column names to export
        /// </summary>
        public object Columns { get; set; }

        /// <summary>
        /// Export filters
        /// </summary>
        public ProjectExportFilterDto Filters { get; set; }

        /// <summary>
        /// Order of columns to export
        /// </summary>
        public string[] Order { get; set; }
    }
}
