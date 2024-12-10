using Microsoft.Extensions.Logging;

namespace RedNote
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("MYRIADPRO-REGULAR.OTF", "Myriad Pro Regular");
                    fonts.AddFont("MyriadPro-Light.otf", "Myriad Pro Light");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
        
    }
}
