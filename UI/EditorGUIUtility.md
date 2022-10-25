EditorGUIUtility  
==
miscellaneous helper stuff for [EditorGUI](https://docs.unity3d.com/2023.1/Documentation/ScriptReference/EditorGUI.html)  

### Static Properties

#### [singleLineHeight](https://docs.unity3d.com/2023.1/Documentation/ScriptReference/EditorGUIUtility-singleLineHeight.html)  
Editor 元素的默认高度.  
比如单行的 EditorGUI.TextField, EditorGUI.Popup  
对多行元素可以通过 [EditorGUILayout.GetControlRect](https://docs.unity3d.com/2023.1/Documentation/ScriptReference/EditorGUILayout.GetControlRect.html) 自定义高度

### Static Methods  

#### [FindTexture](https://docs.unity3d.com/2023.1/Documentation/ScriptReference/EditorGUIUtility.FindTexture.html)  
查找 Unity 内置图片  
没有详细相关文档  
对在 [Built-in Unity variables](https://docs.unity3d.com/2021.1/Documentation/Manual/UIE-USS-UnityVariables.html) icons 项目中的图片可用  

FilterByLabel  
![FilterByLabel](../CommonIcon/FilterByLabel.png)  

FilterByType  
![FilterByType](../CommonIcon/FilterByType.png)  



```c#
// 只带名字, 不带文件夹, 不带后缀
Texture2D erronIcon = EditorGUIUtility.FindTexture("d_console.erroricon");
```

