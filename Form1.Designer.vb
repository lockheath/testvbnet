<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTN_LOGIN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPASSWORD = New System.Windows.Forms.TextBox()
        Me.BTN_CANCEL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_LOGIN
        '
        Me.BTN_LOGIN.Location = New System.Drawing.Point(118, 209)
        Me.BTN_LOGIN.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BTN_LOGIN.Name = "BTN_LOGIN"
        Me.BTN_LOGIN.Size = New System.Drawing.Size(138, 42)
        Me.BTN_LOGIN.TabIndex = 2
        Me.BTN_LOGIN.Text = "Login"
        Me.BTN_LOGIN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'TextBoxUSERNAME
        '
        Me.TextBoxUSERNAME.Location = New System.Drawing.Point(242, 61)
        Me.TextBoxUSERNAME.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBoxUSERNAME.Name = "TextBoxUSERNAME"
        Me.TextBoxUSERNAME.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxUSERNAME.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'TextBoxPASSWORD
        '
        Me.TextBoxPASSWORD.Location = New System.Drawing.Point(242, 109)
        Me.TextBoxPASSWORD.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBoxPASSWORD.Name = "TextBoxPASSWORD"
        Me.TextBoxPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPASSWORD.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxPASSWORD.TabIndex = 1
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.Location = New System.Drawing.Point(288, 209)
        Me.BTN_CANCEL.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(138, 42)
        Me.BTN_CANCEL.TabIndex = 3
        Me.BTN_CANCEL.Text = "Cancel"
        Me.BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 297)
        Me.Controls.Add(Me.TextBoxPASSWORD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUSERNAME)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_CANCEL)
        Me.Controls.Add(Me.BTN_LOGIN)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_LOGIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUSERNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPASSWORD As TextBox
    Friend WithEvents BTN_CANCEL As Button
End Class
