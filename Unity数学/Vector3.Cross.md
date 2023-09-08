Vector3.Cross
==
左手大拇指指向a, 食指指向b, 弯曲中指的方向就是结果方向

### 特例  
记住1(和4)就行了  
1. right x up = forward  
2. up x left = forward  
3. forward x up = left  
4. up x forward = right  
5. left x forward = up  
6. left x up = back  
7. forward x right = up

### 应用
+ 判断方向`b`在自己`a`的左边还是右边  
  根据 `forward x right = up`, 如果 a x b 和 a 的上方相同则在右, 否则在左  


+ 根据参考上方`baseUpDirection`获得`forward`的严格上方  
  forward x up x forward  
  + 思路  
  left = forward x up  
  newUp = left x forward  
  

+ 把 forward 根据参考上方 baseUp, 调整到 up 平面内
  up x (forward x baseUp)  
  + 思路:  
  left = forward x baseUp  
  newForward = up x left


+ 已知角色移动方向 moveDirection, 角色上方 up, 地面法线 normal    
希望把移动方向调整到地面上  
  + 思路1  
  利用特例1, 需要获得right就行了  
  var right = up x moveDirection  
  var surfaceForward = right x normal
  + 思路2  
  利用特例2, 获得left就行了  
  var left = moveDirection x up  
  var surfaceForward = normal x left  
    
### 反应  
  + (a x b).normalize = c  
    任何 a x b 或者可以转化成 a x b 形式的计算都可以在计算两个平面的交线  
    + 认为a, b都代表平面, c是两个平面的相交方向  
      + c 垂直a -> c 在 a代表的平面内  
      + 同理 c 在 b 代表的平面内  
        -> c同时在两个平面内  
        -> c是a,b两个平面的交线  
    
    
  + a x b x c 形式  
    理解为 up1 x forward x up2  
    总是可以理解为把 forward 投影到结果平面内, 相对forward后生效的是结果平面法线, 先生效的是参考方向投影要把持在forward和这个方向组成的平面  
    对up1 == up2的情况, 只是把forward投影到up1代表的平面, 效果等于 ProjectOnPlane  
    例子
    + up1 x forward x up2. up1先生效是限制方向, up2后生效是结果平面  
    + up1 x (forward x up2). up2先生效是限制方向, up1后生效是结果平面  
    
+ a x b x a
    + 把 forward a 参考 up b, 获得自己的严格上方  
    + 把方向 b 垂直投影到平面 a, 等同与 b projectOn a
    

  + (a x b x c).normalize = d
    + 认为b是指定方向, a是参考上方, c是平面  
      保持 b 在 a x b 平面内, 同时投影到 c 平面上  
      (也就是 a x b 和 c 平面的交线上)  
      + up x forward 获得 right  
      + right x up 获得 forward
      
      

### 推论  
+ 两个平面的相交线方向是他们法线的cross  
+ 已知表面a normal, 方向 direction, direction 和 up 构成另一个面b  
  希望获得 direction 在表面a的投影, 同时也在面 b 内  
  normal x (direction x up)  
  如果 normal == up, 其实是获得 direction 在表面b的投影, 效果等于 ProjectOnPlane








