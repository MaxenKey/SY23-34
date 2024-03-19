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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Reelcontrol4 = New SlotMachine.reelcontrol()
        Me.Reelcontrol5 = New SlotMachine.reelcontrol()
        Me.Reelcontrol6 = New SlotMachine.reelcontrol()
        Me.LabelWin = New System.Windows.Forms.Label()
        Me.LabelAlmost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "apple.JPG")
        Me.ImageList1.Images.SetKeyName(1, "cherry.JPG")
        Me.ImageList1.Images.SetKeyName(2, "orange.JPG")
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SlotMachine.My.Resources.Resources.handle
        Me.Button1.Location = New System.Drawing.Point(24, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 109)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(511, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.Button2.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(48, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 75)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Dollars"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Image = Global.SlotMachine.My.Resources.Resources.dime
        Me.Button4.Location = New System.Drawing.Point(166, 256)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 75)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Dimes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Image = Global.SlotMachine.My.Resources.Resources.nickel
        Me.Button3.Location = New System.Drawing.Point(48, 337)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 85)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Nickels"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Image = Global.SlotMachine.My.Resources.Resources.quarter
        Me.Button5.Location = New System.Drawing.Point(166, 337)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 85)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Quarters"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(329, 311)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 20)
        Me.TotalLabel.TabIndex = 11
        '
        'Reelcontrol4
        '
        Me.Reelcontrol4.itemValue = 0
        Me.Reelcontrol4.Location = New System.Drawing.Point(310, 46)
        Me.Reelcontrol4.Name = "Reelcontrol4"
        Me.Reelcontrol4.Size = New System.Drawing.Size(153, 153)
        Me.Reelcontrol4.spinTime = 2000
        Me.Reelcontrol4.TabIndex = 12
        '
        'Reelcontrol5
        '
        Me.Reelcontrol5.itemValue = 0
        Me.Reelcontrol5.Location = New System.Drawing.Point(469, 46)
        Me.Reelcontrol5.Name = "Reelcontrol5"
        Me.Reelcontrol5.Size = New System.Drawing.Size(158, 153)
        Me.Reelcontrol5.spinTime = 2000
        Me.Reelcontrol5.TabIndex = 13
        '
        'Reelcontrol6
        '
        Me.Reelcontrol6.itemValue = 0
        Me.Reelcontrol6.Location = New System.Drawing.Point(622, 46)
        Me.Reelcontrol6.Name = "Reelcontrol6"
        Me.Reelcontrol6.Size = New System.Drawing.Size(155, 147)
        Me.Reelcontrol6.spinTime = 2000
        Me.Reelcontrol6.TabIndex = 14
        '
        'LabelWin
        '
        Me.LabelWin.AutoSize = True
        Me.LabelWin.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelWin.Location = New System.Drawing.Point(477, 294)
        Me.LabelWin.Name = "LabelWin"
        Me.LabelWin.Size = New System.Drawing.Size(150, 37)
        Me.LabelWin.TabIndex = 15
        Me.LabelWin.Text = "YOU WIN"
        Me.LabelWin.Visible = False
        '
        'LabelAlmost
        '
        Me.LabelAlmost.AutoSize = True
        Me.LabelAlmost.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelAlmost.Location = New System.Drawing.Point(495, 357)
        Me.LabelAlmost.Name = "LabelAlmost"
        Me.LabelAlmost.Size = New System.Drawing.Size(132, 37)
        Me.LabelAlmost.TabIndex = 16
        Me.LabelAlmost.Text = "Almost"
        Me.LabelAlmost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelAlmost.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SlotMachine.My.Resources.Resources.arcade
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelAlmost)
        Me.Controls.Add(Me.LabelWin)
        Me.Controls.Add(Me.Reelcontrol6)
        Me.Controls.Add(Me.Reelcontrol5)
        Me.Controls.Add(Me.Reelcontrol4)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Reelcontrol1 As reelcontrol
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Reelcontrol2 As reelcontrol
    Friend WithEvents Reelcontrol3 As reelcontrol
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Reelcontrol4 As reelcontrol
    Friend WithEvents Reelcontrol5 As reelcontrol
    Friend WithEvents Reelcontrol6 As reelcontrol
    Friend WithEvents LabelWin As Label
    Friend WithEvents LabelAlmost As Label
End Class
