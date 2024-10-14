GUIUtility.GetControlID的声明周期只有一帧
帧之外可能导致 ControlId 变掉
所以应该主动保证, 即使 ControlId 变了, UI显示也不应该坏掉
GUIUtility.GetControlID("CustomButton", FocusType.Passive)
GUIUtility.hotControl
GUIUtility.GetStateObject
https://discussions.unity.com/t/how-a-control-keep-same-controlid-from-getcontrolid-in-a-dynamic-ui/778489/6