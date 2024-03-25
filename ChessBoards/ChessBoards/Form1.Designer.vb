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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StoneBoard = New System.Windows.Forms.PictureBox()
        Me.NewspaperBoard = New System.Windows.Forms.PictureBox()
        Me.IceBoard = New System.Windows.Forms.PictureBox()
        Me.SkyBoard = New System.Windows.Forms.PictureBox()
        Me.DefaultBoard = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.StoneBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewspaperBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(318, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chess Boards"
        '
        'StoneBoard
        '
        Me.StoneBoard.Image = Global.ChessBoards.My.Resources.Resources.stone_board
        Me.StoneBoard.Location = New System.Drawing.Point(67, 104)
        Me.StoneBoard.Name = "StoneBoard"
        Me.StoneBoard.Size = New System.Drawing.Size(205, 147)
        Me.StoneBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StoneBoard.TabIndex = 1
        Me.StoneBoard.TabStop = False
        '
        'NewspaperBoard
        '
        Me.NewspaperBoard.Image = Global.ChessBoards.My.Resources.Resources.newspaper_board
        Me.NewspaperBoard.Location = New System.Drawing.Point(308, 275)
        Me.NewspaperBoard.Name = "NewspaperBoard"
        Me.NewspaperBoard.Size = New System.Drawing.Size(205, 147)
        Me.NewspaperBoard.TabIndex = 2
        Me.NewspaperBoard.TabStop = False
        '
        'IceBoard
        '
        Me.IceBoard.Image = Global.ChessBoards.My.Resources.Resources.ice_board
        Me.IceBoard.Location = New System.Drawing.Point(67, 275)
        Me.IceBoard.Name = "IceBoard"
        Me.IceBoard.Size = New System.Drawing.Size(205, 147)
        Me.IceBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IceBoard.TabIndex = 3
        Me.IceBoard.TabStop = False
        '
        'SkyBoard
        '
        Me.SkyBoard.Image = Global.ChessBoards.My.Resources.Resources.glass_board
        Me.SkyBoard.Location = New System.Drawing.Point(546, 275)
        Me.SkyBoard.Name = "SkyBoard"
        Me.SkyBoard.Size = New System.Drawing.Size(205, 147)
        Me.SkyBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SkyBoard.TabIndex = 4
        Me.SkyBoard.TabStop = False
        '
        'DefaultBoard
        '
        Me.DefaultBoard.Image = Global.ChessBoards.My.Resources.Resources._default
        Me.DefaultBoard.Location = New System.Drawing.Point(546, 104)
        Me.DefaultBoard.Name = "DefaultBoard"
        Me.DefaultBoard.Size = New System.Drawing.Size(205, 147)
        Me.DefaultBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DefaultBoard.TabIndex = 5
        Me.DefaultBoard.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(348, 157)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(150, 27)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.DefaultBoard)
        Me.Controls.Add(Me.SkyBoard)
        Me.Controls.Add(Me.IceBoard)
        Me.Controls.Add(Me.NewspaperBoard)
        Me.Controls.Add(Me.StoneBoard)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StoneBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewspaperBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StoneBoard As PictureBox
    Friend WithEvents NewspaperBoard As PictureBox
    Friend WithEvents IceBoard As PictureBox
    Friend WithEvents SkyBoard As PictureBox
    Friend WithEvents DefaultBoard As PictureBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
