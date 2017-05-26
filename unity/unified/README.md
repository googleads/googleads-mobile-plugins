About
=====
Modifed by Andre Arsenault (andre@snowleopardgames.com) from the source
provided by Google at the GitHub link below. All changes submitted under the
Google Individual Contributor License Agreement v1.1.

Original code used as reference:
* https://github.com/googleads/googleads-mobile-plugins

License agreement for this submission:
* https://developers.google.com/open-source/cla/individual?csw=1


Features
--------

This is a unified Google Mobile Ads Unity Plugin for Android and iOS. It
provides a way to request Google Mobile ads from a Unity project. This plugin
was written and tested with Google Play Services 4.2.42 for Android, the Google
Mobile Ads SDK version 6.8.0 for iOS, and Unity 4.3.2f1. See the section at the
bottom of this document for download links.

The plugin contains a .unitypackage file for those that want to easily import
the plugin, as well as the source code for those that want to iterate on it.


Requirements
-------------

* Unity 4.3 (untested on previous versions)
* Google Play services library for Android, revision 13 or higher
* Google Mobile Ads SDK for iOS, version 6.8.0 or higher
* An ad unit ID

Directions for importing the plugin
------------------------------------

1. Open your project in the Unity editor.
2. On the top toolbar, select "Assets" -> "Import Package" -> "Custom Package".
3. Select the GoogleMobileAdsPlugin.unitypackage file.
4. Import all of the files for the plugins by selecting "Import". Make sure
   to check for any conflicts with files.
5. Drag the GoogleMobileAdsPlugin prefab from the Plugins/GoogleMobileAds/
   folder into your Unity scene.

Note: If you already have an AndroidManifest.xml in Plugins/Android/, you can
just add the necessary activities and permissions to your existing manifest as
explained in https://developers.google.com/mobile-ads-sdk/docs#play instead of
importing the manifest from the .unitypackage.

Additional dependencies:

1. Add the google-play-services_lib folder,
   located at <android-sdk>/extras/google/google_play_services/libproject,
   into the Plugins/Android folder of your project.
2. Add libGoogleAdMobAds.a and its associated headers (GAD*.h) into the
   Plugins/iOS folder of your project.

This plugin also comes with an example plugin usage script, which is already
attached to the GoogleMobileAdsPlugin component for convenience. Simply edit
Plugins/GoogleMobileAdsPlugin/GoogleMobileAdsDemoScript.cs and include your ad
unit ID and run your project to see plugin working.


Google Mobile Ads Unity Plugin API
==================================
The plugin provides the following methods:

1. CreateBannerView

   Takes in a publisherId string as well as a constant for the ad size. The
   last boolean parameter denotes whether the ad should be shown at the top
   or bottom of the screen.

   An example call placing the ad at the top of the screen is provided below:

   GoogleMobileAdsPlugin.CreateBannerView("INSERT_YOUR_AD_UNIT_ID_HERE",
                                          GoogleMobileAdsPlugin.AdSize.Banner,
                                          true);
2. RequestBannerAd

   Takes in a testing flag as well as an optional string representing a list
   of extras. If you don't have any extras, you can request a live ad with:

   GoogleMobileAdsPlugin.RequestBannerAd(false);

   An example call requesting a test ad with some extras is shown below:

   string extras = "{\"color_bg\":\"AAAAFF\", \"color_text\":\"FFFFFF\"}";
   GoogleMobileAdsPlugin.RequestBannerAd(true, extras);

   NOTE: Make sure to use correctly formed JSON when passing an extras string.
   If malformed JSON is passed, the extras will be ignored. The use of JSON
   extras is optional.

3. HideBannerView

   Called after a BannerView has been created, this method can hide the ad from
   showing on screen. An example call of this is shown below:

   GoogleMobileAdsPlugin.HideBannerView();

4. ShowBannerView

   Called after a BannerView has been created, this method can show any ad that
   has been hidden. An example call of this is shown below:

   GoogleMobileAdsPlugin.ShowBannerView();

This plugin also allows you the option to listen for ad events. The following
events are supported:

    public static event Action ReceivedAd;
    public static event Action<string> FailedToReceiveAd;
    public static event Action ShowingOverlay;
    public static event Action DismissingOverlay; // iOS only
    public static event Action DismissedOverlay;
    public static event Action LeavingApplication;

Registering for an event can be done using the += operater as is shown below:

    // Assume HandleReceivedAd is your function.
    GoogleMobileAdsPlugin.ReceivedAd += HandleDidReceiveAd;

Remember to un-register for events when you're cleaning up your GameObjects.
You can unregister using the -= operator as is shown below:

    // Assume HandleReceivedAd is your function.
    GoogleMobileAdsPlugin.ReceivedAd -= HandleDidReceiveAd;


Updating the plugin
-------------------

The plugin's .unitypackage only includes the compiled jar from the library
project. If you want to make changes to the library or see the source code, you
can find the project at
https://github.com/googleads/googleads-mobile-plugins/tree/master/unity.

The library project depends on Unity's classes.jar, which can be found at
/Applications/Unity/Unity.app/Contents/PlaybackEngines/AndroidDevelopmentPlayer/bin
on Mac and usually at
C:\Program Files\Unity\Editor\Data\PlaybackEngines\AndroidDevelopmentPlayer\bin
on Windows.


Download Links
--------------
* https://developers.google.com/mobile-ads-sdk/download?hl=en_US#downloadplay
* https://developers.google.com/mobile-ads-sdk/download?hl=en_US#downloadios


Additional Resources
--------------------
* https://developers.google.com/mobile-ads-sdk/docs
* https://groups.google.com/group/google-admob-ads-sdk
* https://plus.google.com/+GoogleAdsDevelopers

