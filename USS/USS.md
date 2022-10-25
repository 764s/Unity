USS
=
Unity Style Sheet  
https://docs.unity.cn/Manual/UIE-USS.html  
https://docs.unity.cn/Packages/com.unity.timeline@1.7/manual/uss_styles.html  
[UI Toolkit 支持的属性](https://docs.unity.cn/Manual/UIE-USS-Properties-Reference.html)  
USS 是类似 CSS 的文本文件  

USS 文件的基本构件
-
USS 是文本资源, 文件扩展名必须是 `.uss`  

必须手动加载, 否则不会生效  
如果使用 common 命名文件名可以搭系统便车自动加载  
EditorWindow..GetRootVisualContainer() 可以获取 Root VisualElement  
调用 VisualElement.styleSheets.Add(EditorGUIUtility.Load(path) as StyleSheet) 或者 VisualElement.AddStyleSheetPath 可以加载并应用这个 

[Visual Tree](https://docs.unity.cn/Manual/UIE-VisualTree.html)