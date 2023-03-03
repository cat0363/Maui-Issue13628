using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Maui_Issue13628;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    // MEMO:
    // Code to fix issue #13628
    /*
    public override bool DispatchTouchEvent(MotionEvent e) 
    {
        if (e.Action == MotionEventActions.Down ||
            e.Action == MotionEventActions.Move ||
            e.Action == MotionEventActions.Up) 
        {
            // Search MapView Control
            var maps = (Window.DecorView as ViewGroup).GetChildrenOfType<MapView>();

            foreach (var map in maps) 
            {
                // Initialize MapView screen position 
                int[] pos = new int[2];
                // Set MapView screen position 
                map.GetLocationOnScreen(pos);
                // Create hit test rectangle 
                Rect hitRect = new Rect(pos[0], pos[1], map.Width, map.Height);
                // Judge hit test
                bool isHitTest = hitRect.Contains(e.GetX(), e.GetY());
                // Hit test result is OK
                if (isHitTest) 
                {
                    // Touch event intercept
                    map.Parent.RequestDisallowInterceptTouchEvent(true);
                }
            }
        }

        return base.DispatchTouchEvent(e);
    }
    */
}
