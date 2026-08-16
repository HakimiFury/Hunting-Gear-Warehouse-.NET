Public Class frm_updateproducts_a208749
    Dim current_code As String
    Private Sub frm_updateproducts_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        cmb_type.Items.Add("TOOLS")
        cmb_type.Items.Add("CLOTHING")
        cmb_type.Items.Add("FIREARMS")
        cmb_type.Items.Add("AMMO")
        cmb_type.Items.Add("BAGPACK")

        refresh_grid()

        get_current_code()

    End Sub

    Public Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A208749"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

        Try
            pic_products.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_products.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try


    End Sub



    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_weight.Text = ""
        txt_quantity.Text = ""
        cmb_type.SelectedIndex = -1 ' Clear ComboBox selection

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_product.CurrentRow.Index

        current_code = grd_product(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value

        Dim productType As String = grd_product(4, current_row).Value.ToString()
        If cmb_type.Items.Contains(productType) Then
            cmb_type.SelectedItem = productType
        Else
            cmb_type.SelectedIndex = -1 ' Clear selection if not found
        End If

        txt_weight.Text = grd_product(5, current_row).Value
        txt_quantity.Text = grd_product(6, current_row).Value


    End Sub


    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCTS_A208749 SET FLD_PRODUCT_NAME='" & txt_name.Text & "',  FLD_PRICE=" & txt_price.Text & ", FLD_BRAND='" & txt_brand.Text & "',FLD_TYPE='" & cmb_type.SelectedItem.ToString() & "',FLD_WEIGHT=" & txt_weight.Text & ",FLD_UNIT=" & txt_quantity.Text & " WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        Dim mainForm As frm_products_a208749 = CType(Application.OpenForms("frm_products_a208749"), frm_products_a208749)
        If mainForm IsNot Nothing Then
            mainForm.refresh_grid()  ' Refresh the grid in frm_products_a208749
        End If

        refresh_grid()
        clear_fields()
        get_current_code()

        frm_productsdetails_a208749.refresh_list_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            Try
                ' Release the image resource if it's being displayed
                Dim detailsForm As frm_productsdetails_a208749 = CType(Application.OpenForms("frm_productsdetails_a208749"), frm_productsdetails_a208749)
                If detailsForm IsNot Nothing Then
                    detailsForm.release_product_image(current_code)  ' Release the image in frm_productsdetails_a208749
                End If

                If pic_products.Image IsNot Nothing Then
                    pic_products.Image.Dispose()
                    pic_products.Image = Nothing
                End If

                ' Delete the database record
                run_sql_command("DELETE FROM TBL_PRODUCTS_A208749 WHERE FLD_PRODUCT_ID='" & current_code & "'")

                ' Delete the associated image file
                Dim image_path As String = "pictures\" & current_code & ".jpg"
                If My.Computer.FileSystem.FileExists(image_path) Then
                    My.Computer.FileSystem.DeleteFile(image_path)
                End If

                ' Notify the user and refresh UI
                Beep()
                MsgBox("The product """ & current_code & """ has been successfully deleted, along with its associated image.")

                refresh_grid()
                clear_fields()
                get_current_code()
            Catch ex As Exception
                ' Handle errors gracefully
                MsgBox("An error occurred while deleting the product or its image:" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        frm_productsdetails_a208749.refresh_list_id()
    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_modify_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub pic_products_Click(sender As Object, e As EventArgs) Handles pic_products.Click

    End Sub


End Class