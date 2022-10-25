CinemachineBrain
=
https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineBrainProperties.html  
直接挂在相机上的组件, 管理所有的虚拟相机, 选择谁来控制真实相机, 也提供 cut 或者 blend 的功能  
Timeline 会覆盖 Cinemachine 的控制  
_??同一个相机多个 Brain 会冲突吗, 可能相关`CinemachineCore.FindPotentialTargetBrain`_  

属性  
-
| 属性 | 子分类 | 作用 | 注释 |
| :---: | :---: | :---: | :--- |
| ignoreTimeScale | | `Check to make the Virtual Cameras respond in real time to user input and damping, even if the game is running in slow motion.` | _??不是 TimeScale 吗, 怎么跟 input damping 有关系了_ |
| worldUpOverride | | `The Y axis of the specified GameObject defines the worldspace up vector for Virtual Cameras. Use this property in top-down game environments. Set to None to use the worldspace Y axis. Setting this appropriately is important to avoid gimbal-lock in extreme up/down conditions.` | _这个值是个Transform, 在俯视视角用到, 暂时不清楚实际用处_ |
| updateMethod | | | |
| | FixedUpdate | 在 FixedUpdate 中处理. 如果 targets 在 FixedUpdate 中移动 (如 rigidBody) 适用这个 | |
| | LateUpdate | 在 LateUpdate 中处理 | |
| | SmartUpdate | `according to how its target is updated` | _??target 指什么, follow 还是 aim (这俩还不一样), 还是别的. ??_| 
| | ManualUpdate | 手动调用 `brain.ManualUpdate()`, 需要确保所有 FollowTarget 和 LookAtTarget 移动后 | |
| blendUpdateMethod | | `when to blends and update the main camera` | |
| | LateUpdate | 在 LateUpdate 中处理 | |
| | FixedUpdate | 在 FixedUpdate 中处理, updateMethod 是 FixedUpdate 或者 `judder` 时 | |
| cameraCutEvent | | `This event fires when a Virtual Camera goes live and there is no blend.` | |
| cameraActivated | | `This event fires when a Virtual Camera goes live. If a blend is involved, then the event fires on the first frame of the blend.` | |

分屏  
-
https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineMultipleCameras.html  
` Cinemachine Brain uses only those Virtual Cameras that pass the culling mask of the Unity camera. You can set up split-screen environments by using the culling mask to filter layers`  
_??分屏依赖相机的 Culling Mask, 这会影响相机的内容, 如果两个相机想看到同样的内容呢_  
_??有Brain(不同相机)时, 虚拟相机怎么知道自己被谁控制, 根据虚拟相机的 layer 吗_  

杂项
-
### Blend  
计算融合 `CameraState.Lerp`  

### ManualUpdate  
```c#
// CinemachineBrain 控制的相机 GameObject
// 可以手动设置这个指, 指向别的相机
// 一般来说 CinemachineBrain 直接和相机在同一个 GameObject 上
public GameObject ControlledObject { get; set; }

// CinemachineBrain 控制的相机 
// ControlledObject 上的相机组件
public Camera OutputCamera { get; }

public void ManualUpdate()
{
    m_LastFrameUpdated = Time.frameCount;

    float deltaTime = Time.deltaTime; // ManualUpdate 固定是Time.deltaTime, 如果在 fixedUpdate 中调用不是很合理
    
    UpdateFrame0(deltaTime);
    
    ComputeCurrentBlend(ref mCurrentLiveCameras, 0);
    
    UpdateVirtualCameras(CinemachineCore.UpdateFilter.Late, deltaTime);
    
    ProcessActiveCamera(deltaTime);
}

// 游戏启动第一帧
// 实际没有执行任何功能
// deltaTime = Time.deltaTime
private void UpdateFrame0(float deltaTime)
{
    // 就算刚开这一句也不会执行, CinemachineBrain.OnEnable 的时候会加入
    // if (mFrameStack.Count == 0)
    //    mFrameStack.Add(new BrainFrame());
    
    // 第一次取出来的时候这里是空, 所以应该可以认为这里本来的数据全部无效
    // Update the in-game frame (frame 0)
    BrainFrame frame = mFrameStack[0];
    
    // 按优先级获取启用的 ICinemachineCamera
    // 这个值可能为空
    ICinemachineCamera activeCamera = null;
    
    // ?? 这个出去的不知道是指 要生效的 还是指 要失效的
    ICinemachineCamera outGoingCamera = null;
}
```


```c#

// 第一帧
public void ManualUpdate()
{
    m_LastFrameUpdated = 0;
    
    BrainFrame frame = mFrameStack[0];
    frame.workingBlend.CamA = frame.blend.CamA;
}

```

