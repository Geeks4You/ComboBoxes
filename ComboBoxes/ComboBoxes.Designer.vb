<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboBoxes
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
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.cboPlay = New System.Windows.Forms.ComboBox()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.lbCountry = New System.Windows.Forms.Label()
        Me.lbPlay = New System.Windows.Forms.Label()
        Me.lbArtist = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountry.Location = New System.Drawing.Point(109, 26)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(121, 21)
        Me.cboCountry.TabIndex = 0
        '
        'cboPlay
        '
        Me.cboPlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPlay.FormattingEnabled = True
        Me.cboPlay.Items.AddRange(New Object() {"Hamlet", "Much Ado about Nothing", "Romeo and Juliet", "A Comedy of Errors,", "The Merchant of Venice"})
        Me.cboPlay.Location = New System.Drawing.Point(109, 76)
        Me.cboPlay.Name = "cboPlay"
        Me.cboPlay.Size = New System.Drawing.Size(121, 85)
        Me.cboPlay.TabIndex = 1
        '
        'cboArtist
        '
        Me.cboArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtist.Location = New System.Drawing.Point(109, 174)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 2
        '
        'lbCountry
        '
        Me.lbCountry.AutoSize = True
        Me.lbCountry.Location = New System.Drawing.Point(12, 29)
        Me.lbCountry.Name = "lbCountry"
        Me.lbCountry.Size = New System.Drawing.Size(94, 13)
        Me.lbCountry.TabIndex = 3
        Me.lbCountry.Text = "Choose a Country:"
        '
        'lbPlay
        '
        Me.lbPlay.AutoSize = True
        Me.lbPlay.Location = New System.Drawing.Point(12, 76)
        Me.lbPlay.Name = "lbPlay"
        Me.lbPlay.Size = New System.Drawing.Size(78, 13)
        Me.lbPlay.TabIndex = 4
        Me.lbPlay.Text = "Choose a Play:"
        '
        'lbArtist
        '
        Me.lbArtist.AutoSize = True
        Me.lbArtist.Location = New System.Drawing.Point(12, 174)
        Me.lbArtist.Name = "lbArtist"
        Me.lbArtist.Size = New System.Drawing.Size(87, 13)
        Me.lbArtist.TabIndex = 5
        Me.lbArtist.Text = "Choose an Artist:"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(109, 227)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 43)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(257, 227)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 43)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(399, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 43)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArtist)
        Me.GroupBox1.Controls.Add(Me.lblPlay)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(274, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 169)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices:"
        '
        'lblArtist
        '
        Me.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtist.Location = New System.Drawing.Point(6, 113)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(188, 29)
        Me.lblArtist.TabIndex = 2
        Me.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlay
        '
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlay.Location = New System.Drawing.Point(7, 72)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(187, 30)
        Me.lblPlay.TabIndex = 1
        Me.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Location = New System.Drawing.Point(7, 32)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(187, 31)
        Me.lblCountry.TabIndex = 0
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 282)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lbArtist)
        Me.Controls.Add(Me.lbPlay)
        Me.Controls.Add(Me.lbCountry)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.cboPlay)
        Me.Controls.Add(Me.cboCountry)
        Me.Name = "ComboBoxes"
        Me.Text = "ComboBox Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents cboPlay As ComboBox
    Friend WithEvents cboArtist As ComboBox
    Friend WithEvents lbCountry As Label
    Friend WithEvents lbPlay As Label
    Friend WithEvents lbArtist As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblPlay As Label
    Friend WithEvents lblCountry As Label
End Class
