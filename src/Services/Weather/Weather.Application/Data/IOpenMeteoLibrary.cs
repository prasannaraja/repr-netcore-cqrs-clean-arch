using OpenMeteo;

namespace Weather.Application.Data;

public interface IOpenMeteoLibrary
{
    public OpenMeteoClient GetClient();
}
