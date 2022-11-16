Game Objects
== 

> Game objects are the central concept in Wwise because every Event triggered in the sound engine 
> is associated with a game object. 
> A game object generally represents a particular object or element in your game that can emit a sound, 
> including characters, weapons, ambient objects, such as torches, and so on. 
> In some cases, however, you omy want to assign game objects to different parts of an in-game element. 
> For example, you can assign a different game object to different parts of giant character 
> so that the footstep sounds and the character's voice emanate from different locations within the 3D sound space.  

每个事件触发时, 都要关联一个 game object. game object 基本等同于 Unity 中的 GameObject.  

> For every game object, Wwise stores a variety of information that it will use to determine 
> how each sound will be played back in game.  
> - Property offset values of an audio structure associated with the game object, including volume and pitch.  
> - 3D position and orientation.  
> - Game Sync information, including States, Switches, and RTPCs.  
> - Environment effects.  
> - Obstruction and Occlusion.  

Wwise 引擎为每个 game object 保存了一些信息来决定怎么播这些声音  
"怎么"包括这些:  
- 属性偏移, 例如 volume and pitch.  
- 位置和角度  
- Game Sync infomation, including States, Switches, and RTPCs.  
- Environmental effects.  
  _??_  
- Obstruction and Occlusion.  
  _??_  

attenuation 定义在 structure 上而不是 game object. 是为了给设计人员更大的控制自由.  

_States, Switches, RTPCs 是作为GameObject的信息保存的_  

> The 3D Game Object view in Wwise allows the sound designer to view the game objects to which 
> sounds are associated, the position of game objects in relation to the listener, along with the attenuation radius for each sound.  

可以通过 3D Game Object view 来观察 objects 关联的声音, game object 相对listener的位置, 还有声音的衰减范围.  

_? The 3D Game Object view 应该是 Wwise 工程的一个窗口_  

### Registering Game Objects  
> Before you can use game objects, the programmer needs to register them in the game code. 
> when you no longer need the game objects, you should un-register them, 
> because the sound engine will continue to store their related information (3D Position, RTPCs, Switches, and so on) until the game object 
> associated with these values is unregistered.  

在Wwise里使用之前需要注册, 不用之后要取消注册.  
否则Wwise会一直记录这个 game object 的相关信息.  

### Scope - Game Objects VS Global  

> The scope determines the level at which properties and Events are applied to the sound in your game. 
> You now have the choice to apply these elements at game object level or globally. 
> The specific situation and/or action that is taking place in game, will determine the scope 
> and ultimately the approach you take in Wwise.  

_?? The specific situation and/or action that is taking place in game 指什么, scope 不是和 Event 绑定的吗_  

> For example, lets say you are creating a first-person shooter game. 
> The main character in you game must navigate the city streets to capture the enemy's flags.  
> As the character walks through the city, you will hear his footsteps.  
> If want to change the properties or sounds associated with these footsteps, 
> you will only want to apply these changes locally at the level of game objects specifically related to the main character's feet. 
> On the other hand, if your character submerges himself underwater, 
> all the sounds that continue to play within the surrounding environment, 
> such as explosions and vehicles, will need to be modified. 
> In case like these, you will want the changes to be made on global scale.  

如果想要改变角色走的声音, 只需要在game object 级别做出改变.  
如果角色进入潜水状态, 需要在全局做出改变.  

_?? 怎么改scope, scope好像是资源级别的属性, 需要换个事件发吗_  
_?? 如果是换事件, 怎么处理声音之间的过渡_  

### Benefits of Using Game Objects 
> By using game objects, the management of audio has been simplified 
> because programmers only have to keep track of game objects and not the individual sounds.  

使用 game object 的好处是, 程序可以用对待 game object 的方式来看待声音. 

> Once the game objects are created, programmers only to post Events, set up the Game Sync, 
> including Switches, States, and RTPCs, 
> and in-game environments. 
> The specific details of which sound is played and how it will play are defined by sound designer in Wwise. 
> By using this approach, you can save a huge amount of time when dealing with the multitude 
> of sounds associated with the various entities within you game.  

程序只需要关心 post Events, set up Game Sync (Switches, states, RTPCs)  

[What are Game Objects?](https://www.audiokinetic.com/library/edge/?source=WwiseFundamentalApproach&id=what_are_game_objects__what_are_game_objects)  