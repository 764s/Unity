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

