using System;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.Preference;
using WoWonder.Activities.AddPost.Service;
using WoWonder.Helpers.Model;
using WoWonder.Helpers.Utils;

namespace WoWonder.Activities.SettingsPreferences
{
    public static class MainSettings
    {
        public static ISharedPreferences SharedData, InAppReview, UgcPrivacy;
        public static readonly string LightMode = "light";
        public static readonly string DarkMode = "dark";
        public static readonly string DefaultMode = "default";

        public static readonly string PrefKeyInAppReview = "In_App_Review";

        public static void Init()
        {
            try
            {
                SharedData = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
                InAppReview = Application.Context.GetSharedPreferences("In_App_Review", FileCreationMode.Private);
                UgcPrivacy = Application.Context.GetSharedPreferences("Ugc_Privacy", FileCreationMode.Private);

                string getValue = SharedData.GetString("Night_Mode_key", string.Empty);
                ApplyTheme(getValue);

                PostService.ActionPost = Application.Context.PackageName + ".action.ACTION_POST";
                PostService.ActionStory = Application.Context.PackageName + ".action.ACTION_STORY";

                UserDetails.SoundControl = SharedData.GetBoolean("checkBox_PlaySound_key", true);
                UserDetails.NotificationPopup = SharedData.GetBoolean("notifications_key", true);
                UserDetails.OnlineUsers = SharedData.GetBoolean("onlineUser_key", true);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public static void ApplyTheme(string themePref)
        {
            try
            {
                if (themePref == LightMode)
                {
                    AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
                    AppSettings.SetTabDarkTheme = TabTheme.Light;
                }
                else if (themePref == DarkMode)
                {
                    AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightYes;
                    AppSettings.SetTabDarkTheme = TabTheme.Dark;
                }
                else if (themePref == DefaultMode)
                {
                    AppCompatDelegate.DefaultNightMode = (int)Build.VERSION.SdkInt >= 29 ? AppCompatDelegate.ModeNightFollowSystem : AppCompatDelegate.ModeNightAutoBattery;

                    var currentNightMode = Application.Context.Resources?.Configuration?.UiMode & UiMode.NightMask;

                    if (currentNightMode == UiMode.NightYes) // Night mode is active, we're using dark theme
                    {
                        AppSettings.SetTabDarkTheme = TabTheme.Dark;
                        AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightYes;
                    }
                    else  // Night mode is not active, we're using the light theme
                    {
                        AppSettings.SetTabDarkTheme = TabTheme.Light;
                        AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
                    }
                }
                else
                {
                    switch (AppSettings.SetTabDarkTheme)
                    {
                        case TabTheme.Dark:
                            AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightYes;
                            AppSettings.SetTabDarkTheme = TabTheme.Dark;
                            break;
                        case TabTheme.Light:
                            AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
                            AppSettings.SetTabDarkTheme = TabTheme.Light;
                            break;
                        default:
                            {
                                var currentNightMode = Application.Context.Resources?.Configuration?.UiMode & UiMode.NightMask;

                                if (currentNightMode == UiMode.NightYes) // Night mode is active, we're using dark theme
                                {
                                    AppSettings.SetTabDarkTheme = TabTheme.Dark;
                                    AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightYes;
                                }
                                else  // Night mode is not active, we're using the light theme
                                {
                                    AppSettings.SetTabDarkTheme = TabTheme.Light;
                                    AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
                                }
                                  
                                break;
                            }
                    }
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }
    }
}