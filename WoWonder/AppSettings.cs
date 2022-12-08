//##############################################
//Cᴏᴘʏʀɪɢʜᴛ 2020 DᴏᴜɢʜᴏᴜᴢLɪɢʜᴛ Codecanyon Item 19703216
//Elin Doughouz >> https://www.facebook.com/Elindoughouz
//====================================================

//For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 

using System.Collections.Generic;
using WoWonder.Activities.NativePost.Extra;
using WoWonder.Helpers.Model;
using static WoWonder.Activities.NativePost.Extra.WRecyclerView;

namespace WoWonder
{
    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">demo.wowonder.com</string>
        /// </summary>
        public static readonly string TripleDesAppServiceProvider = "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";

        //Main Settings >>>>>
        //*********************************************************
        public static string Version = "5.2";
        public static readonly string ApplicationName = "WoWonder Timeline";
        public static readonly string DatabaseName = "WowonderSocial";

        // Friend system = 0 , follow system = 1
        public static readonly int ConnectivitySystem = 1;

        /// <summary>
        /// When you select the application mode type.. some settings will be changed and some features will be deactivated..
        /// ==============================================
        /// AppMode.Default : (Facebook) Mode
        /// AppMode.LinkedIn : (Jobs) Mode
        /// 
        /// AppMode.Instagram >> #Next Version 
        /// ==============================================
        /// </summary>
        public static readonly AppMode AppMode = AppMode.Default; //#New

        //Main Colors >>
        //*********************************************************
        public static readonly string MainColor = "#a52729";
         
        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar

        //Set Language User on site from phone 
        public static readonly bool SetLangUser = true; 

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "64974c58-9993-40ed-b782-0814edc401ea";

        // WalkThrough Settings >>
        //*********************************************************
        public static readonly bool ShowWalkTroutPage = true;

        //Main Messenger settings
        //*********************************************************
        public static readonly bool MessengerIntegration = true;
        public static readonly bool ShowDialogAskOpenMessenger = false; 
        public static readonly string MessengerPackageName = "com.wowondermessenger.app"; //APK name on Google Play

        //AdMob >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly ShowAds ShowAds = ShowAds.AllUsers;

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 5;
        public static readonly int ShowAdRewardedVideoCount = 5;
        public static readonly int ShowAdNativeCount = 2;
        public static readonly int ShowAdAppOpenCount = 3;

        public static readonly bool ShowAdMobBanner = true;
        public static readonly bool ShowAdMobInterstitial = true;
        public static readonly bool ShowAdMobRewardVideo = true;
        public static readonly bool ShowAdMobNative = true;
        public static readonly bool ShowAdMobNativePost = true;
        public static readonly bool ShowAdMobAppOpen = true;
        public static readonly bool ShowAdMobRewardedInterstitial = true;

        public static readonly string AdInterstitialKey = "ca-app-pub-5135691635931982/3584502890";
        public static readonly string AdRewardVideoKey = "ca-app-pub-5135691635931982/2518408206";
        public static readonly string AdAdMobNativeKey = "ca-app-pub-5135691635931982/2280543246";
        public static readonly string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/2813560515";
        public static readonly string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/7842669101";

        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly bool ShowFbBannerAds = false;
        public static readonly bool ShowFbInterstitialAds = false;
        public static readonly bool ShowFbRewardVideoAds = false;
        public static readonly bool ShowFbNativeAds = false;

        //YOUR_PLACEMENT_ID
        public static readonly string AdsFbBannerKey = "250485588986218_554026418632132";
        public static readonly string AdsFbInterstitialKey = "250485588986218_554026125298828";
        public static readonly string AdsFbRewardVideoKey = "250485588986218_554072818627492";
        public static readonly string AdsFbNativeKey = "250485588986218_554706301897477";

        //Colony Ads >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowColonyBannerAds = true;
        public static readonly bool ShowColonyInterstitialAds = true;
        public static readonly bool ShowColonyRewardAds = true;

        public static readonly string AdsColonyAppId = "appff22269a7a0a4be8aa";
        public static readonly string AdsColonyBannerId = "vz85ed7ae2d631414fbd";
        public static readonly string AdsColonyInterstitialId = "vz39712462b8634df4a8";
        public static readonly string AdsColonyRewardedId = "vz32ceec7a84aa4d719a";
        //********************************************************* 

        public static readonly bool EnableRegisterSystem = true;

        /// <summary>
        /// true => Only over 18 years old
        /// false => all 
        /// </summary> 
        public static readonly bool ShowBirthdayInRegister = true; //#New
        public static readonly bool IsUserYearsOld = true;
        public static readonly bool AddAllInfoPorfileAfterRegister = true;

        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;

        //Code Time Zone (true => Get from Internet , false => Get From #CodeTimeZone )
        //*********************************************************
        public static readonly bool AutoCodeTimeZone = true;
        public static readonly string CodeTimeZone = "UTC";

        //Error Report Mode
        //*********************************************************
        public static readonly bool SetApisReportMode = false;

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file 
        //Facebook >> ../values/analytic.xml .. line 10-11 
        //Google >> ../values/analytic.xml .. line 15 
        //*********************************************************
        public static readonly bool EnableSmartLockForPasswords = false;

        public static readonly bool ShowFacebookLogin = true;
        public static readonly bool ShowGoogleLogin = true;

        public static readonly string ClientId = "430795656343-679a7fus3pfr1ani0nr0gosotgcvq2s8.apps.googleusercontent.com";

        //########################### 

        //Main Slider settings
        //*********************************************************
        public static readonly PostButtonSystem PostButton = PostButtonSystem.ReactionDefault;
        public static readonly ToastTheme ToastTheme = ToastTheme.Custom;

        public static readonly BottomNavigationSystem NavigationBottom = BottomNavigationSystem.Default;

        /// <summary>
        /// None : To disable Reels video on the app 
        /// </summary>
        public static readonly ReelsPosition ReelsPosition = ReelsPosition.Tab;
        public static readonly bool ShowYouTubeReels = false; //#New
        public static readonly bool ShowUsernameReels = false; //#New


        public static readonly bool ShowBottomAddOnTab = true;

        public static readonly long RefreshAppAPiSeconds = 30000; //#New

        public static readonly bool ShowAlbum = true;
        public static bool ShowArticles = true;
        public static bool ShowPokes = true;
        public static bool ShowCommunitiesGroups = true;
        public static bool ShowCommunitiesPages = true;
        public static bool ShowMarket = true;
        public static readonly bool ShowPopularPosts = true;
        /// <summary>
        /// if selected false will remove boost post and get list Boosted Posts
        /// </summary>
        public static readonly bool ShowBoostedPosts = true;
        public static readonly bool ShowBoostedPages = true;
        public static bool ShowMovies = true;
        public static readonly bool ShowNearBy = true;
        public static bool ShowStory = true;
        public static readonly bool ShowSavedPost = true;
        public static readonly bool ShowUserContacts = true;
        public static bool ShowJobs = true;
        public static bool ShowCommonThings = true;
        public static bool ShowFundings = true;
        public static readonly bool ShowMyPhoto = true;
        public static readonly bool ShowMyVideo = true;
        public static bool ShowGames = true;
        public static bool ShowMemories = true;
        public static readonly bool ShowOffers = true;
        public static readonly bool ShowNearbyShops = true;

        public static readonly bool ShowSuggestedPage = true;
        public static readonly bool ShowSuggestedGroup = true;
        public static readonly bool ShowSuggestedUser = true;

        public static readonly bool ShowCommentImage = true; //#New
        public static readonly bool ShowCommentRecordVoice = true; //#New

        //count times after entering the Suggestion is displayed
        public static readonly int ShowSuggestedPageCount = 90;
        public static readonly int ShowSuggestedGroupCount = 70;
        public static readonly int ShowSuggestedUserCount = 50;

        //allow download or not when share
        public static readonly bool AllowDownloadMedia = true;

        public static readonly bool ShowAdvertise = true;

        /// <summary>
        /// https://rapidapi.com/api-sports/api/covid-193
        /// you can get api key and host from here https://prnt.sc/wngxfc 
        /// </summary>
        public static readonly bool ShowInfoCoronaVirus = true;
        public static readonly string KeyCoronaVirus = "164300ef98msh0911b69bed3814bp131c76jsneaca9364e61f";
        public static readonly string HostCoronaVirus = "covid-193.p.rapidapi.com";

        public static readonly bool ShowLive = true;
        public static readonly string AppIdAgoraLive = "619ee4ec26334d2dae20e52d1abbb32e";

        //Events settings
        //*********************************************************  
        public static bool ShowEvents = true;
        public static readonly bool ShowEventGoing = true;
        public static readonly bool ShowEventInvited = true;
        public static readonly bool ShowEventInterested = true;
        public static readonly bool ShowEventPast = true;

        // Story >>
        //*********************************************************
        //Set a story duration >> Sec
        public static readonly long StoryImageDuration = 7;
        public static readonly long StoryVideoDuration = 30;

        /// <summary>
        /// If it is false, it will appear only for the specified time in the value of the StoryVideoDuration
        /// </summary>
        public static readonly bool ShowFullVideo = false;

        public static readonly bool EnableStorySeenList = true;
        public static readonly bool EnableReplyStory = true;

        /// <summary>
        /// https://dashboard.stipop.io/
        /// you can get api key from here https://prnt.sc/26ofmq9
        /// </summary>
        public static readonly string StickersApikey = "0a441b19287cad752e87f6072bb914c0";

        //*********************************************************

        /// <summary>
        ///  Currency
        /// CurrencyStatic = true : get currency from app not api 
        /// CurrencyStatic = false : get currency from api (default)
        /// </summary>
        public static readonly bool CurrencyStatic = false;
        public static readonly string CurrencyIconStatic = "$";
        public static readonly string CurrencyCodeStatic = "USD";
        public static readonly string CurrencyFundingPriceStatic = "$";

        //Profile settings
        //*********************************************************
        public static readonly bool ShowGift = true;
        public static readonly bool ShowWallet = true;
        public static readonly bool ShowGoPro = true;
        public static readonly bool ShowAddToFamily = true;

        public static readonly bool ShowUserGroup = false;
        public static readonly bool ShowUserPage = false;
        public static readonly bool ShowUserImage = true;
        public static readonly bool ShowUserSocialLinks = false;

        public static readonly CoverImageStyle CoverImageStyle = CoverImageStyle.CenterCrop;

        /// <summary>
        /// The default value comes from the site .. in case it is not available, it is taken from these values
        /// </summary>
        public static readonly string WeeklyPrice = "3";
        public static readonly string MonthlyPrice = "8";
        public static readonly string YearlyPrice = "89";
        public static readonly string LifetimePrice = "259";

        //Native Post settings
        //********************************************************* 
        public static readonly bool ShowTextWithSpace = true;

        public static readonly bool ShowTextShareButton = false;
        public static readonly bool ShowShareButton = true;

        public static readonly int AvatarPostSize = 60;
        public static readonly int ImagePostSize = 200;
        public static readonly string PostApiLimitOnScroll = "22";

        public static readonly string PostApiLimitOnBackground = "12";

        public static readonly bool AutoPlayVideo = true;

        public static readonly bool EmbedDeepSoundPostType = true;
        public static readonly VideoPostTypeSystem EmbedFacebookVideoPostType = VideoPostTypeSystem.EmbedVideo;
        public static readonly VideoPostTypeSystem EmbedVimeoVideoPostType = VideoPostTypeSystem.EmbedVideo;
        public static readonly VideoPostTypeSystem EmbedPlayTubeVideoPostType = VideoPostTypeSystem.Link;
        public static readonly VideoPostTypeSystem EmbedTikTokVideoPostType = VideoPostTypeSystem.Link;
        public static readonly VideoPostTypeSystem EmbedTwitterPostType = VideoPostTypeSystem.Link;
        public static readonly bool ShowSearchForPosts = true;
        public static readonly bool EmbedLivePostType = true;

        //new posts users have to scroll back to top
        public static readonly bool ShowNewPostOnNewsFeed = true;
        public static readonly bool ShowAddPostOnNewsFeed = false;
        public static readonly bool ShowCountSharePost = true;

        public static readonly WRecyclerView.VolumeState DefaultVolumeVideoPost = WRecyclerView.VolumeState.On;
        
        /// <summary>
        /// Post Privacy
        /// ShowPostPrivacyForAllUser = true : all posts user have icon Privacy 
        /// ShowPostPrivacyForAllUser = false : just my posts have icon Privacy (default)
        /// </summary>
        public static readonly bool ShowPostPrivacyForAllUser = false;

        public static readonly bool ShowFullScreenVideoPost = true;

        public static readonly bool EnableVideoCompress = true;
        public static readonly bool EnableFitchOgLink = true;

        /// <summary>
        /// On : if the length of the text is more than 50 characters will be text is bigger
        /// Off : all text same size
        /// </summary>
        public static readonly VolumeState TextSizeDescriptionPost = VolumeState.On;//#New

        //Trending page
        //*********************************************************   
        public static readonly bool ShowTrendingPage = true;

        public static readonly bool ShowProUsersMembers = true;
        public static readonly bool ShowPromotedPages = true;
        public static readonly bool ShowTrendingHashTags = true;
        public static readonly bool ShowLastActivities = true;
        public static readonly bool ShowShortcuts = true;
        public static readonly bool ShowFriendsBirthday = true;
        public static readonly bool ShowAnnouncement = true;

        /// <summary>
        /// https://www.weatherapi.com
        /// </summary>
        public static readonly WeatherType WeatherType = WeatherType.Celsius;
        public static readonly bool ShowWeather = true;
        public static readonly string KeyWeatherApi = "a413d0bf31a44369a16140106221804";

        /// <summary>
        /// https://openexchangerates.org
        /// #Currency >> Your currency
        /// #Currencies >> you can use just 3 from those : USD,EUR,DKK,GBP,SEK,NOK,CAD,JPY,TRY,EGP,SAR,JOD,KWD,IQD,BHD,DZD,LYD,AED,QAR,LBP,OMR,AFN,ALL,ARS,AMD,AUD,BYN,BRL,BGN,CLP,CNY,MYR,MAD,ILS,TND,YER
        /// </summary>
        public static readonly bool ShowExchangeCurrency = false;
        public static readonly string KeyCurrencyApi = "644761ef2ba94ea5aa84767109d6cf7b";
        public static readonly string ExCurrency = "USD";
        public static readonly string ExCurrencies = "EUR,GBP,TRY";
        public static readonly List<string> ExCurrenciesIcons = new List<string>() { "€", "£", "₺" };

        //********************************************************* 

        /// <summary>
        /// you can edit video using FFMPEG 
        /// </summary>
        public static readonly bool EnableVideoEditor = true;


        public static readonly bool ShowUserPoint = true;

        //Add Post
        public static readonly AddPostSystem AddPostSystem = AddPostSystem.AllUsers;
        public static readonly GalleryIntentSystem GalleryIntentSystem = GalleryIntentSystem.Default; //#New

        public static readonly bool ShowGalleryImage = true;
        public static readonly bool ShowGalleryVideo = true;
        public static readonly bool ShowMention = true;
        public static readonly bool ShowLocation = true;
        public static readonly bool ShowFeelingActivity = true;
        public static readonly bool ShowFeeling = true;
        public static readonly bool ShowListening = true;
        public static readonly bool ShowPlaying = true;
        public static readonly bool ShowWatching = true;
        public static readonly bool ShowTraveling = true;
        public static readonly bool ShowGif = true;
        public static readonly bool ShowFile = true;
        public static readonly bool ShowMusic = true;
        public static readonly bool ShowPolls = true;
        public static readonly bool ShowColor = true;
        public static readonly bool ShowVoiceRecord = true;

        public static readonly bool ShowAnonymousPrivacyPost = true;

        //Advertising 
        public static readonly bool ShowAdvertisingPost = true;

        //Settings Page >> General Account
        public static readonly bool ShowSettingsGeneralAccount = true;
        public static readonly bool ShowSettingsAccount = true;
        public static readonly bool ShowSettingsSocialLinks = true;
        public static readonly bool ShowSettingsPassword = true;
        public static readonly bool ShowSettingsBlockedUsers = true;
        public static readonly bool ShowSettingsDeleteAccount = true;
        public static readonly bool ShowSettingsTwoFactor = true;
        public static readonly bool ShowSettingsManageSessions = true;
        public static readonly bool ShowSettingsVerification = true;

        public static readonly bool ShowSettingsSocialLinksFacebook = true;
        public static readonly bool ShowSettingsSocialLinksTwitter = true;
        public static readonly bool ShowSettingsSocialLinksGoogle = true;
        public static readonly bool ShowSettingsSocialLinksVkontakte = true;
        public static readonly bool ShowSettingsSocialLinksLinkedin = true;
        public static readonly bool ShowSettingsSocialLinksInstagram = true;
        public static readonly bool ShowSettingsSocialLinksYouTube = true;

        //Settings Page >> Privacy
        public static readonly bool ShowSettingsPrivacy = true;
        public static readonly bool ShowSettingsNotification = true;

        //Settings Page >> Tell a Friends (Earnings)
        public static readonly bool ShowSettingsInviteFriends = true;

        public static readonly bool ShowSettingsShare = true;
        public static readonly bool ShowSettingsMyAffiliates = true;
        public static readonly bool ShowWithdrawals = true;

        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// Just replace it with this 5 lines of code
        /// <uses-permission android:name="android.permission.READ_CONTACTS" />
        /// <uses-permission android:name="android.permission.READ_PHONE_NUMBERS" />
        /// </summary>
        public static readonly bool InvitationSystem = true;

        //Settings Page >> Help && Support
        public static readonly bool ShowSettingsHelpSupport = true;

        public static readonly bool ShowSettingsHelp = true;
        public static readonly bool ShowSettingsReportProblem = true;
        public static readonly bool ShowSettingsAbout = true;
        public static readonly bool ShowSettingsPrivacyPolicy = true;
        public static readonly bool ShowSettingsTermsOfUse = true;

        public static readonly bool ShowSettingsRateApp = true;
        public static readonly int ShowRateAppCount = 5;

        public static readonly bool ShowSettingsUpdateManagerApp = false;

        public static readonly bool ShowSettingsInvitationLinks = true;
        public static readonly bool ShowSettingsMyInformation = true;

        public static readonly bool ShowSuggestedUsersOnRegister = true;

        //Set Theme Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Light;
        public static readonly MoreTheme MoreTheme = MoreTheme.Card;

        //Bypass Web Errors  
        //*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;

        //*********************************************************
        public static readonly bool RenderPriorityFastPostLoad = false;

        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static readonly bool ShowInAppBilling = false;

        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc & https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static readonly bool ShowPaypal = true;
        public static readonly string MerchantAccountId = "test";

        public static readonly string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4c******";
        public static readonly string ProductionTokenizationKey = "production_t2wns2y2_dfy45******";

        public static readonly bool ShowBankTransfer = true;
        public static readonly bool ShowCreditCard = true;

        //********************************************************* 
        public static readonly bool ShowCashFree = true;

        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static readonly string CashFreeCurrency = "INR";

        //********************************************************* 

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 24 
        /// </summary>
        public static readonly bool ShowRazorPay = true;

        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static readonly string RazorPayCurrency = "USD";

        public static readonly bool ShowPayStack = true;
        public static readonly bool ShowPaySera = false;  //#Next Version   

        //********************************************************* 
        
    }
}