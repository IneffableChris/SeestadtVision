# SeestadtVision 🚀
Seestadt AR Project WS2021

## by Christoph Götz

The project focuses on offering the people living in the Urban Lakecity (Seestadt) in Vienna the possibillity to design the city themselves in a way and to express how they would like to redesign certain aspects.

SeestadtVision is an Augmented-Reality (AR) application which doesn't just offer people the chance to express their imagination that way, but also features modes where all kinds of useful information can be found and where a Now/Future-view of buildings which currently get built is accessible. 
All of the features of the application are easily adaptable, adjustable and expandable.

## Unity 
the code used here runs on Unity, last tested on version 2020.3.23f1.  For more information about the firmware see [https://unity.com/de/download]

## Plugins, Tools & Assets
to deploy and work on the software, following tools are needed: 
- ARKit (to deploy for iOs)
- ARCore (to deploy for Android)
- more specific tools, depending on the version of your phone - those might be installed automatically after switching to "Build for xyz" in the Build Settings. 
- the AR+GPS Plugin by Daniel Fortes, which you can read more about here: [https://docs.unity-ar-gps-location.com/#main-features]

## Build settings in Unity:
You can read more about the different settings and options when building the application to your phone here:
- for Android: [https://docs.unity3d.com/2020.1/Documentation/Manual/android-BuildProcess.html]
- for iOs: [https://docs.unity3d.com/2020.1/Documentation/Manual/BuildSettingsiOS.html]
- general information: [https://docs.unity3d.com/2020.1/Documentation/Manual/PlatformSpecific.html]

### external projects and tools which are useful and could be combined with the project
- EasyAR 
- IATK: Immersive Analytics Toolkit
- Vuforia
- Mapbox
- Kudan SDK
- Wikitude AR
- PhotonEngine


### Features - 3 different modes
- AR-Objectplacement-Mode 

While using this mode, users can choose of a set of objects and place them, by using AR-technology, in the real world. 
Therefore, users could then screenshot their result and express how they would like a certain spot in the city to look like. 

- AR-Informationmode

By using the AR-informationmode, information can be placed on a map in Unity, which then gets displayed on the app when opening this mode. 
One possible use-case would be to show users information about the different street-names, about opening hours of certain buildings, and so on.

- AR Now/Future-Mode 

In this mode people can see how the city currently looks like and how it will look like in the future, after the buildings are fully built. 
Sadly, this mode needs correct images and data regarding those futuristic views, which is why the technology and development of the mode is done, while the images aren't set, due to lack of information.
The images themselves can be switched easily though, which is why users don't need to be concerned at all.


## Installation 🔥
If you only want to use the application itself, it is enough to install the project .apk to your phone. 
You are ready to start the application aftwards immediately. 

Besides that, for developers, it is neccesarry to install the development environment "Unity", as explained in the beginning. 

## Support
For support, email e51825978@student.tuwien.ac.at
