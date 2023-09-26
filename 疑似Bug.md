疑似Unity BUG
==

1. 在Inspector操作触发OnEnable时, 如果在这里new GameObejct()并且立即拿transform会报空  
   Unity2019.4.40f1
    ```c#
    public class TestCreateGameObjectOnEnable : MonoBehaviour
    {
        private void OnEnable()
        {
            // 鼠标点enable框 或者 拖脚本到 Inspector上会报错
            // ctrl + d 复制时不会报错
            var t = new GameObject().transform;
        }
    }
    ```
   猜测 GameObject new 出来会走一段流程, 但通过Inspector时, 这个流程不会走导致错误  