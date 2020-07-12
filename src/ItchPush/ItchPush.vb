Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


Public Class ItchPush
    Public Shared Sub normalbuild(ByVal folder As String, ByVal username As String, ByVal gameurl As String, ByVal os As String, ByVal version As String)
        Update()

        Dim SourcePathUpdateButler As String = "butler.exe" 'check for butler
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "push """ & folder & """ " & username & "/" & gameurl & ":" & os & " --userversion " & version
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            proc.WaitForExit()
        Else
            ' The following example requires that Option Infer be set to On.

            ' Define the message you want to see inside the message box.
            Dim msg = "File ""butler.exe"" is missing; cannot push build."

            ' Define a title for the message box.
            Dim title = "Error: File Missing"

            ' Display the message box and save the response, Yes or No.
            Dim response = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Shared Sub Verbose(ByVal folder As String, ByVal username As String, ByVal gameurl As String, ByVal os As String, ByVal version As String)
        Update()

        Dim SourcePathUpdateButler As String = "butler.exe" 'check for butler
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "push """ & folder & """ " & username & "/" & gameurl & ":" & os & " --userversion " & version & " --verbose"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            proc.WaitForExit()
        Else
            ' The following example requires that Option Infer be set to On.

            ' Define the message you want to see inside the message box.
            Dim msg = "File ""butler.exe"" is missing; cannot push build."

            ' Define a title for the message box.
            Dim title = "Error: File Missing"

            ' Display the message box and save the response, Yes or No.
            Dim response = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Shared Sub login()
        Dim SourcePathUpdateButler As String = "butler.exe" 'check for butler
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "login"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            ' The following example requires that Option Infer be set to On.

            ' Define the message you want to see inside the message box.
            Dim msg = "File ""butler.exe"" is missing; cannot push build."

            ' Define a title for the message box.
            Dim title = "Error: File Missing"

            ' Display the message box and save the response, Yes or No.
            Dim response = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Shared Sub Update()
        Dim SourcePathUpdateButler As String = "butler.exe" 'check for butler
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "update"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            proc.WaitForExit()
        Else
            ' The following example requires that Option Infer be set to On.

            ' Define the message you want to see inside the message box.
            Dim msg = "File ""butler.exe"" is missing; cannot push build."

            ' Define a title for the message box.
            Dim title = "Error: File Missing"

            ' Display the message box and save the response, Yes or No.
            Dim response = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
