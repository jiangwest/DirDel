# DirDel
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
