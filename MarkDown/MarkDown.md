Markdown 语法
=
标题
-
在行首加1-6个`#`
> # 1及标题
> ## 2级标题
> ### 3级标题
> #### 4级标题
> ##### 5级标题
> ###### 6级标题

在一行的下一行写`=`也可以产生1级标题  
这种形式比#优先生效, 但不能强制结束区块引用
> 1
> =

在一行的下一行`-`也可以产生2级标题  
这种形式比#优先生效, 但不能强制结束区块引用
> 1
> -

段落
-
没有特殊标记的文字会视为连续的段落  
在段内换行需要两个以上的空格加上回车  
段落内的多个空白行会合并成一行  


中间的空行正常生效  
段落首尾的空行会被忽略


区块引用
-
在段落的每行或者只在第一行的行首使用`>`
> 区块引用  
第二行  
> 第三行

用空白行打断区块引用, 空白行指只含有空格或制表符的行
>    `>`后的前四个空格会忽略(包括第四个)

区块之前的空白行会被忽略, 区块行尾的空白行也会忽略

> 忽略了行首2行空白行, 忽略了行尾2行空白行
> 

`>`后紧接的所有空格都会忽略 (但是从5个之后, 如果再输入其他字符会触发代码区块)
>    前面四个空格都忽略了

区块引用可嵌套
>>>
>
> 用 `>` + 空行结束嵌套, 之后的行首的 `>`个数表示了新开始的嵌套级别


代码区块
-

代码区块以一个空白行开始, 之后在每行行首加上四个空格或者制表符  


     void Test();
用不符合规则的非空白行打断代码区块  
行尾的空白行会被忽略

    忽略了一行空白行


要在区块引用内开始代码区块, 需要写5个空格 ( 可以理解为忽略了第一个空格 )  
并且可以直接开始, 不需要先写一个空白行
>      这里有6个空格, 前5个产生代码区块, 最后一个正常显示

三个`也可以开始代码区块
```c#
var obj = new GameObject();
```

强调
-
在需要强调内容的两侧加上`*`或者`_`  
中间不能有空格  
`_`要好些, 不会像 `*` 有误判
> *斜体*  
_斜体_

2个会变成粗体
> **粗体**  
> __粗体__

3个以上会在`斜粗体`和`粗体`之间切换
> ***斜粗体***
> ____粗体____

列表
-
+ ### 无序列表

在行首写`*`, `+` 或者`-`开始
> + 第一项
>   + 用四个空格嵌套
>       + 继续嵌套
> - 第二项
> * 第三项
> 
+ ### 有序列表

行首数字加上`.`开始
1. 第一项
   1. 用四个空格嵌套
        1. 继续嵌套
2. 第二项
3. 第三项

分割线
-
三个以上的纯`*`, `-`或者`-`
> ***
> ---
> ___

链接
-
+ ### 显式
  直接写链接
> https://www.baidu.com
  
+ ### 行内式
 `[`显示`]` `(`链接`)`
> `[百度](https://www.baidu.com)`
> > [百度](https://www.baidu.com)
  
+ ### 引用式
 使用 `[`显示`]` `[`引用序号`]`  
 定义 `[`引用序号`]`:链接
> `[百度][1]`  
> `[1]:https://www.baidu.com`  
>> [百度][1]  
> 
>注意定义不能在区块引用内

[1]:https://www.baidu.com

图片
-
+ ### 行内式
`!` `[显示]` `(`链接`)`
> `![图片](https://img1.baidu.com/it/u=1705865268,2944844920&fm=253&fmt=auto&app=138&f=JPEG?w=500&h=333)`  
>> ![图片](https://img1.baidu.com/it/u=1705865268,2944844920&fm=253&fmt=auto&app=138&f=JPEG?w=500&h=333)  

+ ### 引用式
使用 `!` `[`显示`]` `[`引用序号`]`  
定义 `!` `[`引用序号`]`:链接  
序号可以是普通文字, 如果显示和序号一样, 这种情况下可以省略序号方括号  
> `![图片][2]`  
> `[2]:https://img1.baidu.com/it/u=1705865268,2944844920&fm=253&fmt=auto&app=138&f=JPEG?w=500&h=333`  
> > ![图片][2]  
>
> 注意定义不能在区块引用内

[2]:https://img1.baidu.com/it/u=1705865268,2944844920&fm=253&fmt=auto&app=138&f=JPEG?w=500&h=333

+ ### 本地图片
同链接的方式  
直接粘贴图片会保存在文本相对路径下
> `![img_3.png](img_3.png)`  
>> ![img_3.png](img_3.png)

转义
-
反斜杠 \
> \`1\`

标记
-
两个`  
同时也有转义作用
> `www.baidu.com`

删除线
-
> `~~你好~~`
> > ~~你好~~

上标文本
-
> `<sup>文本</sup>`
> > 你好<sup>你好</sup>

下标文本
-
> `<sub>文本</sub>`  
> > 你好<sub>你好</sub>

表格
-

左对齐 :---  
右对齐 ---:  
居中 :---:  
表格跟区块引用有点冲突. 区块引用内的对齐也无效, 两列表格会多一列  

> `|id | name |`  
> `|--- | :--- |`  
> `| 1 | 小龙虾 |`  
> `| 2 | 西瓜 |`  

|id |name|
|---|:---:|
| 1 | 小龙虾|
| 2 | 西瓜|

折叠
-
`<details></details>`中的代码块会折叠显式  
折叠部分默认显式为Details, 可以用 `<summary>折叠名字</summary>`自定义, 第一个 summary 生效 之后忽略标签直接显式为文本  
折叠标签和代码块之间最好空一行  
<details><summary>折叠部分</summary>
内容
<p>

```c#
var go = new GameObject();
```
</p>

</details>



参考
-
[younghz / Markdown](https://github.com/younghz/Markdown)  
[基本格式语法](https://docs.github.com/cn/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)









