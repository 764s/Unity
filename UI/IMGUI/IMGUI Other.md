+ `GUIUtility.GetControlID`的声明周期只有一帧  
    帧之外可能导致 `ControlId` 变掉  
    所以应该主动保证, 即使 `ControlId` 变了, UI显示也不应该坏掉  
    `GUIUtility.GetControlID("CustomButton", FocusType.Passive)`  
    `GUIUtility.hotControl`  
    `GUIUtility.GetStateObject`  
    https://discussions.unity.com/t/how-a-control-keep-same-controlid-from-getcontrolid-in-a-dynamic-ui/778489/6

+ 不能在 `GUILayout.BeginVertical` 之后立即调用 `GUILayoutUtility.GetLastRect`  
   否则会报错  

+ 如果想要知道 `GUILayout.BeginVertical` 实际占据范围, 在 `GUILayout.EndVertical` 之后调用  
+ 通过`GUILayoutUtility.GetLastRect`获取的Rect直接交给另一个`GUILayout.BeginVertical(GUILayout.Height(r.height));`无效  
    效果等于直接传0  
+ `GUILayout.BeginVertical`传入了指定高度, 实际高度也不会比内容高度小. 即时指定了 `GUILayout.ExpandHeight(false)`  
    ```c#
    // h 传入的值只要比文本实际高度小, 显示的就是文本的高度
    var h = 20;
    GUILayout.BeginVertical(GUILayout.Height(h), GUILayout.ExpandHeight(false));
    {
       GUILayout.Label("1"); // 实际高21
       DrawRect(GUILayoutUtility.GetLastRect(), Color.red * 0.6f);
    }
    GUILayout.EndVertical();
    DrawRect(GUILayoutUtility.GetLastRect(), Color.green * 0.6f);
    ```
+ 并排Label和Slider时, 如何让他们垂直居中  
    注意其中关于`FlexibleSpace`的注释  
    太过复杂还是建议手动算好
    ```
      // 传入1可以限制整个区域的大小符合真实情况(由`GUILayout.Height`机制决定). 传不传 GUILayout.ExpandHeight(false) 不影响结果
      GUILayout.BeginHorizontal( GUILayout.Height(1));
      {
          GUILayout.BeginVertical();
          GUILayout.Space(0);
          GUILayout.Label("速度", LabelBoldLeft_30, GUILayout.Width(LabelWidth));
          GUILayout.EndVertical();
        
          DrawRect(GUILayoutUtility.GetLastRect(), Color.white * 0.6f);
          GUILayout.Space(10);
          GUILayout.BeginVertical();
      {
          // 这个 GUILayout.FlexibleSpace 会让 GUILayout.Label("速度") 产生一个莫名奇妙的下沉
          // 在Label上插入一个Space(0)会消除这个下沉
          // 可能跟 Space 系列内部的 `consideredForMargin = false` 有关
          GUILayout.FlexibleSpace();
          debugScene.TimeScale = GUILayout.HorizontalSlider(debugScene.TimeScale, 0, 5);
          GUILayout.FlexibleSpace();
        
      }
      GUILayout.EndVertical();
      DrawRect(GUILayoutUtility.GetLastRect(), Color.green * 0.6f);
      }
      GUILayout.EndHorizontal();
      DrawRect(GUILayoutUtility.GetLastRect(), Color.red * 0.6f);
    ```