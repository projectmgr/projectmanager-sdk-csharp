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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Country
    /// </summary>
    public class CountryClient : ICountryClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CountryClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// This method returns a list of all countries defined by [ISO3166](https://www.iso.org/iso-3166-country-codes.html).
        ///
        /// Each country includes its unique identifier (ISO3166-2 code) and name.
        /// </summary>
        public async Task<AstroResult<CountryDto[]>> ListCountries()
        {
            var url = $"/api/data/countries";
            return await _client.Request<CountryDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// This method returns a list of all states for the specified country as defined by [ISO3166](https://www.iso.org/iso-3166-country-codes.html).
        /// Note that many countries may have administrative regions although not all countries require administrative
        /// regions to be used when specifying an address.
        ///
        /// Each state includes its unique identifier, state code, and name.
        /// </summary>
        /// <param name="isoCode">The ISO-3166-2 code of the country</param>
        public async Task<AstroResult<StateDto[]>> GetStates(string isoCode)
        {
            var url = $"/api/data/countries/{isoCode}/states";
            return await _client.Request<StateDto[]>(HttpMethod.Get, url, null);
        }
    }
}
