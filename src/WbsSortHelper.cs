using System;
using System.Collections.Generic;
using ProjectManager.SDK.Models;

namespace ProjectManager.SDK 
{
    /// <summary>
    /// Use this class to sort TaskDto objects according to their Work Breakdown Structure
    /// </summary>
    public class WbsSortHelper : IComparer<TaskDto>
    {
        int IComparer<TaskDto>.Compare(TaskDto t1, TaskDto t2)
        {
            // Sanity checks for null
            if (t1 == null || t2 == null)
            {
                if (t1 == null && t2 != null)
                {
                    return 1;
                }

                if (t1 != null && t2 == null)
                {
                    return -1;
                }
                
                return 0;
            }

            try
            {
                var t1OutlineNumberArray = t1.Wbs.Trim().Split('.');
                var t2OutlineNumberArray = t2.Wbs.Trim().Split('.');

                for (int i = 0; i < t1OutlineNumberArray.Length; i++)
                {
                    if (i >= t2OutlineNumberArray.Length)
                    {
                        return 1; // In this situation = 2.1 > 2 return 1
                    }
                    if (int.TryParse(t1OutlineNumberArray[i], out int t1Number) && int.TryParse(t2OutlineNumberArray[i], out int t2Number))
                    {
                        if (t1Number == t2Number)
                        {
                            continue; // Continue the compare on the next item, e.g 1.1 and 1.2.3 are the same in the first comparison.
                        }
                        if (t1Number > t2Number)
                        {
                            return 1; // Return 1 if t1 > t2 on the same position like '3'.1 > '1'.1
                        }
                        if (t1Number < t2Number)
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return -1;
                    }
                }

                // t1 length > t2 length e.g. 1.1.5 > 1.1, retrun 1. note it passes the compare above so the position can compare will be the same.
                if (t1OutlineNumberArray.Length > t2OutlineNumberArray.Length)
                {
                    return 1;
                }
                // e.g. 2.2 < 2.2.15, return -1;
                if (t1OutlineNumberArray.Length < t2OutlineNumberArray.Length)
                {
                    return -1;
                }

                // If we cannot get answer from above, use index.
                if (t1.Id.HasValue && t2.Id.HasValue)
                {
                    return t1.Id.Value.CompareTo(t2.Id.Value);
                }
            }
            catch
            {
                if (t1.Id.HasValue && t2.Id.HasValue)
                {
                    return t1.Id.Value.CompareTo(t2.Id.Value);
                }
            }
            return 0;
        }
    }
}