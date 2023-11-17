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

    public class IEdmModel : ApiModel
    {

        public IEdmSchemaElement[] SchemaElements { get; set; }

        public IEdmVocabularyAnnotation[] VocabularyAnnotations { get; set; }

        public IEdmModel[] ReferencedModels { get; set; }

        public string[] DeclaredNamespaces { get; set; }

        public IEdmDirectValueAnnotationsManager DirectValueAnnotationsManager { get; set; }

        public IEdmEntityContainer EntityContainer { get; set; }
    }
}
