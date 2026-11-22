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
    /// API methods related to Country
    /// </summary>
    public interface ICountryClient
    {

        /// <summary>
        /// This method returns a list of all countries defined by [ISO3166](https://www.iso.org/iso-3166-country-codes.html).
        ///
        /// Each country includes its unique identifier (ISO3166-2 code) and name.
        /// </summary>
        Task<AstroResult<CountryDto[]>> ListCountries();

        /// <summary>
        /// This method returns a list of all states for the specified country as defined by [ISO3166](https://www.iso.org/iso-3166-country-codes.html).
        /// Note that many countries may have administrative regions although not all countries require administrative
        /// regions to be used when specifying an address.
        ///
        /// Each state includes its unique identifier, state code, and name.
        /// </summary>
        /// <param name="isoCode">The ISO-3166-2 code of the country</param>
        Task<AstroResult<StateDto[]>> GetStates(string isoCode);
    }
}
