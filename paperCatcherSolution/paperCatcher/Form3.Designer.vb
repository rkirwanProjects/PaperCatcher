<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.lblHIghScores = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(12, 75)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.Size = New System.Drawing.Size(351, 242)
        Me.dgvDisplay.TabIndex = 0
        '
        'lblHIghScores
        '
        Me.lblHIghScores.AutoSize = True
        Me.lblHIghScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHIghScores.Location = New System.Drawing.Point(112, 24)
        Me.lblHIghScores.Name = "lblHIghScores"
        Me.lblHIghScores.Size = New System.Drawing.Size(140, 25)
        Me.lblHIghScores.TabIndex = 1
        Me.lblHIghScores.Text = "High Scores"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(377, 214)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(461, 214)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(60, 32)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(394, 75)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(83, 16)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New Score"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(369, 120)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(67, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "Player Name"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(444, 117)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(83, 20)
        Me.txtPlayerName.TabIndex = 7
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(388, 155)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 13
        Me.lblScore.Text = "Score:"
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Location = New System.Drawing.Point(435, 155)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(13, 13)
        Me.lblFinalScore.TabIndex = 14
        Me.lblFinalScore.Text = "0"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblHIghScores)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents lblHIghScores As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblNew As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblFinalScore As Label
End Class
