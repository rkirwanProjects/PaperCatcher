Public Class frmHelp

    'Show help file
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath("../../Resources/Help/User%20Support%20for%20Paper%20Catcher.htm"))
    End Sub
End Class