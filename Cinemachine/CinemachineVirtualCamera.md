CinemachineVirtualCamera
= 
杂项
-
处于禁用状态时, 如果也不处于融合状态, 不会更新  
特别注意从禁用到启用时会直接到最新位置, 然后开始应用缓动. 在 alt 切换到自由视角时, 会先感觉角色靠近尽(没有缓动直接到最新位置, 相机距离近)  
3rdPersonFollow 在速度比较大的时候, damp 可能导致抖动. 加上[CINEMACHINE_EXPERIMENTAL_DAMPING](https://forum.unity.com/threads/solved-cinemachine-freelook-has-bad-jitter-at-high-speed-but-only-from-behind.1034971/#post-8422872) 宏可以解决, 但会导致参数和原来的效果不一致    

