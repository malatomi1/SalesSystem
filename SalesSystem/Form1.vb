Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frmcustomers.ShowDialog()


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        OPENCONNECTION()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FrmSupliers.ShowDialog()

    End Sub

    Private Sub btnFrmItems_Click(sender As System.Object, e As System.EventArgs) Handles btnFrmItems.Click
        FrmReceptionItems.ShowDialog()
    End Sub

    Private Sub btnitem_Click(sender As System.Object, e As System.EventArgs) Handles btnitem.Click
        FrmItems.ShowDialog()

    End Sub

End Class
