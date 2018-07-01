<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pctBin = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblScoreTotal = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLoadScore = New System.Windows.Forms.Button()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.lblFinalScoreTotal = New System.Windows.Forms.Label()
        CType(Me.pctBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctBin
        '
        Me.pctBin.Image = CType(resources.GetObject("pctBin.Image"), System.Drawing.Image)
        Me.pctBin.Location = New System.Drawing.Point(279, 317)
        Me.pctBin.Name = "pctBin"
        Me.pctBin.Size = New System.Drawing.Size(41, 44)
        Me.pctBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBin.TabIndex = 0
        Me.pctBin.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(424, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 70
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(337, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(151, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(221, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lblScoreTotal
        '
        Me.lblScoreTotal.AutoSize = True
        Me.lblScoreTotal.Location = New System.Drawing.Point(535, 13)
        Me.lblScoreTotal.Name = "lblScoreTotal"
        Me.lblScoreTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblScoreTotal.TabIndex = 5
        Me.lblScoreTotal.Text = "0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(491, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score:"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Location = New System.Drawing.Point(535, 32)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(25, 13)
        Me.lblTimeLeft.TabIndex = 7
        Me.lblTimeLeft.Text = "120"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(475, 32)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(54, 13)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time Left:"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'btnLoadScore
        '
        Me.btnLoadScore.Location = New System.Drawing.Point(264, 256)
        Me.btnLoadScore.Name = "btnLoadScore"
        Me.btnLoadScore.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadScore.TabIndex = 9
        Me.btnLoadScore.Text = "Load Score"
        Me.btnLoadScore.UseVisualStyleBackColor = True
        Me.btnLoadScore.Visible = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(228, 156)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(155, 25)
        Me.lblGameOver.TabIndex = 10
        Me.lblGameOver.Text = "GAME OVER!"
        Me.lblGameOver.Visible = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Location = New System.Drawing.Point(243, 215)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(63, 13)
        Me.lblFinalScore.TabIndex = 11
        Me.lblFinalScore.Text = "Final Score:"
        Me.lblFinalScore.Visible = False
        '
        'lblFinalScoreTotal
        '
        Me.lblFinalScoreTotal.AutoSize = True
        Me.lblFinalScoreTotal.Location = New System.Drawing.Point(312, 215)
        Me.lblFinalScoreTotal.Name = "lblFinalScoreTotal"
        Me.lblFinalScoreTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblFinalScoreTotal.TabIndex = 12
        Me.lblFinalScoreTotal.Text = "0"
        Me.lblFinalScoreTotal.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.lblFinalScoreTotal)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.btnLoadScore)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTotal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pctBin)
        Me.Name = "Form2"
        Me.Text = "Paper Catcher"
        CType(Me.pctBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctBin As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblScoreTotal As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnLoadScore As Button
    Friend WithEvents lblGameOver As Label
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents lblFinalScoreTotal As Label
End Class
