// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Clients.ApiProxy
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProjEvaNico.
    /// </summary>
    public static partial class ProjEvaNicoExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiValuesGet(this IProjEvaNico operations)
            {
                return operations.ApiValuesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiValuesGetAsync(this IProjEvaNico operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesPost(this IProjEvaNico operations, string value = default(string))
            {
                operations.ApiValuesPostAsync(value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesPostAsync(this IProjEvaNico operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiValuesPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiValuesByIdGet(this IProjEvaNico operations, int id)
            {
                return operations.ApiValuesByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiValuesByIdGetAsync(this IProjEvaNico operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesByIdPut(this IProjEvaNico operations, int id, string value = default(string))
            {
                operations.ApiValuesByIdPutAsync(id, value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdPutAsync(this IProjEvaNico operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiValuesByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiValuesByIdDelete(this IProjEvaNico operations, int id)
            {
                operations.ApiValuesByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdDeleteAsync(this IProjEvaNico operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
