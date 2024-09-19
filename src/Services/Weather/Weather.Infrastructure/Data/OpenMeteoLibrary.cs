using OpenMeteo;
using Weather.Application.Data;

namespace Weather.Infrastructure.Data;

public class OpenMeteoLibrary : IOpenMeteoLibrary
{
    private static OpenMeteoClient _client;
    private static readonly object _lock = new object();

    public OpenMeteoClient GetClient()
    {
        if (_client == null)
        {
            lock (_lock)
            {
                if (_client == null)
                {
                    _client = new OpenMeteoClient();
                }
            }
        }
        return _client;
    }
}
