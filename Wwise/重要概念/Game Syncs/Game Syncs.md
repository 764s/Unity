Game syncs
==

> After the initial game design is complete, 
> you can start looking at how you could use Wwise elements called Game Sync 
> to steamline and handle the changes and alternatives that are part of the game.  

通过 Game syncs 来动态改变 和 应用 alternatives.  

_?? to streamline and handle the changes and alternatives that are part of the game, that 是 changes and alternative 还是 alternative 一个的_  

> You can define which of the five different kind of Game sync you will need to achieve 
> the best results possible to enhance the visuals of the game.  
> - States  
>   a change that occurs in game that affects the properties of existing sounds, music, or motion on a global scale.  
> - Switches  
>   a representation of the alternatives that exist for a particular game element 
>   that my require completely new sounds, music, or motion.  
> - RTPCs
>   properties that are mapped to variable Game Parameter values in such a way 
>   that changes to the Game Parameter values modify the properties themselves.  
> - Triggers  
>   a response to a spontaneous occurrence in game that launches a stinger, 
>   which is a brief musical phrase that is superimposed and mixed over the currently playing music  

Game Sync 一共有五种  
- States  
  全局级别的属性改变, 针对正在播放的声音  
  _? 改变的是 sounds 的固有属性_  
  _?? 支持改变单个声音吗_  
- Switches  
  某个特定的 game element 需要的 sounds music或motion 的 变体集合  
  _通常会换声音_  
  _?? 支持过渡吗_  
- RPTCs  
  属性集合, 关联游戏参数和声音参数. 可以改变 variable Game Parameter values.  
  _?? variable Game Parameter values 具体的例子是什么_  
- Triggers  
  launches a stinger, 和正在播放的 music 叠加播放.  
  _?? music 和 sound 有什么区别_  
  _?? 可以对除了music的其他Wwise元素用吗_  
  
_?? 可是这是四种..._  

> When you are building your game project, you have to juggle quality, 
> memory usage restrictions, and the time constrains that you face. 
> Using Game Sync strategically can simplify you work, economize on memory, 
> and help to build a truly immersive game experience.  

在游戏中需要关注品质, 内存, 效率.  
需要为了简单, 低内存来有策略的使用.  





[What are Game Syncs?](https://www.audiokinetic.com/library/edge/?source=WwiseFundamentalApproach&id=what_are_game_syncs__what_are_game_syncs)  