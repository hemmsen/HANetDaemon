namespace HemmsenHA.Infrastructure.Configuration;
public static class ConfigurationBuilderExtensions
{
    public static IConfigurationBuilder AddHaRuntimeConfigration(
        this IConfigurationBuilder builder, string token, string baseUrl)
    {
        return builder.Add(new HaConfigurationSource(token, baseUrl));
    }
}