Public Class frm_modify_a208749

    Private Sub frm_modify_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now

        lbl_date.Text = current_date


    End Sub
    Private Sub btn_insertproducts_Click(sender As Object, e As EventArgs) Handles btn_insertproducts.Click

        frm_insertproducts_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_updateproducts_Click(sender As Object, e As EventArgs) Handles btn_updateproducts.Click

        frm_updateproducts_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_insertstaffs_Click(sender As Object, e As EventArgs) Handles btn_insertstaffs.Click

        frm_insertstaffs_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_updatestaffs_Click(sender As Object, e As EventArgs) Handles btn_updatestaffs.Click

        frm_updatestaffs_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_insertcustomers_Click(sender As Object, e As EventArgs) Handles btn_insertcustomers.Click

        frm_insertcustomers_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_updatecustomers_Click(sender As Object, e As EventArgs) Handles btn_updatecustomers.Click

        frm_updatecustomers_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub lbl_desc2_Click(sender As Object, e As EventArgs) Handles lbl_desc2.Click

    End Sub
End Class