<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class madFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(madFrm))
        subLst = New ListBox()
        verbLst = New ListBox()
        adjLst = New ListBox()
        objLst = New ListBox()
        storyLbl = New Label()
        titlePic = New PictureBox()
        instLbl = New Label()
        genBtn = New Button()
        clrBtn = New Button()
        exitBtn = New Button()
        objPic = New PictureBox()
        clrLbl = New Label()
        subLbl = New Label()
        verbLbl = New Label()
        adjLbl = New Label()
        objLbl = New Label()
        CType(titlePic, ComponentModel.ISupportInitialize).BeginInit()
        CType(objPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' subLst
        ' 
        subLst.BackColor = Color.White
        subLst.Font = New Font("Comic Sans MS", 14.25F)
        subLst.FormattingEnabled = True
        subLst.ItemHeight = 26
        subLst.Items.AddRange(New Object() {"Frodo Baggins", "Indiana Jones", "James Bond", "Katniss Everdeen", "Luke Skywalker", "Optimus Prime", "Ron Weasley", "Sherlock Holmes", "Tony Stark", "Wonder Woman"})
        subLst.Location = New Point(12, 158)
        subLst.Name = "subLst"
        subLst.Size = New Size(175, 134)
        subLst.Sorted = True
        subLst.TabIndex = 0
        ' 
        ' verbLst
        ' 
        verbLst.BackColor = Color.White
        verbLst.Font = New Font("Comic Sans MS", 14.25F)
        verbLst.FormattingEnabled = True
        verbLst.ItemHeight = 26
        verbLst.Items.AddRange(New Object() {"drift", "gobble", "pop", "scamper", "slink", "snatch", "stumble", "tumble", "twirl", "wiggle"})
        verbLst.Location = New Point(213, 158)
        verbLst.Name = "verbLst"
        verbLst.Size = New Size(175, 134)
        verbLst.Sorted = True
        verbLst.TabIndex = 1
        ' 
        ' adjLst
        ' 
        adjLst.BackColor = Color.White
        adjLst.Font = New Font("Comic Sans MS", 14.25F)
        adjLst.FormattingEnabled = True
        adjLst.ItemHeight = 26
        adjLst.Items.AddRange(New Object() {"clumsy", "epic", "gleeful", "gloomy", "grumpy", "mysterious", "silly", "sparkly", "witty", "zany"})
        adjLst.Location = New Point(413, 158)
        adjLst.Name = "adjLst"
        adjLst.Size = New Size(175, 134)
        adjLst.Sorted = True
        adjLst.TabIndex = 2
        ' 
        ' objLst
        ' 
        objLst.BackColor = Color.White
        objLst.Font = New Font("Comic Sans MS", 14.25F)
        objLst.FormattingEnabled = True
        objLst.ItemHeight = 26
        objLst.Items.AddRange(New Object() {"backpack", "lava lamp", "rubber duck", "sandwich", "skateboard", "smartphone", "telescope", "treasure map", "umbrella", "whistle"})
        objLst.Location = New Point(613, 158)
        objLst.Name = "objLst"
        objLst.Size = New Size(175, 134)
        objLst.Sorted = True
        objLst.TabIndex = 3
        ' 
        ' storyLbl
        ' 
        storyLbl.AutoSize = True
        storyLbl.BackColor = SystemColors.Window
        storyLbl.BorderStyle = BorderStyle.FixedSingle
        storyLbl.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        storyLbl.Location = New Point(12, 9)
        storyLbl.MaximumSize = New Size(500, 500)
        storyLbl.Name = "storyLbl"
        storyLbl.Size = New Size(499, 379)
        storyLbl.TabIndex = 4
        storyLbl.Text = resources.GetString("storyLbl.Text")
        storyLbl.Visible = False
        ' 
        ' titlePic
        ' 
        titlePic.Image = My.Resources.Resources.MadLibs
        titlePic.Location = New Point(152, 8)
        titlePic.Name = "titlePic"
        titlePic.Size = New Size(496, 102)
        titlePic.TabIndex = 5
        titlePic.TabStop = False
        ' 
        ' instLbl
        ' 
        instLbl.AutoSize = True
        instLbl.BackColor = Color.MediumTurquoise
        instLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        instLbl.Location = New Point(52, 310)
        instLbl.Name = "instLbl"
        instLbl.Size = New Size(696, 78)
        instLbl.TabIndex = 6
        instLbl.Text = "Use the lists above to select what words you would like to use in your Mad Lib!" & vbCrLf & vbCrLf & "When you are done with your selection, press the ""Generate"" button!"
        instLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' genBtn
        ' 
        genBtn.BackColor = Color.FromArgb(CByte(152), CByte(255), CByte(152))
        genBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genBtn.Location = New Point(332, 420)
        genBtn.Name = "genBtn"
        genBtn.Size = New Size(137, 44)
        genBtn.TabIndex = 7
        genBtn.Text = "&Generate"
        genBtn.UseVisualStyleBackColor = False
        ' 
        ' clrBtn
        ' 
        clrBtn.BackColor = Color.LightGray
        clrBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clrBtn.Location = New Point(79, 420)
        clrBtn.Name = "clrBtn"
        clrBtn.Size = New Size(137, 44)
        clrBtn.TabIndex = 8
        clrBtn.Text = "&Clear"
        clrBtn.UseVisualStyleBackColor = False
        clrBtn.Visible = False
        ' 
        ' exitBtn
        ' 
        exitBtn.BackColor = Color.Crimson
        exitBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitBtn.Location = New Point(585, 420)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(137, 44)
        exitBtn.TabIndex = 9
        exitBtn.Text = "E&xit"
        exitBtn.UseVisualStyleBackColor = False
        ' 
        ' objPic
        ' 
        objPic.Image = My.Resources.Resources.frodo
        objPic.Location = New Point(517, 8)
        objPic.Name = "objPic"
        objPic.Size = New Size(271, 284)
        objPic.SizeMode = PictureBoxSizeMode.Zoom
        objPic.TabIndex = 10
        objPic.TabStop = False
        objPic.Visible = False
        ' 
        ' clrLbl
        ' 
        clrLbl.AutoSize = True
        clrLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clrLbl.Location = New Point(517, 302)
        clrLbl.MaximumSize = New Size(271, 200)
        clrLbl.MinimumSize = New Size(271, 50)
        clrLbl.Name = "clrLbl"
        clrLbl.Size = New Size(271, 78)
        clrLbl.TabIndex = 11
        clrLbl.Text = "When you are done viewing the sentence, please select the ""Clear"" button "
        clrLbl.TextAlign = ContentAlignment.MiddleCenter
        clrLbl.Visible = False
        ' 
        ' subLbl
        ' 
        subLbl.AutoSize = True
        subLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subLbl.Location = New Point(53, 129)
        subLbl.Name = "subLbl"
        subLbl.Size = New Size(91, 26)
        subLbl.TabIndex = 12
        subLbl.Text = "Subjects"
        ' 
        ' verbLbl
        ' 
        verbLbl.AutoSize = True
        verbLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        verbLbl.Location = New Point(266, 129)
        verbLbl.Name = "verbLbl"
        verbLbl.Size = New Size(63, 26)
        verbLbl.TabIndex = 13
        verbLbl.Text = "Verbs"
        ' 
        ' adjLbl
        ' 
        adjLbl.AutoSize = True
        adjLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        adjLbl.Location = New Point(448, 129)
        adjLbl.Name = "adjLbl"
        adjLbl.Size = New Size(104, 26)
        adjLbl.TabIndex = 14
        adjLbl.Text = "Adjectives"
        ' 
        ' objLbl
        ' 
        objLbl.AutoSize = True
        objLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        objLbl.Location = New Point(657, 129)
        objLbl.Name = "objLbl"
        objLbl.Size = New Size(83, 26)
        objLbl.TabIndex = 15
        objLbl.Text = "Objects"
        ' 
        ' madFrm
        ' 
        AcceptButton = genBtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumTurquoise
        CancelButton = exitBtn
        ClientSize = New Size(800, 474)
        Controls.Add(objLbl)
        Controls.Add(adjLbl)
        Controls.Add(verbLbl)
        Controls.Add(subLbl)
        Controls.Add(clrLbl)
        Controls.Add(exitBtn)
        Controls.Add(clrBtn)
        Controls.Add(genBtn)
        Controls.Add(instLbl)
        Controls.Add(titlePic)
        Controls.Add(objLst)
        Controls.Add(adjLst)
        Controls.Add(verbLst)
        Controls.Add(subLst)
        Controls.Add(storyLbl)
        Controls.Add(objPic)
        Name = "madFrm"
        Text = "Mad Libs"
        CType(titlePic, ComponentModel.ISupportInitialize).EndInit()
        CType(objPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents subLst As ListBox
    Friend WithEvents verbLst As ListBox
    Friend WithEvents adjLst As ListBox
    Friend WithEvents objLst As ListBox
    Friend WithEvents storyLbl As Label
    Friend WithEvents titlePic As PictureBox
    Friend WithEvents instLbl As Label
    Friend WithEvents genBtn As Button
    Friend WithEvents clrBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents objPic As PictureBox
    Friend WithEvents clrLbl As Label
    Friend WithEvents subLbl As Label
    Friend WithEvents verbLbl As Label
    Friend WithEvents adjLbl As Label
    Friend WithEvents objLbl As Label

End Class
