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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Clickercontrol4 = New Feb5.clickercontrol()
        Me.Clickercontrol5 = New Feb5.clickercontrol()
        Me.Clickercontrol6 = New Feb5.clickercontrol()
        Me.SuspendLayout()
        '
        'Clickercontrol4
        '
        Me.Clickercontrol4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clickercontrol4.increment = 1
        Me.Clickercontrol4.Location = New System.Drawing.Point(67, 12)
        Me.Clickercontrol4.Name = "Clickercontrol4"
        Me.Clickercontrol4.Size = New System.Drawing.Size(153, 125)
        Me.Clickercontrol4.TabIndex = 0
        '
        'Clickercontrol5
        '
        Me.Clickercontrol5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clickercontrol5.increment = 1
        Me.Clickercontrol5.Location = New System.Drawing.Point(211, 193)
        Me.Clickercontrol5.Name = "Clickercontrol5"
        Me.Clickercontrol5.Size = New System.Drawing.Size(146, 125)
        Me.Clickercontrol5.TabIndex = 1
        '
        'Clickercontrol6
        '
        Me.Clickercontrol6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clickercontrol6.increment = 1
        Me.Clickercontrol6.Location = New System.Drawing.Point(368, 12)
        Me.Clickercontrol6.Name = "Clickercontrol6"
        Me.Clickercontrol6.Size = New System.Drawing.Size(172, 125)
        Me.Clickercontrol6.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clickercontrol6)
        Me.Controls.Add(Me.Clickercontrol5)
        Me.Controls.Add(Me.Clickercontrol4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Clickercontrol1 As clickercontrol
    Friend WithEvents Clickercontrol2 As clickercontrol
    Friend WithEvents Clickercontrol3 As clickercontrol
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Clickercontrol4 As clickercontrol
    Friend WithEvents Clickercontrol5 As clickercontrol
    Friend WithEvents Clickercontrol6 As clickercontrol
End Class
