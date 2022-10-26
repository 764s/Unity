[AssetWorkflow]
==

## 资源流程:  
* Import  
* Create  
* Build  
* Distribute  
* Load  

### import  
把源文件弄到 Unity 编辑器中. 把源文件放到 `Assets` 目录时, Unity 会自动导入.  
需要理解:  
* 文件存在哪  
* 怎么调整导入设置  
* meta 文件是干什么的  
* Asset DataBase 是怎么保存导入数据的  

Unity 会读取 `Asset` 目录下的文件, 生成对应的内部数据放在 `Library` 目录下  
内部数据是 [AssetDatabase] 的一部分  
在项目没有在 Unity 打开的情况下可以安全删除 `Library` 目录, 
下次打开的时候会根据 `Assets` 和 `ProjectSettings` 自动生成  
`Library` 目录不应该加入版本控制  

一些情况下 Unity 会为单个 asset 文件生成多个 asset:
* 2D Sprite
* 3D 文件定义了材质或者嵌入了 Texture  
* 3D 文件包含了 multiple animation timelines or multiple clips  
    _? 这两有什么不同_

[ImportingAssets]  
团队合作时 [UnityAccelerator] 可以加速资源处理  

### Create  


[AssetWorkflow]:https://docs.unity.cn/2021.3/Documentation/Manual/AssetWorkflow.html  
[ImportingAssets]:https://docs.unity.cn/2021.3/Documentation/Manual/ImportingAssets.html  
[UnityAccelerator]:https://docs.unity.cn/2021.3/Documentation/Manual/UnityAccelerator.html  
[AssetDatabase]:AssetDatabase.md  