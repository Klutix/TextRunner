<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_textRunner
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
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GameLoopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtHiddenControl = New System.Windows.Forms.TextBox()
        Me.GameOvar = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Constantia", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(234, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(639, 564)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(494, 582)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'GameLoopTimer
        '
        Me.GameLoopTimer.Interval = 200
        '
        'txtHiddenControl
        '
        Me.txtHiddenControl.Location = New System.Drawing.Point(1199, 12)
        Me.txtHiddenControl.Name = "txtHiddenControl"
        Me.txtHiddenControl.Size = New System.Drawing.Size(100, 20)
        Me.txtHiddenControl.TabIndex = 2
        '
        'GameOvar
        '
        Me.GameOvar.Interval = 500
        '
        'frm_textRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1402, 609)
        Me.Controls.Add(Me.txtHiddenControl)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "frm_textRunner"
        Me.Text = "TextRunner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents GameLoopTimer As System.Windows.Forms.Timer
    Friend WithEvents txtHiddenControl As System.Windows.Forms.TextBox
    Friend WithEvents GameOvar As System.Windows.Forms.Timer

End Class
