Public Class Form1
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Text = TreeView1.SelectedNode.Name
        Select Case TreeView1.SelectedNode.Name
            Case "Node0"
                Me.Hide()
                CosSinTan.show
        End Select

    End Sub
End Class
