# DirDel 开发笔记
- aim: to delete a specific directory or files recursively

比如用于删除某个C#解决方案内所有`bin`文件夹

- language: C#

c# 遍历文件夹下文件

- `DirectoryInfo.GetFiles()`：获取目录中（不包含子目录）的文件，返回类型为FileInfo[]，支持通配符查找
- `DirectoryInfo.GetDirectories()`：获取目录（不包含子目录）的子目录，返回类型为DirectoryInfo[]，支持通配符查找

Example: 

```csharp
C#遍历指定文件夹中的所有文件 
DirectoryInfo curFolder=new DirectoryInfo(folderFullName);

//遍历文件夹
foreach(DirectoryInfo folder in curFolder.GetDirectories())
   listBox1.Items.Add(folder.Name);
   
//遍历文件
foreach(FileInfo file in curFolder.GetFiles())
   listBox2.Items.Add(file.Name);
```

参考
- Book: Pro C# 5.0 and the .NET 4.5 Framework -> Chapter 20 -> The Directory(Info) and File(Info) Types

![](http://img.blog.csdn.net/20141111102957709?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvamlhbmdkbWRy/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/Center)


下面示例列出了“c:\”中以字母“c”开头的所有目录和文件

```csharp
using System;
using System.IO;

class App
{
    public static void Main()
    {
        // Specify the directory you want to manipulate.
        string path = @"c:\";
        string searchPattern = "p*";

        DirectoryInfo di = new DirectoryInfo(path);
        DirectoryInfo[] directories =
            di.GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);

        FileInfo[] files =
            di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

        Console.WriteLine(
            "Directories that begin with the letter \"c\" in {0}", path);
        foreach (DirectoryInfo dir in directories)
        {
            Console.WriteLine(
                "{0,-25} {1,25}", dir.FullName, dir.LastWriteTime);
        }

        Console.WriteLine();
        Console.WriteLine(
            "Files that begin with the letter \"c\" in {0}", path);
        foreach (FileInfo file in files)
        {
            Console.WriteLine(
                "{0,-25} {1,25}", file.Name, file.LastWriteTime);
        }

        Console.ReadLine();
    } // Main()
} // App()
```
