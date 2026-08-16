<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_insertproducts_a208749
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mainPicture = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_desc9 = New System.Windows.Forms.Label()
        Me.lbl_desc5 = New System.Windows.Forms.Label()
        Me.lbl_desc7 = New System.Windows.Forms.Label()
        Me.lbl_desc4 = New System.Windows.Forms.Label()
        Me.lbl_desc6 = New System.Windows.Forms.Label()
        Me.lbl_desc1 = New System.Windows.Forms.Label()
        Me.lbl_desc2 = New System.Windows.Forms.Label()
        Me.lbl_desc3 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.pic_products = New System.Windows.Forms.PictureBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainPicture
        '
        Me.mainPicture.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources.mainlogo
        Me.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainPicture.Location = New System.Drawing.Point(0, 0)
        Me.mainPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.mainPicture.Name = "mainPicture"
        Me.mainPicture.Size = New System.Drawing.Size(164, 92)
        Me.mainPicture.TabIndex = 26
        Me.mainPicture.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_date.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_date.Location = New System.Drawing.Point(724, 33)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(139, 32)
        Me.lbl_date.TabIndex = 25
        Me.lbl_date.Text = "Date.now"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.HotPink
        Me.btn_back.Location = New System.Drawing.Point(16, 735)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(135, 37)
        Me.btn_back.TabIndex = 23
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(164, 356)
        Me.grd_product.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.Size = New System.Drawing.Size(903, 292)
        Me.grd_product.TabIndex = 22
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_title.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_title.Location = New System.Drawing.Point(172, 27)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(303, 37)
        Me.lbl_title.TabIndex = 21
        Me.lbl_title.Text = "Insert New Product"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(164, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(903, 92)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lbl_desc9
        '
        Me.lbl_desc9.AutoSize = True
        Me.lbl_desc9.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc9.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc9.Location = New System.Drawing.Point(173, 690)
        Me.lbl_desc9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc9.Name = "lbl_desc9"
        Me.lbl_desc9.Size = New System.Drawing.Size(645, 28)
        Me.lbl_desc9.TabIndex = 123
        Me.lbl_desc9.Text = "Click here to access update products credentials or delete products form."
        '
        'lbl_desc5
        '
        Me.lbl_desc5.AutoSize = True
        Me.lbl_desc5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc5.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc5.Location = New System.Drawing.Point(419, 246)
        Me.lbl_desc5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc5.Name = "lbl_desc5"
        Me.lbl_desc5.Size = New System.Drawing.Size(131, 28)
        Me.lbl_desc5.TabIndex = 122
        Me.lbl_desc5.Text = "Product Type:"
        '
        'lbl_desc7
        '
        Me.lbl_desc7.AutoSize = True
        Me.lbl_desc7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc7.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc7.Location = New System.Drawing.Point(416, 318)
        Me.lbl_desc7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc7.Name = "lbl_desc7"
        Me.lbl_desc7.Size = New System.Drawing.Size(166, 28)
        Me.lbl_desc7.TabIndex = 121
        Me.lbl_desc7.Text = "Product Quantity:"
        '
        'lbl_desc4
        '
        Me.lbl_desc4.AutoSize = True
        Me.lbl_desc4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc4.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc4.Location = New System.Drawing.Point(419, 209)
        Me.lbl_desc4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc4.Name = "lbl_desc4"
        Me.lbl_desc4.Size = New System.Drawing.Size(141, 28)
        Me.lbl_desc4.TabIndex = 120
        Me.lbl_desc4.Text = "Product Brand:"
        '
        'lbl_desc6
        '
        Me.lbl_desc6.AutoSize = True
        Me.lbl_desc6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc6.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc6.Location = New System.Drawing.Point(416, 278)
        Me.lbl_desc6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc6.Name = "lbl_desc6"
        Me.lbl_desc6.Size = New System.Drawing.Size(153, 28)
        Me.lbl_desc6.TabIndex = 119
        Me.lbl_desc6.Text = "Product Weight:"
        '
        'lbl_desc1
        '
        Me.lbl_desc1.AutoSize = True
        Me.lbl_desc1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc1.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc1.Location = New System.Drawing.Point(419, 98)
        Me.lbl_desc1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc1.Name = "lbl_desc1"
        Me.lbl_desc1.Size = New System.Drawing.Size(109, 28)
        Me.lbl_desc1.TabIndex = 118
        Me.lbl_desc1.Text = "Product ID:"
        '
        'lbl_desc2
        '
        Me.lbl_desc2.AutoSize = True
        Me.lbl_desc2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc2.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc2.Location = New System.Drawing.Point(419, 135)
        Me.lbl_desc2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc2.Name = "lbl_desc2"
        Me.lbl_desc2.Size = New System.Drawing.Size(142, 28)
        Me.lbl_desc2.TabIndex = 117
        Me.lbl_desc2.Text = "Product Name:"
        '
        'lbl_desc3
        '
        Me.lbl_desc3.AutoSize = True
        Me.lbl_desc3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc3.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc3.Location = New System.Drawing.Point(419, 172)
        Me.lbl_desc3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc3.Name = "lbl_desc3"
        Me.lbl_desc3.Size = New System.Drawing.Size(132, 28)
        Me.lbl_desc3.TabIndex = 116
        Me.lbl_desc3.Text = "Product Price:"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(600, 318)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(452, 30)
        Me.txt_quantity.TabIndex = 115
        '
        'txt_weight
        '
        Me.txt_weight.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.Location = New System.Drawing.Point(600, 282)
        Me.txt_weight.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(452, 30)
        Me.txt_weight.TabIndex = 114
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(600, 209)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(452, 30)
        Me.txt_brand.TabIndex = 112
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(600, 172)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(452, 30)
        Me.txt_price.TabIndex = 111
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(600, 135)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(452, 30)
        Me.txt_name.TabIndex = 110
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(600, 98)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(452, 30)
        Me.txt_id.TabIndex = 109
        '
        'pic_products
        '
        Me.pic_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_products.Location = New System.Drawing.Point(179, 100)
        Me.pic_products.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_products.Name = "pic_products"
        Me.pic_products.Size = New System.Drawing.Size(184, 172)
        Me.pic_products.TabIndex = 108
        Me.pic_products.TabStop = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_update.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.HotPink
        Me.btn_update.Location = New System.Drawing.Point(16, 690)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(135, 37)
        Me.btn_update.TabIndex = 124
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox2.Location = New System.Drawing.Point(164, 91)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(903, 695)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_insert.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.HotPink
        Me.btn_insert.Location = New System.Drawing.Point(16, 646)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(135, 37)
        Me.btn_insert.TabIndex = 126
        Me.btn_insert.Text = "SUBMIT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.HotPink
        Me.Label1.Location = New System.Drawing.Point(173, 651)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 28)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Click here when the form is completed (Including image)."
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_picture.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.ForeColor = System.Drawing.Color.HotPink
        Me.btn_picture.Location = New System.Drawing.Point(179, 306)
        Me.btn_picture.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(184, 36)
        Me.btn_picture.TabIndex = 129
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'txt_picture
        '
        Me.txt_picture.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_picture.Location = New System.Drawing.Point(179, 279)
        Me.txt_picture.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(183, 30)
        Me.txt_picture.TabIndex = 130
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(600, 245)
        Me.cmb_type.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(220, 30)
        Me.cmb_type.TabIndex = 132
        '
        'frm_insertproducts_a208749
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1067, 786)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_desc9)
        Me.Controls.Add(Me.lbl_desc5)
        Me.Controls.Add(Me.lbl_desc7)
        Me.Controls.Add(Me.lbl_desc4)
        Me.Controls.Add(Me.lbl_desc6)
        Me.Controls.Add(Me.lbl_desc1)
        Me.Controls.Add(Me.lbl_desc2)
        Me.Controls.Add(Me.lbl_desc3)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.pic_products)
        Me.Controls.Add(Me.mainPicture)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_insertproducts_a208749"
        Me.Text = "Insert New Product Form"
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainPicture As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_desc9 As Label
    Friend WithEvents lbl_desc5 As Label
    Friend WithEvents lbl_desc7 As Label
    Friend WithEvents lbl_desc4 As Label
    Friend WithEvents lbl_desc6 As Label
    Friend WithEvents lbl_desc1 As Label
    Friend WithEvents lbl_desc2 As Label
    Friend WithEvents lbl_desc3 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents pic_products As PictureBox
    Friend WithEvents btn_update As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmb_type As ComboBox
End Class
