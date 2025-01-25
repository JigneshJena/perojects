<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        BtnAdd = New Button()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        BtnCancel = New Button()
        BtnReset = New Button()
        RichTextBox1 = New RichTextBox()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        TxtNumber = New TextBox()
        BtnSave = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        TxtName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(46, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 32)
        Label1.TabIndex = 0
        Label1.Text = "Add New Customer Details"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(BtnAdd)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(BtnCancel)
        Panel1.Controls.Add(BtnReset)
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(TxtNumber)
        Panel1.Controls.Add(BtnSave)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TxtName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 162)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(420, 450)
        Panel1.TabIndex = 2
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BtnAdd.Location = New Point(335, 243)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(75, 30)
        BtnAdd.TabIndex = 15
        BtnAdd.Text = "ADD"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(379, 334)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(33, 28)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(231, 328)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(39, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(87, 334)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 28)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BtnCancel.Location = New Point(298, 332)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(75, 30)
        BtnCancel.TabIndex = 11
        BtnCancel.Text = "CANCEL"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' BtnReset
        ' 
        BtnReset.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BtnReset.Location = New Point(152, 332)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(75, 30)
        BtnReset.TabIndex = 10
        BtnReset.Text = "RESET"
        BtnReset.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(3, 243)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(324, 65)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label7.Location = New Point(3, 219)
        Label7.Name = "Label7"
        Label7.Size = New Size(192, 21)
        Label7.TabIndex = 8
        Label7.Text = "PROBLEM DISCRIPTION "
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(149, 177)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(261, 23)
        ComboBox2.TabIndex = 7
        ' 
        ' TxtNumber
        ' 
        TxtNumber.Location = New Point(96, 91)
        TxtNumber.Name = "TxtNumber"
        TxtNumber.Size = New Size(314, 23)
        TxtNumber.TabIndex = 6
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BtnSave.Location = New Point(6, 332)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 30)
        BtnSave.TabIndex = 5
        BtnSave.Text = "SAVE"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label6.Location = New Point(3, 175)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 21)
        Label6.TabIndex = 5
        Label6.Text = "DEVICE MODEL :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(149, 132)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(261, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(3, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 21)
        Label5.TabIndex = 4
        Label5.Text = "BRAND NAME :"
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(96, 52)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(314, 23)
        TxtName.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Location = New Point(3, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 21)
        Label4.TabIndex = 3
        Label4.Text = "NUMBER :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(3, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 21)
        Label3.TabIndex = 2
        Label3.Text = "NAME :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(188, 612)
        Label9.Name = "Label9"
        Label9.Size = New Size(258, 20)
        Label9.TabIndex = 4
        Label9.Text = "Mobile Repair Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 21)
        Label2.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(444, 631)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "CustomerDetails"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label

End Class
