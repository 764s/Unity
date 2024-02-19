### HideFlags
+ GameObject  
  + None
  进入播放模式时随场景进入播放模式  

  + DontSave  
  进入播放模式时不会放入播放场景, 并且引用不会丢失.  

### 进入播放模式顺序  
测试得到  
#### `EditorWindow`的属性在`OnEnable`时:  
+ 不重置:  
  + private int  
  + private string str  
  + private TestSerialiableClass  
  + private Transform  
  + private List&lt;Transform>  

+ 重置:  
  + private struct  
  + private object  
  + private TestClass
  + private PlayableGraph  
  + private PlayableGraph?  
  + private Action  
  + private event Action  
  + private List&lt;object>  
  + public List&lt;object>  
  + EditorApplication.update  
  + EditorApplication.playModeStateChanged  
  + AssemblyReloadEvents.beforeAssemblyReload  
  + AssemblyReloadEvents.afterAssemblyReload  

#### EditorSceneManager.NewPreviewScene产生的Scene: 
本身不会有任何改变  

#### 事件顺序:  
直接编代码也会有这些事件, 只是playModeStateChanged相关事件没了  
  + ExitingEditMode  
  + beforeAssemblyReload
  + 已经打开的EditorWindow.OnDisable  
  + 已经打开的EditorWindow.OnEnable  
  这个时候应该已经发生了, 只是事件没有调用  
  + afterAssemblyReload  
  + EnteredPlayMode  

### 退出播放模式顺序  
测试得到  
`EditorWindow`的普通属性List&lt;Transform>总是保留, 不管是不是在进入播放模式之前还是之后创建  
`PlayableGraph`总是不受影响  
+ ExitingPlayMode  
+ EnteredEditMode  

### 特殊文件夹
https://docs.unity.cn/cn/current/Manual/SpecialFolders.html  

### 事件函数执行顺序
https://docs.unity.cn/cn/current/Manual/ExecutionOrder.html  

### StandaloneInputModule
Unity 自带输入系统  
[learn-the-input-system-with-updated-tutorials-and-our-sample-project-warriors](https://blog.unity.com/technology/learn-the-input-system-with-updated-tutorials-and-our-sample-project-warriors)  

### property.FindPropertyRelative 不写路径  
参考 `Cinemachine.CinemachineImpulseDefinitionPropertyDrawer`
```c#
#pragma warning disable 649 // variable never used
CinemachineImpulseDefinition m_MyClass;
#pragma warning restore 649

public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
{
    m_ImpulseTypeProperty = property.FindPropertyRelative(() => m_MyClass.m_ImpulseType);
}
```

### 进播放模式
https://docs.unity3d.com/Manual/ConfigurableEnterPlayMode.html  
不会销毁在非播放状态下创建的材质  
会重建静态类

### Unity 便捷操作  
https://blog.unity.com/technology/five-ways-to-speed-up-your-workflows-in-the-editor  

### 建议  
[become-a-better-unity-developer-with-these-tips-from-the-community](https://blog.unity.com/technology/become-a-better-unity-developer-with-these-tips-from-the-community)  

### 职业路线  
[new-career-pathways-help-you-break-into-the-gaming-and-tech-industries](https://blog.unity.com/technology/new-career-pathways-help-you-break-into-the-gaming-and-tech-industries)  

### 未分类
[tips-for-working-more-effectively-with-the-asset-database](https://blog.unity.com/technology/tips-for-working-more-effectively-with-the-asset-database)  
[enter-play-mode-faster-in-unity-2019-3](https://blog.unity.com/technology/enter-play-mode-faster-in-unity-2019-3)  
[introducing-the-new-input-system](https://blog.unity.com/technology/introducing-the-new-input-system)  
https://unity.com/how-to/organizing-your-project#folder-structure  

+ 关于材质  
  Renderer.materials 和 Renderer.sharedMaterials  
  Get方法完全一样, 把里面的材质返回出来, 里面是Shared就返回Shared, 是示例就返回实例
  Set 方法 Renderer.materials 一定会创建实例材质, 但暂时不清楚如果已经是实例化的材质了他还会不会创建(shared有严格定义吗, unity分的出来吗)