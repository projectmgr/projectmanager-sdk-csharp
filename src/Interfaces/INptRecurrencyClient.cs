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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to NptRecurrency
    /// </summary>
    public interface INptRecurrencyClient
    {

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the NPT Tasks</param>
        /// <param name="body">The weekly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateWeeklyRecurringNpts(Guid taskId, WeeklyRecurringSettingsDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the NPT Tasks</param>
        /// <param name="body">The monthly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateMonthlyRecurringNpts(Guid taskId, MonthlyRecurringSettingsDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the NPT Tasks</param>
        /// <param name="body">The daily recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateDailyRecurringNpts(Guid taskId, DailyRecurringSettingsDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the NPT Tasks</param>
        /// <param name="body">The yearly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateYearlyRecurringNpts(Guid taskId, YearlyRecurringSettingsDto body);

        /// <summary>
        /// Removes one or more instances of a Recurring Non-Project Task based on the `option` you specify: `this` means
        /// to remove a single instance, `all` means to remove all instances, or `future` means to remove all future
        /// instances of the Recurring Task.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Recurring Npt Tasks</param>
        /// <param name="option">The options for the deletion</param>
        Task<AstroResult<DeletedTasksDto>> DeleteRecurringNpts(Guid taskId, string option);

        /// <summary>
        /// Reviews potential updates to a Recurring Non-Project Task and report back on the list of changes that would
        /// occur if this Recurring Non-Project Task was updated with these settings.
        ///
        /// When making changes to a Recurring Npt, you may want to investigate the consequences of your changes first
        /// before finalizing the changes.  You can use the Validate Recurring Npts API to examine these changes.  When
        /// you are happy with the changes, call Update Recurring Npts to complete them.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the NPT Tasks</param>
        /// <param name="body">The new settings</param>
        Task<AstroResult<RecurringTaskValidationResultDto>> ValidateRecurringNpts(Guid taskId, RecurringTaskSettingsDto body);

        /// <summary>
        /// Updates the settings for a Recurring Non-Project Task and re-generates occurrences of the Recurring Non-Project
        /// Task from the new rules.
        ///
        /// When making changes to a Recurring Npt, you may want to investigate the consequences of your changes first
        /// before finalizing the changes.  You can use the Validate Recurring Npts API to examine these changes.  When
        /// you are happy with the changes, call Update Recurring Npts to complete them.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the NPT Tasks</param>
        /// <param name="body">The new settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> UpdateRecurringNpts(Guid taskId, RecurringTaskSettingsDto body);
    }
}
