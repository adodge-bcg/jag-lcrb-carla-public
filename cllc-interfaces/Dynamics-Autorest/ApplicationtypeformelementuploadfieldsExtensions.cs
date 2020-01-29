// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Applicationtypeformelementuploadfields.
    /// </summary>
    public static partial class ApplicationtypeformelementuploadfieldsExtensions
    {
            /// <summary>
            /// Get adoxio_applicationtype_formelementuploadfields from
            /// adoxio_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtypeid'>
            /// key: adoxio_applicationtypeid of adoxio_applicationtype
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioFormelementuploadfieldCollection Get(this IApplicationtypeformelementuploadfields operations, string adoxioApplicationtypeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioApplicationtypeid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_applicationtype_formelementuploadfields from
            /// adoxio_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtypeid'>
            /// key: adoxio_applicationtypeid of adoxio_applicationtype
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioFormelementuploadfieldCollection> GetAsync(this IApplicationtypeformelementuploadfields operations, string adoxioApplicationtypeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioApplicationtypeid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_applicationtype_formelementuploadfields from
            /// adoxio_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtypeid'>
            /// key: adoxio_applicationtypeid of adoxio_applicationtype
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioFormelementuploadfieldCollection> GetWithHttpMessages(this IApplicationtypeformelementuploadfields operations, string adoxioApplicationtypeid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioApplicationtypeid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_applicationtype_formelementuploadfields from
            /// adoxio_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtypeid'>
            /// key: adoxio_applicationtypeid of adoxio_applicationtype
            /// </param>
            /// <param name='adoxioFormelementuploadfieldid'>
            /// key: adoxio_formelementuploadfieldid of adoxio_formelementuploadfield
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioFormelementuploadfield FormelementuploadfieldsByKey(this IApplicationtypeformelementuploadfields operations, string adoxioApplicationtypeid, string adoxioFormelementuploadfieldid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.FormelementuploadfieldsByKeyAsync(adoxioApplicationtypeid, adoxioFormelementuploadfieldid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_applicationtype_formelementuploadfields from
            /// adoxio_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtypeid'>
            /// key: adoxio_applicationtypeid of adoxio_applicationtype
            /// </param>
            /// <param name='adoxioFormelementuploadfieldid'>
            /// key: adoxio_formelementuploadfieldid of adoxio_formelementuploadfield
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioFormelementuploadfield> FormelementuploadfieldsByKeyAsync(this IApplicationtypeformelementuploadfields operations, string adoxioApplicationtypeid, string adoxioFormelementuploadfieldid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FormelementuploadfieldsByKeyWithHttpMessagesAsync(adoxioApplicationtypeid, adoxioFormelementuploadfieldid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_applicationtype_formelementuploadfields from
            /// adoxio_applicationtypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtypeid'>
            /// key: adoxio_applicationtypeid of adoxio_applicationtype
            /// </param>
            /// <param name='adoxioFormelementuploadfieldid'>
            /// key: adoxio_formelementuploadfieldid of adoxio_formelementuploadfield
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioFormelementuploadfield> FormelementuploadfieldsByKeyWithHttpMessages(this IApplicationtypeformelementuploadfields operations, string adoxioApplicationtypeid, string adoxioFormelementuploadfieldid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.FormelementuploadfieldsByKeyWithHttpMessagesAsync(adoxioApplicationtypeid, adoxioFormelementuploadfieldid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}