Public Class frm_updatecustomers_a208749

    Dim current_code As String
    Private Sub frm_updatecustomers_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        refresh_grid()

        get_current_code()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A208749"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""

    End Sub

    Private Sub get_current_code()

        ' Check if there are any rows in the grid
        If grd_customer.Rows.Count > 0 Then
            ' Check if the current row is selected (not null)
            If grd_customer.CurrentRow IsNot Nothing Then
                Dim current_row As Integer = grd_customer.CurrentRow.Index

                ' Check and assign values, ensuring that DBNull is handled
                current_code = If(IsDBNull(grd_customer(0, current_row).Value), "", grd_customer(0, current_row).Value)
                txt_id.Text = current_code

                txt_name.Text = If(IsDBNull(grd_customer(1, current_row).Value), "", grd_customer(1, current_row).Value)
                txt_address.Text = If(IsDBNull(grd_customer(2, current_row).Value), "", grd_customer(2, current_row).Value)
                txt_phone.Text = If(IsDBNull(grd_customer(3, current_row).Value), "", grd_customer(3, current_row).Value)
            End If
        Else
            ' Clear fields if there are no rows
            clear_fields()
        End If

    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMERS_A208749 SET FLD_CUSTOMERS_NAME='" & txt_name.Text & "',  FLD_CUSTOMERS_ADDRESS='" & txt_address.Text & "', FLD_CUSTOMERS_PHONE=" & txt_phone.Text & " WHERE FLD_CUSTOMERS_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the customer """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMERS_A208749 WHERE FLD_CUSTOMERS_ID='" & current_code & "'")

            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")

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