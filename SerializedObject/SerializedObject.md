[SerializedObject](https://docs.unity3d.com/2021.3/Documentation/ScriptReference/SerializedObject.html)  
==
SerializedObject (和 SerializedProperty ) 是编辑 [Unity Objects](https://docs.unity3d.com/2021.3/Documentation/ScriptReference/Object.html)  的通用方式  

These classes automatically handle dirtying individual serialized fields so they will be processed by the Undo system and styled correctly for Prefab overrides when drawn in the Inspector.  

通过 SerializedObject 可以批量设置对象属性, __并且支持 Undo__  

```c#
// 这种方式会直接修改, 不能 undo
[MenuItem("Test/重置选中物体未知(NoUndo)")]
public static void ResetPositionNoUndo()
{
    foreach (var gameObject in Selection.gameObjects)
    {
        gameObject.transform.position = Vector3.zero;
    }
    
    Debug.Log("ResetPositionNoUndo");
}

[MenuItem("Test/重置选中物体未知")]
public static void ResetPosition()
{
    // 刚创建出来的数据自动是最新的
    var serializedObject = new SerializedObject(Selection.transforms);
    
    // shift + 右键 会出现 Print Property Path 选项, 点击会打印脚本里的实际属性名
    serializedObject.FindProperty("m_LocalPosition").vector3Value = Vector3.zero;
    
    // 没这句不会实际生效
    serializedObject.ApplyModifiedProperties();
    
    Debug.Log("ResetPosition");
    
    // 这是文档的例子 并没有考虑销毁, 是不用还是没展示呢
}
```

SerializedObject 可以看作一个简单的数据缓存.  
SerializedObject.Update 会把对象的实际数据放入缓存.  
SerializedObject.ApplyModifiedProperties 会把缓存中的数据赋值给对象.  

刚创建出来的 SerializedObject 数据自动是最新的  
代表多个对象时 SerializedObject 读出来的数据是第一个的值  

OnInspectorGUI默认会首先自动调用 Update, 完成后调用 ApplyModifiedProperties  
如果重写需要在末尾额外调用 ApplyModifiedProperties 否则数据不会生效  
如果完全重写(不保留 base.OnInspectorGUI()), 则需要手动 Update (可能在别的地方修改了) 和 ApplyModifiedProperties.  

