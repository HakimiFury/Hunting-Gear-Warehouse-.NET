Public Class frm_updatestaffs_a208749

    Dim current_code As String
    Private Sub frm_updatestaffs_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        refresh_grid()

        get_current_code()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A208749"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_position.Text = ""

    End Sub

    Private Sub get_current_code()

        ' Check if there are any rows in the grid
        If grd_staff.Rows.Count > 0 Then
            ' Check if the current row is selected (not null)
            If grd_staff.CurrentRow IsNot Nothing Then
                Dim current_row As Integer = grd_staff.CurrentRow.Index

                ' Check and assign values, ensuring that DBNull is handled
                current_code = If(IsDBNull(grd_staff(0, current_row).Value), "", grd_staff(0, current_row).Value)
                txt_id.Text = current_code

                txt_name.Text = If(IsDBNull(grd_staff(1, current_row).Value), "", grd_staff(1, current_row).Value)
                txt_position.Text = If(IsDBNull(grd_staff(2, current_row).Value), "", grd_staff(2, current_row).Value)
            End If
        Else
            ' Clear fields if there are no rows
            clear_fields()
        End If

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_code()

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFFS_A208749 SET FLD_STAFFS_NAME='" & txt_name.Text & "',  FLD_STAFFS_POSITION='" & txt_position.Text & "' WHERE FLD_STAFFS_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFFS_A208749 WHERE FLD_STAFFS_ID='" & current_code & "'")

            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_modify_a208749.Show()

        Me.Hide()

    End Sub


End Class