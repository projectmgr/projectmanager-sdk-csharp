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
    /// A Tag is a named categorization you can use to distinguish objects from each other.
    /// Tags each have a unique identifier, a name, and a color.
    /// </summary>
    public class TagDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Tag.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this Tag.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The color that will be used to represent this Tag visually.  This color
        /// is automatically chosen by the application when a user creates a Tag.
        ///
        /// You can choose specify any color that can be represented using HTML RGB
        /// syntax such as `#0088FF`, in the format `RRGGBB`.  You may not use names
        /// for colors.
        /// </summary>
        public string Color { get; set; }
    }
}
