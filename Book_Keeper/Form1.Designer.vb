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
        ButtonConnect = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        ButtonCreate = New Button()
        TextBoxId = New TextBox()
        TextBoxCategory = New TextBox()
        TextBoxTitle = New TextBox()
        TextBoxAuthor = New TextBox()
        TextBoxAvailability = New TextBox()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ButtonRead = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonConnect
        ' 
        ButtonConnect.Location = New Point(260, 39)
        ButtonConnect.Name = "ButtonConnect"
        ButtonConnect.Size = New Size(76, 23)
        ButtonConnect.TabIndex = 0
        ButtonConnect.Text = "Connect"
        ButtonConnect.UseVisualStyleBackColor = True
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Location = New Point(544, 39)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(75, 23)
        ButtonUpdate.TabIndex = 1
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(625, 39)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(75, 23)
        ButtonDelete.TabIndex = 2
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonCreate
        ' 
        ButtonCreate.Location = New Point(361, 39)
        ButtonCreate.Name = "ButtonCreate"
        ButtonCreate.Size = New Size(75, 23)
        ButtonCreate.TabIndex = 3
        ButtonCreate.Text = "Create"
        ButtonCreate.UseVisualStyleBackColor = True
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Location = New Point(113, 56)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(100, 23)
        TextBoxId.TabIndex = 4
        TextBoxId.Visible = False
        ' 
        ' TextBoxCategory
        ' 
        TextBoxCategory.Location = New Point(113, 206)
        TextBoxCategory.Name = "TextBoxCategory"
        TextBoxCategory.Size = New Size(100, 23)
        TextBoxCategory.TabIndex = 5
        ' 
        ' TextBoxTitle
        ' 
        TextBoxTitle.Location = New Point(113, 103)
        TextBoxTitle.Name = "TextBoxTitle"
        TextBoxTitle.Size = New Size(100, 23)
        TextBoxTitle.TabIndex = 6
        ' 
        ' TextBoxAuthor
        ' 
        TextBoxAuthor.Location = New Point(113, 153)
        TextBoxAuthor.Name = "TextBoxAuthor"
        TextBoxAuthor.Size = New Size(100, 23)
        TextBoxAuthor.TabIndex = 7
        ' 
        ' TextBoxAvailability
        ' 
        TextBoxAvailability.Location = New Point(113, 256)
        TextBoxAvailability.Name = "TextBoxAvailability"
        TextBoxAvailability.Size = New Size(100, 23)
        TextBoxAvailability.TabIndex = 8
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(244, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(456, 332)
        DataGridView1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 11
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 12
        Label3.Text = "Title"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 13
        Label4.Text = "Category"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 14
        Label5.Text = "Availability"
        ' 
        ' ButtonRead
        ' 
        ButtonRead.Location = New Point(454, 39)
        ButtonRead.Name = "ButtonRead"
        ButtonRead.Size = New Size(75, 23)
        ButtonRead.TabIndex = 15
        ButtonRead.Text = "Read"
        ButtonRead.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonRead)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(TextBoxAvailability)
        Controls.Add(TextBoxAuthor)
        Controls.Add(TextBoxTitle)
        Controls.Add(TextBoxCategory)
        Controls.Add(TextBoxId)
        Controls.Add(ButtonCreate)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonConnect)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents TextBoxAuthor As TextBox
    Friend WithEvents TextBoxAvailability As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonRead As Button

End Class
