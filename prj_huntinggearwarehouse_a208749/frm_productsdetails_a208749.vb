Public Class frm_productsdetails_a208749

    Dim current_code As String
    Private Sub frm_productsdetails_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A208749"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)

    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A208749 WHERE FLD_PRODUCT_ID='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_weight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_UNIT")

        Try
            pic_products.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_products.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try


    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A208749"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

    End Sub

    Public Sub refresh_list_id()
        ' Reload the product IDs from the database
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A208749"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        ' Set the DataSource of the ListBox to the new data
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"
    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_weight.Text = ""
        txt_quantity.Text = ""

    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_id.MouseClick

        refresh_text(lst_id.Text)

    End Sub

    Public Sub release_product_image(ByVal product_id As String)
        Dim image_path As String = "pictures\" & product_id & ".jpg"
        If pic_products.Image IsNot Nothing Then
            pic_products.Image.Dispose()
            pic_products.Image = Nothing
        End If
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs)

        frm_insertproducts_a208749.Show()

        Me.Hide()


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs)

        run_sql_command("UPDATE TBL_PRODUCTS_A208749 SET FLD_PRODUCT_NAME='" & txt_name.Text & "',  FLD_PRICE=" & txt_price.Text & ",FLD_BRAND='" & txt_brand.Text & "',FLD_TYPE='" & txt_type.Text & "',FLD_WEIGHT=" & txt_weight.Text & ",FLD_UNIT=" & txt_quantity.Text & " WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the products """ & current_code & """.")

        refresh_grid()
        clear_fields()

    End Sub


    Private Sub btn_insert_Click_1(sender As Object, e As EventArgs) Handles btn_insert.Click

        frm_insertproducts_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click

        frm_updateproducts_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a208749.Show()

        Me.Hide()

    End Sub


End Class