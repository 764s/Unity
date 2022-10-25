Cinemachine3rdPersonAim
=

https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/Cinemachine3rdPersonAim.html  
这是 3rd-person 套件的一部分  
为了让瞄准更准确, 这个扩展取消了所有 rotational noise, 并且总是强制看向目标点  
*?? 这个目标点指什么, 是 Hand 吗*  
可以用 positional noise 来产生抖动

属性
-

+ Aim Collision Filter  
    瞄准层  
  
+ Ignore Tag  
    忽略 Tag  
    主要用来设置跟随目标  
  
+ Aim Distance  
    目标检测线有多远  
  
+ Aim Target Reticle  
    这里应该是个 2d 图片  
    如果设置的话, 会有一条射线从 FollowTarget 的位置发出, 找到打到的第一个物体, 这个图片会放在GameView 的这个点上  
    射线从相机指向角色, 同时会忽略角色后面的物体  
    ```c#
    ComputeLookAtPoint(state.CorrectedPosition, player)
    ```
    > This point may be different from what the camera is looking at, if the found object is close enough to be affected by parallax as a result of the offset between player and camera.

