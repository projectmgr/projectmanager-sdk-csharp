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

    public class IEdmSchemaElement : ApiModel
    {

        /// <summary>
        ///
        ///
        /// For a list of values, see `EdmSchemaElementKindValues`.
        /// </summary>
        public string SchemaElementKind { get; set; }

        public string Namespace { get; set; }

        public string Name { get; set; }
    }
}
