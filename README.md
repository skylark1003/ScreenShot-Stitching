# 基本功能

在看电影或电视剧时遇到想要记录的台词，往往会截图进行拼接，第一张保留整个图片其余的只保留字幕部分，此软件可以实现该功能。

# 使用方法

- 按键功能：

  ![](https://github.com/skylark1003/ScreenShot-Stitching/blob/main/images/func01.png?raw=true)

- 步骤：

  - 点击SELECT选择图片，可以一次性选择多张，最多不超过30张。

    ![](https://github.com/skylark1003/ScreenShot-Stitching/blob/main/images/func02.png?raw=true)

  - 左侧文本框会显示所添加的图片路径，点击右侧REFRESH可以更新预览。

    ![](https://github.com/skylark1003/ScreenShot-Stitching/blob/main/images/func03.png?raw=true)

  - 左侧滑动条可以调节字幕范围，调节后可以通过REFRESH更新。

    ![func04.png](https://github.com/skylark1003/ScreenShot-Stitching/blob/main/images/func04.png?raw=true)

  - 调节完成后点击SAVE将图片保存至本地。

    ![func05.png](https://github.com/skylark1003/ScreenShot-Stitching/blob/main/images/func05.png?raw=true)

  - 生成图片如下：

    ![save.jpg](https://github.com/skylark1003/ScreenShot-Stitching/blob/main/images/save.jpg?raw=true)

- 直接下载 Setup/Debug/Setup.msi 即可安装。

# 遗留问题

- 最好将图片按顺序命名，一次性添加多张图片默认按照文件名，如果随意命名顺序会乱，除非一张一张添加。

- 不可以添加0张照片，否则程序会报错。
- 图片尺寸需要相同，代码中未包括缩放图片功能。