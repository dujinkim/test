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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.tbxLastName = New System.Windows.Forms.TextBox()
        Me.tbxFirstName = New System.Windows.Forms.TextBox()
        Me.tbxExtension = New System.Windows.Forms.TextBox()
        Me.tbxDepartment = New System.Windows.Forms.TextBox()
        Me.btnRetreive = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lsvEmpList = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Extension:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Department:"
        '
        'tbxID
        '
        Me.tbxID.Location = New System.Drawing.Point(256, 258)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(100, 20)
        Me.tbxID.TabIndex = 6
        '
        'tbxLastName
        '
        Me.tbxLastName.Location = New System.Drawing.Point(256, 287)
        Me.tbxLastName.Name = "tbxLastName"
        Me.tbxLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbxLastName.TabIndex = 7
        '
        'tbxFirstName
        '
        Me.tbxFirstName.Location = New System.Drawing.Point(256, 319)
        Me.tbxFirstName.Name = "tbxFirstName"
        Me.tbxFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbxFirstName.TabIndex = 8
        '
        'tbxExtension
        '
        Me.tbxExtension.Location = New System.Drawing.Point(256, 346)
        Me.tbxExtension.Name = "tbxExtension"
        Me.tbxExtension.Size = New System.Drawing.Size(100, 20)
        Me.tbxExtension.TabIndex = 9
        '
        'tbxDepartment
        '
        Me.tbxDepartment.Location = New System.Drawing.Point(256, 374)
        Me.tbxDepartment.Name = "tbxDepartment"
        Me.tbxDepartment.Size = New System.Drawing.Size(100, 20)
        Me.tbxDepartment.TabIndex = 10
        '
        'btnRetreive
        '
        Me.btnRetreive.Location = New System.Drawing.Point(37, 408)
        Me.btnRetreive.Name = "btnRetreive"
        Me.btnRetreive.Size = New System.Drawing.Size(75, 23)
        Me.btnRetreive.TabIndex = 11
        Me.btnRetreive.Text = "Retreive"
        Me.btnRetreive.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(357, 408)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(144, 408)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 13
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(256, 408)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(461, 408)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lsvEmpList
        '
        Me.lsvEmpList.Location = New System.Drawing.Point(12, 12)
        Me.lsvEmpList.Name = "lsvEmpList"
        Me.lsvEmpList.Size = New System.Drawing.Size(552, 223)
        Me.lsvEmpList.TabIndex = 16
        Me.lsvEmpList.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 450)
        Me.Controls.Add(Me.lsvEmpList)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRetreive)
        Me.Controls.Add(Me.tbxDepartment)
        Me.Controls.Add(Me.tbxExtension)
        Me.Controls.Add(Me.tbxFirstName)
        Me.Controls.Add(Me.tbxLastName)
        Me.Controls.Add(Me.tbxID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "PhoneBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxID As TextBox
    Friend WithEvents tbxLastName As TextBox
    Friend WithEvents tbxFirstName As TextBox
    Friend WithEvents tbxExtension As TextBox
    Friend WithEvents tbxDepartment As TextBox
    Friend WithEvents btnRetreive As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lsvEmpList As ListView
End Class
