<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_updateproducts_a208749
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
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_desc8 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
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
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.pic_products = New System.Windows.Forms.PictureBox()
        Me.mainPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(268, 427)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(340, 25)
        Me.cmb_type.TabIndex = 160
        '
        'lbl_desc8
        '
        Me.lbl_desc8.AutoSize = True
        Me.lbl_desc8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc8.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc8.Location = New System.Drawing.Point(130, 515)
        Me.lbl_desc8.Name = "lbl_desc8"
        Me.lbl_desc8.Size = New System.Drawing.Size(207, 21)
        Me.lbl_desc8.TabIndex = 157
        Me.lbl_desc8.Text = "Click here after edit the data."
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_delete.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.HotPink
        Me.btn_delete.Location = New System.Drawing.Point(16, 538)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(101, 30)
        Me.btn_delete.TabIndex = 156
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_update.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.HotPink
        Me.btn_update.Location = New System.Drawing.Point(16, 506)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(101, 30)
        Me.btn_update.TabIndex = 154
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'lbl_desc9
        '
        Me.lbl_desc9.AutoSize = True
        Me.lbl_desc9.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc9.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc9.Location = New System.Drawing.Point(132, 543)
        Me.lbl_desc9.Name = "lbl_desc9"
        Me.lbl_desc9.Size = New System.Drawing.Size(263, 21)
        Me.lbl_desc9.TabIndex = 153
        Me.lbl_desc9.Text = "Click here to delete selected product."
        '
        'lbl_desc5
        '
        Me.lbl_desc5.AutoSize = True
        Me.lbl_desc5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc5.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc5.Location = New System.Drawing.Point(132, 428)
        Me.lbl_desc5.Name = "lbl_desc5"
        Me.lbl_desc5.Size = New System.Drawing.Size(103, 21)
        Me.lbl_desc5.TabIndex = 152
        Me.lbl_desc5.Text = "Product Type:"
        '
        'lbl_desc7
        '
        Me.lbl_desc7.AutoSize = True
        Me.lbl_desc7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc7.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc7.Location = New System.Drawing.Point(130, 486)
        Me.lbl_desc7.Name = "lbl_desc7"
        Me.lbl_desc7.Size = New System.Drawing.Size(131, 21)
        Me.lbl_desc7.TabIndex = 151
        Me.lbl_desc7.Text = "Product Quantity:"
        '
        'lbl_desc4
        '
        Me.lbl_desc4.AutoSize = True
        Me.lbl_desc4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc4.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc4.Location = New System.Drawing.Point(132, 398)
        Me.lbl_desc4.Name = "lbl_desc4"
        Me.lbl_desc4.Size = New System.Drawing.Size(112, 21)
        Me.lbl_desc4.TabIndex = 150
        Me.lbl_desc4.Text = "Product Brand:"
        '
        'lbl_desc6
        '
        Me.lbl_desc6.AutoSize = True
        Me.lbl_desc6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc6.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc6.Location = New System.Drawing.Point(130, 454)
        Me.lbl_desc6.Name = "lbl_desc6"
        Me.lbl_desc6.Size = New System.Drawing.Size(120, 21)
        Me.lbl_desc6.TabIndex = 149
        Me.lbl_desc6.Text = "Product Weight:"
        '
        'lbl_desc1
        '
        Me.lbl_desc1.AutoSize = True
        Me.lbl_desc1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc1.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc1.Location = New System.Drawing.Point(132, 308)
        Me.lbl_desc1.Name = "lbl_desc1"
        Me.lbl_desc1.Size = New System.Drawing.Size(86, 21)
        Me.lbl_desc1.TabIndex = 148
        Me.lbl_desc1.Text = "Product ID:"
        '
        'lbl_desc2
        '
        Me.lbl_desc2.AutoSize = True
        Me.lbl_desc2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc2.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc2.Location = New System.Drawing.Point(132, 338)
        Me.lbl_desc2.Name = "lbl_desc2"
        Me.lbl_desc2.Size = New System.Drawing.Size(113, 21)
        Me.lbl_desc2.TabIndex = 147
        Me.lbl_desc2.Text = "Product Name:"
        '
        'lbl_desc3
        '
        Me.lbl_desc3.AutoSize = True
        Me.lbl_desc3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc3.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc3.Location = New System.Drawing.Point(132, 368)
        Me.lbl_desc3.Name = "lbl_desc3"
        Me.lbl_desc3.Size = New System.Drawing.Size(105, 21)
        Me.lbl_desc3.TabIndex = 146
        Me.lbl_desc3.Text = "Product Price:"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(268, 486)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(340, 25)
        Me.txt_quantity.TabIndex = 145
        '
        'txt_weight
        '
        Me.txt_weight.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.Location = New System.Drawing.Point(268, 457)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(340, 25)
        Me.txt_weight.TabIndex = 144
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(268, 398)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(340, 25)
        Me.txt_brand.TabIndex = 143
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(268, 368)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(340, 25)
        Me.txt_price.TabIndex = 142
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(268, 338)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(340, 25)
        Me.txt_name.TabIndex = 141
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(268, 308)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(340, 25)
        Me.txt_id.TabIndex = 140
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_date.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_date.Location = New System.Drawing.Point(543, 13)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(106, 24)
        Me.lbl_date.TabIndex = 137
        Me.lbl_date.Text = "Date.now"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.HotPink
        Me.btn_back.Location = New System.Drawing.Point(16, 569)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(101, 30)
        Me.btn_back.TabIndex = 135
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(348, 58)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.Size = New System.Drawing.Size(452, 242)
        Me.grd_product.TabIndex = 134
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_product.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_product.Location = New System.Drawing.Point(129, 13)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(261, 30)
        Me.lbl_product.TabIndex = 133
        Me.lbl_product.Text = "Update Product Data"
        '
        'pic_products
        '
        Me.pic_products.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources._2a75b835f5504557c1e7500b796538d4
        Me.pic_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_products.Location = New System.Drawing.Point(164, 67)
        Me.pic_products.Name = "pic_products"
        Me.pic_products.Size = New System.Drawing.Size(138, 198)
        Me.pic_products.TabIndex = 161
        Me.pic_products.TabStop = False
        '
        'mainPicture
        '
        Me.mainPicture.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources.mainlogo
        Me.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainPicture.Location = New System.Drawing.Point(0, -14)
        Me.mainPicture.Name = "mainPicture"
        Me.mainPicture.Size = New System.Drawing.Size(123, 75)
        Me.mainPicture.TabIndex = 138
        Me.mainPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(123, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(677, 75)
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox2.Location = New System.Drawing.Point(123, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(677, 565)
        Me.PictureBox2.TabIndex = 155
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources._2a75b835f5504557c1e7500b796538d4
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(164, 67)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(138, 198)
        Me.PictureBox3.TabIndex = 162
        Me.PictureBox3.TabStop = False
        '
        'frm_updateproducts_a208749
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 611)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pic_products)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.lbl_desc8)
        Me.Controls.Add(Me.btn_delete)
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
        Me.Controls.Add(Me.mainPicture)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_product)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frm_updateproducts_a208749"
        Me.Text = "Update Product Form"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_desc8 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
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
    Friend WithEvents mainPicture As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_product As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pic_products As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
