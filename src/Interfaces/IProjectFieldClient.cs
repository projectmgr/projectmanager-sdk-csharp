/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to ProjectField
    /// </summary>
    public interface IProjectFieldClient
    {

        /// <summary>
        /// Retrieves all ProjectFields defined within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        Task<AstroResult<GetProjectFieldsResponseDto[]>> RetrieveProjectFields();

        /// <summary>
        /// Creates a new ProjectField within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="body">Information about the ProjectField to create</param>
        Task<AstroResult<CreateProjectFieldResponseDto>> CreateProjectField(CreateProjectFieldDto body);

        /// <summary>
        /// Deletes an existing ProjectField within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="fieldId">The unique identifier or short ID of this ProjectField</param>
        Task<AstroResult<string>> DeleteProjectField(string fieldId);

        /// <summary>
        /// Replaces the current value of a ProjectField for a specific Project within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that contains this ProjectField</param>
        /// <param name="fieldId">The unique identifier or short ID of this ProjectField</param>
        /// <param name="body">The new information for this ProjectField</param>
        Task<AstroResult<string>> UpdateProjectFieldValue(Guid projectId, string fieldId, UpdateProjectFieldValueDto body);

        /// <summary>
        /// Retrieves the current ProjectField value for a particular Project and ProjectField.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project of the value to retrieve</param>
        /// <param name="fieldId">The unique identifier or short ID of the ProjectField of the value to retrieve</param>
        Task<AstroResult<ProjectFieldValueDto>> RetrieveProjectFieldValue(Guid projectId, string fieldId);

        /// <summary>
        /// Retrieves all ProjectField values for a particular Project.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for which we want ProjectField values</param>
        Task<AstroResult<ProjectFieldValueDto[]>> RetrieveAllProjectFieldValues(Guid projectId);
    }
}
