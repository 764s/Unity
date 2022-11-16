Listener
==

> A Listener represents a microphone in the game. 
> A Listener has a position and orientation in the game's 3D space. 
> During game play, the coordinates of the listener are compared with the game object's 
> position, so that 3D sounds associated with game objects can be assigned to the 
> appropriate speakers to mimic a real 3D environment. 
> Programmers must ensure that the listener's positional information is kept up to date. 
> otherwise sounds will be rendered through the wrong speakers.  

### Multiple Listeners  
> In a single-player game where you always see only one point of view in the game, 
> on listener is enough. However, if multiple players can play on the same system, 
> or if multiple views are displayed at the same time, each view requires its own 
> listener so audio is appropriately renderer for all of these views. 
> The Wwise sound engine supports un unlimited number of listeners. 

> By default, every registered game object is assigned to the first listener only. 
> However, the programmer has the flexibility to dynamically  assign or un-assign 
> any game object from any listener.  

> There are many challenges to implementing for multiple listeners 
> because  the positioning of sound sources does not always make scene 
> in relation to what each player is seeing. 
> This is mostly caused by a game using only on set of speaker to reproduce the 
> 3D environment for several players. 
> Wwise offers a variety of tools and techniques to offset this limitation 
> so that the audio experience is as realistic as possible for all players. 
> For more information about how Wwise handles multiple listeners, refer to the section 
> "[Integrating Listeners]" in the SDK doc.  

[Integrating Listeners]:https://www.audiokinetic.com/library/edge/?source=SDK&id=soundengine_listeners.html  
[Listeners](https://www.audiokinetic.com/library/edge/?source=WwiseFundamentalApproach&id=listeners__listeners)  