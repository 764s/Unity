+ 任务栏缩略图显示成文件名列表  
  https://answers.microsoft.com/en-us/windows/forum/all/how-do-i-change-taskbar-icon-preview-from/fed816fe-9120-4613-b6f8-ca85bd9a614e  
  1.   
     1. win + r 打开运行界面  
     2. 输入 regedit 确定  
  2. 直接通过地址栏到达指定Key位置  
     `HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Taskband`  
  3. 选中 `Taskband` key, 点击值 `NumThumbnails`, 调整 `数值数据` 到 2  
     如果没有 `NumThumbnails`, 手动创建一个, 值类型选 `DWORD (32-bit) Value`
        