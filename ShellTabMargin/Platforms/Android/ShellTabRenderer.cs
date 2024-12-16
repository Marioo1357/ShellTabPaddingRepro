using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using View = Android.Views.View;

namespace ShellTabMargin;

public class ShellTabRenderer : ShellRenderer
{
    protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
    {
        return base.CreateBottomNavViewAppearanceTracker(shellItem);
        //return new CustomShellBottomNavViewAppearanceTracker(this, shellItem);
    }
}

public class CustomShellBottomNavViewAppearanceTracker : ShellBottomNavViewAppearanceTracker
{
    private bool _hasEventsConnected;
    
    public CustomShellBottomNavViewAppearanceTracker(IShellContext shellContext, ShellItem shellItem) : base(shellContext, shellItem)
    {
    }

    public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
    {
        if (!_hasEventsConnected)
        {
            bottomView.LayoutChange += BottomViewOnLayoutChange;
            _hasEventsConnected = true;
        }
        
        base.SetAppearance(bottomView, appearance);
        
        bottomView.SetPadding(0, 0, 0, 100);
    }

    private void BottomViewOnLayoutChange(object? sender, View.LayoutChangeEventArgs e)
    {
        if (sender is BottomNavigationView navigationView)
        {
            navigationView.SetPadding(0, 0, 0, 100);
        }
    }
}