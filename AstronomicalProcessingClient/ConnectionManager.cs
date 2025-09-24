using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using ServiceContracts;

namespace AstronomicalProcessingClient;

/// <summary>
/// Manages connections to a WCF service endpoint and provides safe execution of service calls.
/// </summary>
/// <typeparam name="T">The service contract interface type.</typeparam>
internal class ConnectionManager<T>(string endpointAddress) where T : class
{
    private readonly ChannelFactory<T> _factory = new(
        new NetNamedPipeBinding(),
        new EndpointAddress(endpointAddress)
    );

    private T? _channel;

    /// <summary>
    /// Attempts to establish a connection to the service endpoint.
    /// </summary>
    /// <returns>
    /// <c>true</c> if the connection is established; otherwise, <c>false</c>.
    /// </returns>
    [MemberNotNullWhen(true, nameof(_channel))]
    private bool Connect()
    {
        _channel ??= _factory.CreateChannel();
        return _channel is not null;
    }

    /// <summary>
    /// Executes a function on the service channel, handling connection and communication exceptions.
    /// </summary>
    /// <typeparam name="TResult">The result type returned by the function.</typeparam>
    /// <param name="function">The function to execute on the service channel.</param>
    /// <param name="value">The result value if successful.</param>
    /// <param name="exception">The exception if an error occurs.</param>
    /// <returns>
    /// <c>true</c> if the function executes successfully; otherwise, <c>false</c>.
    /// </returns>
    public bool TryRun<TResult>(
        Func<T, TResult> function,
        [MaybeNullWhen(false)] out TResult? value,
        [NotNullWhen(false)] out Exception? exception
    )
    {
        try
        {
            if (!Connect())
            {
                throw new InvalidOperationException("Unable to connect to service.");
            }

            value = function(_channel);
            exception = null;
            return true;
        }
        catch (CommunicationException ex)
        {
            _channel = null;
            value = default;
            exception = ex;
            return false;
        }
    }
}
