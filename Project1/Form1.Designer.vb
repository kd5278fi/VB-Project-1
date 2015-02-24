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
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnStay = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lstComputer = New System.Windows.Forms.ListBox()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHit
        '
        Me.btnHit.Location = New System.Drawing.Point(0, 117)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(75, 23)
        Me.btnHit.TabIndex = 0
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnStay
        '
        Me.btnStay.Location = New System.Drawing.Point(0, 175)
        Me.btnStay.Name = "btnStay"
        Me.btnStay.Size = New System.Drawing.Size(75, 23)
        Me.btnStay.TabIndex = 1
        Me.btnStay.Text = "Stay"
        Me.btnStay.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(0, 226)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New game"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lstComputer
        '
        Me.lstComputer.FormattingEnabled = True
        Me.lstComputer.Location = New System.Drawing.Point(328, 70)
        Me.lstComputer.Name = "lstComputer"
        Me.lstComputer.Size = New System.Drawing.Size(120, 95)
        Me.lstComputer.TabIndex = 3
        '
        'lstPlayer
        '
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.Location = New System.Drawing.Point(159, 70)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayer.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 272)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPlayer)
        Me.Controls.Add(Me.lstComputer)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnStay)
        Me.Controls.Add(Me.btnHit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHit As System.Windows.Forms.Button
    Friend WithEvents btnStay As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lstComputer As System.Windows.Forms.ListBox
    Friend WithEvents lstPlayer As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
