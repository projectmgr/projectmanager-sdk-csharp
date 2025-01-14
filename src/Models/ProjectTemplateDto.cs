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
    /// A ProjectTemplate is a named document that contains default Project details.
    ///
    /// Project Templates are defined for the system and are shared among Projects.
    /// </summary>
    public class ProjectTemplateDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ProjectTemplate.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ProjectTemplate.
        ///
        /// Name can de used as a unique text reference for Project Templates.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The title of this ProjectTemplate.
        ///
        /// Title can be used as a description text for Project Templates.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The full text description of this ProjectTemplate.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The icon path for this ProjectTemplate.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The preview image path for this ProjectTemplate.
        /// </summary>
        public string PreviewImage { get; set; }

        /// <summary>
        /// The overall order of this ProjectTemplate.
        ///
        /// This order only applies to non-Custom ProjectTemplates
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// Is this ProjectTemplate a custom template.
        ///
        /// Custom templates are Templates that have been created from existing
        /// Project definitions.
        /// </summary>
        public bool? IsCustom { get; set; }

        /// <summary>
        /// The web default view of the template.
        /// </summary>
        public string DefaultView { get; set; }
    }
}
