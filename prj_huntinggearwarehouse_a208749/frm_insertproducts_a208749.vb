Public Class frm_insertproducts_a208749

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproducts_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A208749")

        cmb_type.Items.Add("TOOLS")
        cmb_type.Items.Add("CLOTHING")
        cmb_type.Items.Add("FIREARMS")
        cmb_type.Items.Add("AMMO")
        cmb_type.Items.Add("BAGPACK")

        txt_id.Text = generate_id()

        txt_picture.Text = defaultpicture

        pic_products.BackgroundImage = Image.FromFile(defaultpicture)

        refresh_grid()

    End Sub

    Public Sub refresh_grid()
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A208749")
    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A208749").Rows(0).Item("LASTID")

        If IsDBNull(lastid) OrElse String.IsNullOrEmpty(lastid) Then
            Return "PP001" ' Default ID for the first entry
        End If

        Dim numericPart As Integer = CInt(Mid(lastid, 3))

        Dim newNumericPart As Integer = numericPart + 1

        Dim newid As String = "PP" & newNumericPart.ToString("D3")

        Return newid
    End Function


    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click


        If String.IsNullOrWhiteSpace(txt_id.Text) OrElse
       String.IsNullOrWhiteSpace(txt_name.Text) OrElse
       String.IsNullOrWhiteSpace(txt_price.Text) OrElse
       String.IsNullOrWhiteSpace(txt_brand.Text) OrElse
       String.IsNullOrWhiteSpace(txt_weight.Text) OrElse
       String.IsNullOrWhiteSpace(txt_quantity.Text) OrElse
       String.IsNullOrWhiteSpace(txt_picture.Text) Then
            MsgBox("Please fill in all fields before submitting.")
            Exit Sub
        End If

        Dim price As Decimal
        Dim weight As Decimal
        Dim quantity As Integer

        If Not Decimal.TryParse(txt_price.Text, price) OrElse price < 0 Then
            MsgBox("Please enter a valid price (positive number).")
            Exit Sub
        End If

        If Not Decimal.TryParse(txt_weight.Text, weight) OrElse weight < 0 Then
            MsgBox("Please enter a valid weight (positive number).")
            Exit Sub
        End If

        If Not Integer.TryParse(txt_quantity.Text, quantity) OrElse quantity < 0 Then
            MsgBox("Please enter a valid quantity (positive integer).")
            Exit Sub
        End If

        If cmb_type.SelectedIndex = -1 Then
            MsgBox("Please select a product type from the dropdown before submitting.")
            Exit Sub
        End If

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A208749 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_price.Text & ", '" & txt_brand.Text & "', '" & cmb_type.SelectedItem.ToString() & "', " & txt_weight.Text & ", " & txt_quantity.Text & ")"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A208749")

            Dim mainForm As frm_products_a208749 = CType(Application.OpenForms("frm_products_a208749"), frm_products_a208749)
            If mainForm IsNot Nothing Then
                mainForm.refresh_grid()  ' Refresh the grid in frm_products_a208749
            End If

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_price.Text = ""
            txt_brand.Text = ""
            txt_weight.Text = ""
            txt_quantity.Text = ""
            txt_picture.Text = defaultpicture
            cmb_type.SelectedIndex = -1 ' Clear ComboBox selection
            pic_products.BackgroundImage = Image.FromFile(defaultpicture)

            Dim updateForm As frm_updateproducts_a208749 = CType(Application.OpenForms("frm_updateproducts_a208749"), frm_updateproducts_a208749)
            If updateForm IsNot Nothing Then
                updateForm.refresh_grid()  ' Refresh the grid in frm_updateproducts_a208749
            End If

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try

        frm_productsdetails_a208749.refresh_list_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproducts_a208749.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_modify_a208749.Show()
        Me.Hide()
    End Sub

    Private Sub grd_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellContentClick
        ' Handle cell clicks if needed
    End Sub


    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            pic_products.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Else

            MessageBox.Show("No image or pictures selected.")
        End If

    End Sub


End Class


