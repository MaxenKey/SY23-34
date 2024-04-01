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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NormalUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NewspaperUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.GlassUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IceUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.StoneUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.label7 = New System.Windows.Forms.Label()
        Me.CurrentTotal1 = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BuyButton1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NormalUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewspaperUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlassUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoneUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ChessBoardsSolo.My.Resources.Resources.default1
        Me.PictureBox1.Location = New System.Drawing.Point(88, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ChessBoardsSolo.My.Resources.Resources.ice_board
        Me.PictureBox2.Location = New System.Drawing.Point(310, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ChessBoardsSolo.My.Resources.Resources.glass_board
        Me.PictureBox3.Location = New System.Drawing.Point(88, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ChessBoardsSolo.My.Resources.Resources.stone_board
        Me.PictureBox4.Location = New System.Drawing.Point(310, 306)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ChessBoardsSolo.My.Resources.Resources.newspaper_board
        Me.PictureBox5.Location = New System.Drawing.Point(88, 306)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "$130.50"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "$142.50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "$145.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "$150.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "$200.00"
        '
        'NormalUpDown
        '
        Me.NormalUpDown.Location = New System.Drawing.Point(88, 241)
        Me.NormalUpDown.Name = "NormalUpDown"
        Me.NormalUpDown.Size = New System.Drawing.Size(150, 27)
        Me.NormalUpDown.TabIndex = 10
        '
        'NewspaperUpDown2
        '
        Me.NewspaperUpDown2.Location = New System.Drawing.Point(88, 374)
        Me.NewspaperUpDown2.Name = "NewspaperUpDown2"
        Me.NewspaperUpDown2.Size = New System.Drawing.Size(150, 27)
        Me.NewspaperUpDown2.TabIndex = 11
        '
        'GlassUpDown
        '
        Me.GlassUpDown.Location = New System.Drawing.Point(88, 119)
        Me.GlassUpDown.Name = "GlassUpDown"
        Me.GlassUpDown.Size = New System.Drawing.Size(150, 27)
        Me.GlassUpDown.TabIndex = 12
        '
        'IceUpDown4
        '
        Me.IceUpDown4.Location = New System.Drawing.Point(310, 119)
        Me.IceUpDown4.Name = "IceUpDown4"
        Me.IceUpDown4.Size = New System.Drawing.Size(150, 27)
        Me.IceUpDown4.TabIndex = 13
        '
        'StoneUpDown6
        '
        Me.StoneUpDown6.Location = New System.Drawing.Point(310, 374)
        Me.StoneUpDown6.Name = "StoneUpDown6"
        Me.StoneUpDown6.Size = New System.Drawing.Size(150, 27)
        Me.StoneUpDown6.TabIndex = 15
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label7.Location = New System.Drawing.Point(310, 194)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(261, 54)
        Me.label7.TabIndex = 16
        Me.label7.Text = "Current Total:"
        '
        'CurrentTotal1
        '
        Me.CurrentTotal1.AutoSize = True
        Me.CurrentTotal1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CurrentTotal1.Location = New System.Drawing.Point(568, 194)
        Me.CurrentTotal1.Name = "CurrentTotal1"
        Me.CurrentTotal1.Size = New System.Drawing.Size(120, 54)
        Me.CurrentTotal1.TabIndex = 17
        Me.CurrentTotal1.Text = "$0.00"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(667, 374)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(94, 29)
        Me.NextButton.TabIndex = 18
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BuyButton1
        '
        Me.BuyButton1.Location = New System.Drawing.Point(555, 374)
        Me.BuyButton1.Name = "BuyButton1"
        Me.BuyButton1.Size = New System.Drawing.Size(94, 29)
        Me.BuyButton1.TabIndex = 19
        Me.BuyButton1.Text = "Buy"
        Me.BuyButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BuyButton1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.CurrentTotal1)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.StoneUpDown6)
        Me.Controls.Add(Me.IceUpDown4)
        Me.Controls.Add(Me.GlassUpDown)
        Me.Controls.Add(Me.NewspaperUpDown2)
        Me.Controls.Add(Me.NormalUpDown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NormalUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewspaperUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlassUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoneUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NormalUpDown As NumericUpDown
    Friend WithEvents NewspaperUpDown2 As NumericUpDown
    Friend WithEvents GlassUpDown As NumericUpDown
    Friend WithEvents IceUpDown4 As NumericUpDown
    Friend WithEvents StoneUpDown6 As NumericUpDown
    Friend WithEvents label7 As Label
    Friend WithEvents CurrentTotal1 As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents BuyButton1 As Button
End Class
