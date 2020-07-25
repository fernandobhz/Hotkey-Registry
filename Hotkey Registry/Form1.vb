Public Class Form1
    Dim hkr As New HotKeyRegistryClass(Me.Handle)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hkr.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL Or HotKeyRegistryClass.Modifiers.MOD_SHIFT, Keys.I)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = HotKeyRegistryClass.Messages.WM_HOTKEY Then 'NOT THE ACTUAL WINDOWS NAMESPACE
            Dim ID As String = m.WParam.ToString()
            Select Case ID
                Case 0 : MessageBox.Show("CTRL+SHIFT+I")
            End Select
        End If
        MyBase.WndProc(m)
    End Sub


End Class
