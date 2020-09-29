<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pizza_1 = New System.Windows.Forms.Button()
        Me.Pizza_2 = New System.Windows.Forms.Button()
        Me.Pizza_3 = New System.Windows.Forms.Button()
        Me.Pizza_4 = New System.Windows.Forms.Button()
        Me.Pizza_5 = New System.Windows.Forms.Button()
        Me.Exit_1 = New System.Windows.Forms.Button()
        Me.MenuItems = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pizza_1
        '
        Me.Pizza_1.Location = New System.Drawing.Point(31, 406)
        Me.Pizza_1.Name = "Pizza_1"
        Me.Pizza_1.Size = New System.Drawing.Size(122, 70)
        Me.Pizza_1.TabIndex = 0
        Me.Pizza_1.Text = "Pizza!"
        Me.Pizza_1.UseVisualStyleBackColor = True
        '
        'Pizza_2
        '
        Me.Pizza_2.Location = New System.Drawing.Point(186, 406)
        Me.Pizza_2.Name = "Pizza_2"
        Me.Pizza_2.Size = New System.Drawing.Size(122, 70)
        Me.Pizza_2.TabIndex = 1
        Me.Pizza_2.Text = "Pizza?"
        Me.Pizza_2.UseVisualStyleBackColor = True
        '
        'Pizza_3
        '
        Me.Pizza_3.Location = New System.Drawing.Point(338, 406)
        Me.Pizza_3.Name = "Pizza_3"
        Me.Pizza_3.Size = New System.Drawing.Size(122, 70)
        Me.Pizza_3.TabIndex = 2
        Me.Pizza_3.Text = "PIZZA"
        Me.Pizza_3.UseVisualStyleBackColor = True
        '
        'Pizza_4
        '
        Me.Pizza_4.Location = New System.Drawing.Point(482, 406)
        Me.Pizza_4.Name = "Pizza_4"
        Me.Pizza_4.Size = New System.Drawing.Size(122, 70)
        Me.Pizza_4.TabIndex = 3
        Me.Pizza_4.Text = "Pizza Time!"
        Me.Pizza_4.UseVisualStyleBackColor = True
        '
        'Pizza_5
        '
        Me.Pizza_5.Location = New System.Drawing.Point(634, 406)
        Me.Pizza_5.Name = "Pizza_5"
        Me.Pizza_5.Size = New System.Drawing.Size(122, 70)
        Me.Pizza_5.TabIndex = 4
        Me.Pizza_5.Text = "...azziP.."
        Me.Pizza_5.UseVisualStyleBackColor = True
        '
        'Exit_1
        '
        Me.Exit_1.Location = New System.Drawing.Point(804, 406)
        Me.Exit_1.Name = "Exit_1"
        Me.Exit_1.Size = New System.Drawing.Size(122, 70)
        Me.Exit_1.TabIndex = 5
        Me.Exit_1.Text = "No morePizza :("
        Me.Exit_1.UseVisualStyleBackColor = True
        '
        'MenuItems
        '
        Me.MenuItems.Location = New System.Drawing.Point(523, 131)
        Me.MenuItems.Name = "MenuItems"
        Me.MenuItems.Size = New System.Drawing.Size(371, 120)
        Me.MenuItems.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 303)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(605, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Welcome to Spidey Cafe!"
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 546)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuItems)
        Me.Controls.Add(Me.Exit_1)
        Me.Controls.Add(Me.Pizza_5)
        Me.Controls.Add(Me.Pizza_4)
        Me.Controls.Add(Me.Pizza_3)
        Me.Controls.Add(Me.Pizza_2)
        Me.Controls.Add(Me.Pizza_1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DinerMenuForm"
        Me.Text = "Spidey Cafe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pizza_1 As Button
    Friend WithEvents Pizza_2 As Button
    Friend WithEvents Pizza_3 As Button
    Friend WithEvents Pizza_4 As Button
    Friend WithEvents Pizza_5 As Button
    Friend WithEvents Exit_1 As Button
    Friend WithEvents MenuItems As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
