﻿using Android.App;
using ZoomSDKProj.Interfaces;
using ZoomSDKProj.Platforms.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ZoomSDKProj;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialDesignIcons");
            });

		builder.Services.AddSingleton<IZoomService, ZoomService>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    
}
