﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace ShellTabMargin;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        SetTheme(Resource.Style.Maui_CustomStyle);
        base.OnCreate(savedInstanceState);
        
        Window.AddFlags(WindowManagerFlags.TranslucentNavigation);
        Window.AddFlags(WindowManagerFlags.TranslucentStatus);
    }
}