Understanding SoundBanks
==

> To effectively manage the audio and motion components of a game, Wwise puts all audio 
> and motion data for your game into bank.  

所有的声音和motion都放在bank中  

> A bank is basically a file that contains your game's audio and motion data, media, or both. 
> These banks are loaded into a game's platform memory at a particular point in the game. 
> By loading only what is necessary, you can optimize the amount of memory that is being used for audio 
> and motion by each platform. Banks are the product of all your work and contain the final audio 
> and/or motion content that becomes part of your game.  

Bank 是游戏最终使用的形式, 要在需要的时候加载节省内存.  

> In Wwise, there are two types of banks:
> - Initialization bank  
>   a special bank that contains all the general information about a project, 
>   including information on the bus hierarchy, and information on States, Switches, RTPCs, and Environment effects. 
>   The initialization bank is automatically created when Wwise generates the SoundBanks. 
>   The initialization bank is usually loaded once at beginning of your game so that all the general project information is easily 
>   accessible during the game play. 
>   By default, the initialization bank is named "Init.bnk".  
> - SoundBank  
>   a file that contains a combination of Event data, sound and motion structure data, 
>   and/or media files. Unlike the initialization bank, SoundBanks are generally loaded and unloaded at different points in 
>   the game to better utilize platform memory usage. 
>   Event and project structure metadata can also be added to different SoundBanks than the 
>   media allowing you to load media files only when they are absolutely required. 
>   Because all platforms are different, Wwise allows you to easily tailor the SoundBanks for each platform 
>   and generate the SoundBanks for all platforms simultaneously. 
>   Wwise also provides you with tools for troubleshooting any issues related to your SoundBanks 
>   to make suer that you are respecting the limitations of the different platforms.  

_?? Initialization bank 是自动加载的吗_  

> To help you work more efficiently, a SoundBank layout is available in Wwise. 
> This layout contains all the views you will need to create, manage, and generate the SoundBanks for you project, 
> including the SoundBank Manager, SoundBank Editor, and Event Viewer. 

### File Packager  
> The SoundBanks generated for a Wwise project as well as any streamed media files 
> can be grouped into one or more packages using File Packager stand-alone utility. 
> A file package is a self-contained unit that abstracts a file system, 
> which means you can avoid some of limitations of a platform's file system, 
> including the limit on the length of filenames as well as the actual number of files. 
> File Packages can also help you better manager language version as well as downloadable content 
> that is made available post release.  

File Package 是一个虚拟文件系统, 用来打包任何 media files. 可以方便下载, 帮助处理平台限制和差异.  


[Understanding SoundBanks](https://www.audiokinetic.com/library/edge/?source=WwiseFundamentalApproach&id=understanding_soundbanks_understanding_soundbanks)  