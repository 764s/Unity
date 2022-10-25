Cinemachine
=
https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/index.html  
操作 Unity Camera 的工具箱, 解决复杂的数学计算, 目标跟踪, 构成(??), 融合, cutting between shots(??)  
设计目的是减少耗时的手动操作和对应在代码上的修改上的时间  
支持 FPS, 第三人称, 2D, side-scroller, top down, rts  
_vCamera 自身的位置总是更新的, 角度不更新_

Stage  
-
Cinemachine 的执行流程  
定义于 CinemachineCore  
*?? 这个顺序由谁执行, 分别在什么时候*  

+ Body  
    第二个阶段  
    Position The Camera In Space  
  
+ Aim  
    第三个阶段  
    Orient The Camera To Point At The Target  

+ Noise  
    Final Pipeline Stage  
    Apply Noise  
    This Is Done Separately, In The Correction Channel Of The CameraState  
    *?? Correction Channel 是什么*  
    *?? CameraState 是什么*  

+ Finalize  
    Post-Correction Stage.  
    This Is Invoke On All Virtual Camera Types, After The Pipeline Is Complete  
  
脚本
-
+ CinemachineBrain 执行顺序 (UpdateMethod.SmartUpdate 模式下)
    + OnEnable  
    + OnSceneLoaded (ManualUpdate)  
    + Start (UpdateVirtualCameras)  
    + LateUpdate (ManualUpdate)
    
+ CinemachineExtension 回调执行顺序
    + PrePipelineMutateCameraStateCallback
    + PostPipelineStageCallback Aim  
      *?? 为什么 Aim 在前*
    + PostPipelineStageCallback Body  
    + PostPipelineStageCallback Noise  
    + PostPipelineStageCallback Finalize  
    
+ m_ComponentOwner  

输入  
-

_? `CinemachineCore.GetInputAxis` 和 `CinemachineVirtualCameraBase.GetInputAxisProvider`有啥不同_  
    


