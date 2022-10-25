Playable
=
https://docs.unity3d.com/Manual/Playables.html  

+ Playable  
  https://docs.unity3d.com/ScriptReference/Playables.PlayableExtensions.html  
    + GetTime()  
        局部时间  
        正常播放的情况下, 没开始时是 0, 结束后是结束的时间(最大时间)  
        拉时间线跳播后不靠谱, 应该配合 GetPlayState() 判断  