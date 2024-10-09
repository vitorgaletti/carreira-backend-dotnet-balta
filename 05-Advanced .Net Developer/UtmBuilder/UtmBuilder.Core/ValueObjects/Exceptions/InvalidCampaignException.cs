namespace UtmBuilder.Core.ValueObjects.Exceptions;

public class InvalidCampaignException(string message = InvalidCampaignException.DefaultErrorMessage) : Exception(message)
{
    private const string DefaultErrorMessage = "Invalid UTM parameters";

    public static void ThrowIfNull(
        string? item,
        string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(item))
            throw new InvalidCampaignException(message);
    }
}