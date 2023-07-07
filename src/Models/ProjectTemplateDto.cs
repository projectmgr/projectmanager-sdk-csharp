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
    /// A ProjectTemplate is a named document that contains default Project details.
    ///
    /// Project Templates are defined for the system and are shared among Projects.
    /// </summary>
    public class ProjectTemplateDto
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
    }
}
