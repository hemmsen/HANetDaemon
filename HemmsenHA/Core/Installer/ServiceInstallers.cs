namespace daemonapp.Installers
{
    public static class ServiceInstallers
    {
        public static void AddInstallers(this IServiceCollection servicecollection)
        {
            var installers = Assembly.GetEntryAssembly().GetTypes().Where(type => type.GetCustomAttributes(typeof(InstallerAttribute), true).Length > 0);
            foreach (var installer in installers)
            {
                var asInterface = Activator.CreateInstance(installer) as IInstallerActions;
                asInterface.Install(servicecollection);
            }
        }
    }
}
