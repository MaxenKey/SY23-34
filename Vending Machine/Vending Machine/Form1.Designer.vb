<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dollarpb = New System.Windows.Forms.PictureBox()
        Me.quarterpb = New System.Windows.Forms.PictureBox()
        Me.dimepb = New System.Windows.Forms.PictureBox()
        Me.nickelpb = New System.Windows.Forms.PictureBox()
        Me.Product_control1 = New Vending_Machine.product_control()
        Me.Product_control2 = New Vending_Machine.product_control()
        Me.Product_control3 = New Vending_Machine.product_control()
        Me.Product_control4 = New Vending_Machine.product_control()
        Me.Product_control5 = New Vending_Machine.product_control()
        Me.Product_control6 = New Vending_Machine.product_control()
        Me.Product_control7 = New Vending_Machine.product_control()
        Me.Product_control8 = New Vending_Machine.product_control()
        Me.Product_control9 = New Vending_Machine.product_control()
        Me.Product_control10 = New Vending_Machine.product_control()
        Me.Product_control11 = New Vending_Machine.product_control()
        Me.Product_control12 = New Vending_Machine.product_control()
        Me.Product_control13 = New Vending_Machine.product_control()
        Me.Product_control14 = New Vending_Machine.product_control()
        Me.Product_control15 = New Vending_Machine.product_control()
        Me.Product_control16 = New Vending_Machine.product_control()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextbox = New System.Windows.Forms.TextBox()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Vending_Machine.My.Resources.Resources.dollar
        Me.Button1.Location = New System.Drawing.Point(573, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dollars"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Image = Global.Vending_Machine.My.Resources.Resources.quarter
        Me.Button2.Location = New System.Drawing.Point(690, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 85)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Quarters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Image = Global.Vending_Machine.My.Resources.Resources.nickel
        Me.Button3.Location = New System.Drawing.Point(573, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 85)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nickels"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Image = Global.Vending_Machine.My.Resources.Resources.dime
        Me.Button4.Location = New System.Drawing.Point(690, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 75)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Dimes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalLabel.Location = New System.Drawing.Point(696, 378)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(69, 28)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "Label1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(683, 409)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dollarpb
        '
        Me.dollarpb.Image = Global.Vending_Machine.My.Resources.Resources.download__4_
        Me.dollarpb.Location = New System.Drawing.Point(683, 295)
        Me.dollarpb.Name = "dollarpb"
        Me.dollarpb.Size = New System.Drawing.Size(112, 65)
        Me.dollarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarpb.TabIndex = 6
        Me.dollarpb.TabStop = False
        Me.dollarpb.Visible = False
        '
        'quarterpb
        '
        Me.quarterpb.Image = Global.Vending_Machine.My.Resources.Resources.quarter1
        Me.quarterpb.Location = New System.Drawing.Point(683, 218)
        Me.quarterpb.Name = "quarterpb"
        Me.quarterpb.Size = New System.Drawing.Size(112, 71)
        Me.quarterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quarterpb.TabIndex = 7
        Me.quarterpb.TabStop = False
        Me.quarterpb.Visible = False
        '
        'dimepb
        '
        Me.dimepb.Image = Global.Vending_Machine.My.Resources.Resources.dime1
        Me.dimepb.Location = New System.Drawing.Point(565, 288)
        Me.dimepb.Name = "dimepb"
        Me.dimepb.Size = New System.Drawing.Size(112, 72)
        Me.dimepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimepb.TabIndex = 8
        Me.dimepb.TabStop = False
        Me.dimepb.Visible = False
        '
        'nickelpb
        '
        Me.nickelpb.Image = CType(resources.GetObject("nickelpb.Image"), System.Drawing.Image)
        Me.nickelpb.Location = New System.Drawing.Point(565, 366)
        Me.nickelpb.Name = "nickelpb"
        Me.nickelpb.Size = New System.Drawing.Size(112, 72)
        Me.nickelpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelpb.TabIndex = 9
        Me.nickelpb.TabStop = False
        Me.nickelpb.Visible = False
        '
        'Product_control1
        '
        Me.Product_control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control1.Location = New System.Drawing.Point(12, 12)
        Me.Product_control1.Name = "Product_control1"
        Me.Product_control1.productcount = 7
        Me.Product_control1.productID = "A1"
        Me.Product_control1.productpicture = Global.Vending_Machine.My.Resources.Resources.download__5_
        Me.Product_control1.ProductPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Product_control1.Size = New System.Drawing.Size(110, 104)
        Me.Product_control1.TabIndex = 10
        '
        'Product_control2
        '
        Me.Product_control2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control2.Location = New System.Drawing.Point(128, 12)
        Me.Product_control2.Name = "Product_control2"
        Me.Product_control2.productcount = 4
        Me.Product_control2.productID = "A2"
        Me.Product_control2.productpicture = Global.Vending_Machine.My.Resources.Resources.download__6_
        Me.Product_control2.ProductPrice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.Product_control2.Size = New System.Drawing.Size(112, 104)
        Me.Product_control2.TabIndex = 11
        '
        'Product_control3
        '
        Me.Product_control3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control3.Location = New System.Drawing.Point(246, 12)
        Me.Product_control3.Name = "Product_control3"
        Me.Product_control3.productcount = 6
        Me.Product_control3.productID = "A3"
        Me.Product_control3.productpicture = Global.Vending_Machine.My.Resources.Resources.download__7_
        Me.Product_control3.ProductPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Product_control3.Size = New System.Drawing.Size(115, 104)
        Me.Product_control3.TabIndex = 12
        '
        'Product_control4
        '
        Me.Product_control4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control4.Location = New System.Drawing.Point(367, 12)
        Me.Product_control4.Name = "Product_control4"
        Me.Product_control4.productcount = 3
        Me.Product_control4.productID = "A4"
        Me.Product_control4.productpicture = Global.Vending_Machine.My.Resources.Resources.download__9_
        Me.Product_control4.ProductPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Product_control4.Size = New System.Drawing.Size(111, 104)
        Me.Product_control4.TabIndex = 13
        '
        'Product_control5
        '
        Me.Product_control5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control5.Location = New System.Drawing.Point(12, 122)
        Me.Product_control5.Name = "Product_control5"
        Me.Product_control5.productcount = 4
        Me.Product_control5.productID = "B1"
        Me.Product_control5.productpicture = Global.Vending_Machine.My.Resources.Resources.images__4_
        Me.Product_control5.ProductPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_control5.Size = New System.Drawing.Size(110, 99)
        Me.Product_control5.TabIndex = 14
        '
        'Product_control6
        '
        Me.Product_control6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control6.Location = New System.Drawing.Point(128, 122)
        Me.Product_control6.Name = "Product_control6"
        Me.Product_control6.productcount = 2
        Me.Product_control6.productID = "B2"
        Me.Product_control6.productpicture = Global.Vending_Machine.My.Resources.Resources.download__10_
        Me.Product_control6.ProductPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Product_control6.Size = New System.Drawing.Size(112, 99)
        Me.Product_control6.TabIndex = 15
        '
        'Product_control7
        '
        Me.Product_control7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control7.Location = New System.Drawing.Point(246, 122)
        Me.Product_control7.Name = "Product_control7"
        Me.Product_control7.productcount = 5
        Me.Product_control7.productID = "B3"
        Me.Product_control7.productpicture = Global.Vending_Machine.My.Resources.Resources.download__11_
        Me.Product_control7.ProductPrice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Product_control7.Size = New System.Drawing.Size(115, 99)
        Me.Product_control7.TabIndex = 16
        '
        'Product_control8
        '
        Me.Product_control8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control8.Location = New System.Drawing.Point(367, 122)
        Me.Product_control8.Name = "Product_control8"
        Me.Product_control8.productcount = 6
        Me.Product_control8.productID = "B4"
        Me.Product_control8.productpicture = Global.Vending_Machine.My.Resources.Resources.download__12_
        Me.Product_control8.ProductPrice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Product_control8.Size = New System.Drawing.Size(111, 99)
        Me.Product_control8.TabIndex = 17
        '
        'Product_control9
        '
        Me.Product_control9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control9.Location = New System.Drawing.Point(12, 227)
        Me.Product_control9.Name = "Product_control9"
        Me.Product_control9.productcount = 7
        Me.Product_control9.productID = "C1"
        Me.Product_control9.productpicture = Global.Vending_Machine.My.Resources.Resources.images__2_
        Me.Product_control9.ProductPrice = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.Product_control9.Size = New System.Drawing.Size(110, 99)
        Me.Product_control9.TabIndex = 18
        '
        'Product_control10
        '
        Me.Product_control10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control10.Location = New System.Drawing.Point(128, 227)
        Me.Product_control10.Name = "Product_control10"
        Me.Product_control10.productcount = 7
        Me.Product_control10.productID = "C2"
        Me.Product_control10.productpicture = Global.Vending_Machine.My.Resources.Resources.images1
        Me.Product_control10.ProductPrice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Product_control10.Size = New System.Drawing.Size(112, 99)
        Me.Product_control10.TabIndex = 19
        '
        'Product_control11
        '
        Me.Product_control11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control11.Location = New System.Drawing.Point(246, 227)
        Me.Product_control11.Name = "Product_control11"
        Me.Product_control11.productcount = 9
        Me.Product_control11.productID = "C3"
        Me.Product_control11.productpicture = Global.Vending_Machine.My.Resources.Resources.images2
        Me.Product_control11.ProductPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Product_control11.Size = New System.Drawing.Size(115, 99)
        Me.Product_control11.TabIndex = 20
        '
        'Product_control12
        '
        Me.Product_control12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control12.Location = New System.Drawing.Point(367, 227)
        Me.Product_control12.Name = "Product_control12"
        Me.Product_control12.productcount = 8
        Me.Product_control12.productID = "C4"
        Me.Product_control12.productpicture = Global.Vending_Machine.My.Resources.Resources.download__13_
        Me.Product_control12.ProductPrice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Product_control12.Size = New System.Drawing.Size(111, 99)
        Me.Product_control12.TabIndex = 21
        '
        'Product_control13
        '
        Me.Product_control13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control13.Location = New System.Drawing.Point(12, 332)
        Me.Product_control13.Name = "Product_control13"
        Me.Product_control13.productcount = 4
        Me.Product_control13.productID = "D1"
        Me.Product_control13.productpicture = Global.Vending_Machine.My.Resources.Resources.images__5_
        Me.Product_control13.ProductPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Product_control13.Size = New System.Drawing.Size(110, 95)
        Me.Product_control13.TabIndex = 22
        '
        'Product_control14
        '
        Me.Product_control14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control14.Location = New System.Drawing.Point(128, 332)
        Me.Product_control14.Name = "Product_control14"
        Me.Product_control14.productcount = 5
        Me.Product_control14.productID = "D2"
        Me.Product_control14.productpicture = Global.Vending_Machine.My.Resources.Resources.images__1_
        Me.Product_control14.ProductPrice = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.Product_control14.Size = New System.Drawing.Size(112, 95)
        Me.Product_control14.TabIndex = 23
        '
        'Product_control15
        '
        Me.Product_control15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control15.Location = New System.Drawing.Point(246, 332)
        Me.Product_control15.Name = "Product_control15"
        Me.Product_control15.productcount = 2
        Me.Product_control15.productID = "D3"
        Me.Product_control15.productpicture = Global.Vending_Machine.My.Resources.Resources.images__6_
        Me.Product_control15.ProductPrice = New Decimal(New Integer() {75, 0, 0, 131072})
        Me.Product_control15.Size = New System.Drawing.Size(115, 95)
        Me.Product_control15.TabIndex = 24
        '
        'Product_control16
        '
        Me.Product_control16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_control16.Location = New System.Drawing.Point(364, 332)
        Me.Product_control16.Name = "Product_control16"
        Me.Product_control16.productcount = 3
        Me.Product_control16.productID = "D4"
        Me.Product_control16.productpicture = Global.Vending_Machine.My.Resources.Resources.images__3_
        Me.Product_control16.ProductPrice = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.Product_control16.Size = New System.Drawing.Size(114, 95)
        Me.Product_control16.TabIndex = 25
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(507, 178)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 29)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTextbox
        '
        Me.IDTextbox.Location = New System.Drawing.Point(495, 213)
        Me.IDTextbox.Name = "IDTextbox"
        Me.IDTextbox.Size = New System.Drawing.Size(125, 27)
        Me.IDTextbox.TabIndex = 27
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(187, 443)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(90, 62)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPictureBox.TabIndex = 28
        Me.ProductPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.IDTextbox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Product_control16)
        Me.Controls.Add(Me.Product_control15)
        Me.Controls.Add(Me.Product_control14)
        Me.Controls.Add(Me.Product_control13)
        Me.Controls.Add(Me.Product_control12)
        Me.Controls.Add(Me.Product_control11)
        Me.Controls.Add(Me.Product_control10)
        Me.Controls.Add(Me.Product_control9)
        Me.Controls.Add(Me.Product_control8)
        Me.Controls.Add(Me.Product_control7)
        Me.Controls.Add(Me.Product_control6)
        Me.Controls.Add(Me.Product_control5)
        Me.Controls.Add(Me.Product_control4)
        Me.Controls.Add(Me.Product_control3)
        Me.Controls.Add(Me.Product_control2)
        Me.Controls.Add(Me.Product_control1)
        Me.Controls.Add(Me.nickelpb)
        Me.Controls.Add(Me.dimepb)
        Me.Controls.Add(Me.quarterpb)
        Me.Controls.Add(Me.dollarpb)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents dollarpb As PictureBox
    Friend WithEvents quarterpb As PictureBox
    Friend WithEvents dimepb As PictureBox
    Friend WithEvents nickelpb As PictureBox
    Friend WithEvents Product_control1 As product_control
    Friend WithEvents Product_control2 As product_control
    Friend WithEvents Product_control3 As product_control
    Friend WithEvents Product_control4 As product_control
    Friend WithEvents Product_control5 As product_control
    Friend WithEvents Product_control6 As product_control
    Friend WithEvents Product_control7 As product_control
    Friend WithEvents Product_control8 As product_control
    Friend WithEvents Product_control9 As product_control
    Friend WithEvents Product_control10 As product_control
    Friend WithEvents Product_control11 As product_control
    Friend WithEvents Product_control12 As product_control
    Friend WithEvents Product_control13 As product_control
    Friend WithEvents Product_control14 As product_control
    Friend WithEvents Product_control15 As product_control
    Friend WithEvents Product_control16 As product_control
    Friend WithEvents Button6 As Button
    Friend WithEvents IDTextbox As TextBox
    Friend WithEvents ProductPictureBox As PictureBox
End Class
