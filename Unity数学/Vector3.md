Vector3
==

### Cross
左手大拇指指向a, 食指指向b, 弯曲中指的方向就是结果方向

### 特例  
记住1(和4)就行了  
1. right x up = forward  
2. up x left = forward  
3. forward x up = left  
4. up x forward = right

### 应用  
已知角色移动方向 moveDirection, 角色上方 up, 地面法线 normal    
希望把移动方向调整到地面上  

#### 思路1  
利用特例1, 需要获得right就行了  
var right = up x moveDirection  
var surfaceForward = right x normal  

#### 思路2  
利用特例2, 获得left就行了 
var left = moveDirection x up  
var surfaceForward = normal x left  

### 推论  
+ 两个平面的相交线方向是他们法线的cross  
+ 已知表面a normal, 方向 direction, direction 和 up 构成另一个面b  
  希望获得 direction 在表面a的投影, 同时也在面 b 内  
  normal x (direction x up)  
  如果 normal == up, 其实是获得 direction 在表面b的投影, 效果等于 ProjectOnPlane








