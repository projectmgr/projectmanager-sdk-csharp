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
    /// Information about a Category of ProjectTemplates.
    /// </summary>
    public class ProjectTemplateCategoryDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ProjectTemplate Category.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// A friendly name for this ProjectTemplate Category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The overall order of this ProjectTemplate Category
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// A list of templates in this category
        /// </summary>
        public ProjectTemplateDto[] Templates { get; set; }
    }
}
