Imports System
Imports EnvDTE
Imports System.Diagnostics
Imports System.IO

'这个模块主要是用来为项目添加一些特殊的上下文菜单操作
Public Module Clearcase
    '这个方法是定位到当前项目的目录
    Public Sub VersionTree()
        Dim file As String
        file = DTE.ActiveDocument.FullName()
        Dim process As New System.Diagnostics.Process
        process.Start("D:\project\helloworld\Debug\helloworld.exe", file) '打开资源管理器
    End Sub
    '这个方法是定位到当前项目的目录
    Public Sub CheckIn()
        Dim file As String
        file = DTE.ActiveDocument.FullName()
        Dim process As New System.Diagnostics.Process
        process.Start("D:\project\helloworld\Debug\helloworld.exe", file) '打开资源管理器
    End Sub
End Module
