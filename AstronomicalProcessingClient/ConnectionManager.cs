using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using ServiceContracts;

namespace AstronomicalProcessingClient;

internal class ConnectionManager<T>(string endpointAddress) where T : class
{
    private readonly ChannelFactory<T> _factory = new(
        new NetNamedPipeBinding(),
        new EndpointAddress(endpointAddress)
    );

    private T? _channel;

    [MemberNotNullWhen(true, nameof(_channel))]
    private bool Connect()
    {
        _channel ??= _factory.CreateChannel();
        return _channel is not null;
    }

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
