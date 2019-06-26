Imports System.Data.SqlClient
Public Class Form1
    Dim strConnection As String = "Data Source=.\SQLEXPRESS;Initial Catalog=COMP10039A5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnRetreive.Enabled = False
        btnClear.Enabled = False
        SetupEmployeesListView()
        LoadEmployeesListView()



        'Label1.Text = myCmd.Parameters("@name").Value

    End Sub

    Private Sub SetupEmployeesListView() 'Same as SetUpListview

        lsvEmpList.View = View.Details
        lsvEmpList.MultiSelect = False
        lsvEmpList.GridLines = True
        lsvEmpList.FullRowSelect = True

        lsvEmpList.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lsvEmpList.Columns.Add("lastname", 100, HorizontalAlignment.Left)
        lsvEmpList.Columns.Add("firstname", 100, HorizontalAlignment.Left)
        lsvEmpList.Columns.Add("extension", 100, HorizontalAlignment.Left)
        lsvEmpList.Columns.Add("department", 100, HorizontalAlignment.Left)

    End Sub
    Private Sub LoadEmployeesListView() 'Same as PopulateListview

        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Try
            myConnection.Open()
            Dim myCmd As SqlCommand = New SqlCommand("Select Id, Lastname, Firstname, Extension, Department From Employees", myConnection)
            Dim myDR As SqlDataReader = myCmd.ExecuteReader()
            Dim intRow As Integer = 0
            While myDR.Read()
                intRow += 1
                Dim lsiEmployees As ListViewItem = New ListViewItem(intRow)
                'lsiEmployees.SubItems.Add(myDR("Id"))
                lsiEmployees.SubItems.Add(myDR("Lastname"))
                lsiEmployees.SubItems.Add(myDR("Firstname"))
                lsiEmployees.SubItems.Add(myDR("Extension"))
                lsiEmployees.SubItems.Add(myDR("Department"))
                lsvEmpList.Items.Add(lsiEmployees)
            End While
            myDR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.GetBaseException.ToString)
        Finally
            myConnection.Close()
        End Try
    End Sub


    Private Sub lsvEmpList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvEmpList.SelectedIndexChanged
        btnRetreive.Enabled = True

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Try
            myConnection.Open()
            Dim myCmd As SqlCommand = New SqlCommand()
            myCmd.Connection = myConnection
            myCmd.CommandText = "INSERT INTO Employees (Lastname, Firstname, Extension, Department)" +
                "VALUES (@lastname, @firstname, @extension, @department)"

            'myCmd.Parameters.Add("@id", SqlDbType.Int)
            'myCmd.Parameters("@id").Value = Integer.Parse(tbxID.Text)
            '@@@@@@@I needed to hide this statement because the instruction requires set the identify specification by 1@@@@@@@@@

            myCmd.Parameters.Add("@lastname", SqlDbType.NChar)
            myCmd.Parameters("@lastname").Value = tbxLastName.Text


            myCmd.Parameters.Add("@firstname", SqlDbType.NChar)
            myCmd.Parameters("@firstname").Value = tbxFirstName.Text



            myCmd.Parameters.Add("@extension", SqlDbType.Int)
            myCmd.Parameters("@extension").Value = Integer.Parse(tbxExtension.Text)


            myCmd.Parameters.Add("@department", SqlDbType.NVarChar)
            myCmd.Parameters("@department").Value = tbxDepartment.Text

            Dim intRows As Integer = myCmd.ExecuteNonQuery()
            If intRows = 1 Then
                MessageBox.Show("Created")
            Else
                MessageBox.Show("Create Failed")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Close()
        End Try
    End Sub

    Private Sub btnRetreive_Click(sender As Object, e As EventArgs) Handles btnRetreive.Click
        btnClear.Enabled = True
        If lsvEmpList.SelectedItems.Count > 0 Then
            Dim lviSelected As ListViewItem = lsvEmpList.SelectedItems(0)
            tbxID.Text = lviSelected.SubItems(0).Text
            tbxLastName.Text = lviSelected.SubItems(1).Text
            tbxFirstName.Text = lviSelected.SubItems(2).Text
            tbxExtension.Text = lviSelected.SubItems(3).Text
            tbxDepartment.Text = lviSelected.SubItems(4).Text
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxDepartment.Text = ""
        tbxExtension.Text = ""
        tbxFirstName.Text = ""
        tbxID.Text = ""
        tbxLastName.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Try
            myConnection.Open()
            Dim myCmd As SqlCommand = New SqlCommand()
            myCmd.Connection = myConnection
            myCmd.CommandText = "DELETE FROM Employees WHERE Id = @Id"

            myCmd.Parameters.Add("@Id", SqlDbType.Int)
            myCmd.Parameters("@Id").Value = Integer.Parse(tbxID.Text)

            Dim intRows As Integer = myCmd.ExecuteNonQuery()
            If intRows = 1 Then
                MessageBox.Show("Deleted")
            Else
                MessageBox.Show("Delete Failed")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Try
            myConnection.Open()
            Dim myCmd As SqlCommand = New SqlCommand()
            myCmd.Connection = myConnection
            myCmd.CommandText = "UPDATE Employees SET Lastname = @lastname, Firstname = @firstname, Extension = @extension, Department = @department" +
                "WHERE Id = @Id"

            myCmd.Parameters.Add("@Id", SqlDbType.Int)
            myCmd.Parameters("@Id").Value = Integer.Parse(tbxID.Text)

            myCmd.Parameters.Add("@extension", SqlDbType.Int)
            myCmd.Parameters("@extension").Value = Integer.Parse(tbxID.Text)

            myCmd.Parameters.Add("@lastname", SqlDbType.NChar)
            myCmd.Parameters("@lastname").Value = tbxLastName.Text

            myCmd.Parameters.Add("@firstname", SqlDbType.NChar)
            myCmd.Parameters("@firstname").Value = tbxLastName.Text

            myCmd.Parameters.Add("@department", SqlDbType.NVarChar)
            myCmd.Parameters("@department").Value = tbxLastName.Text


            Dim intRows As Integer = myCmd.ExecuteNonQuery()
            If intRows = 1 Then
                MessageBox.Show("Updated")
            Else
                MessageBox.Show("Update Failed")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Close()
        End Try

    End Sub
End Class
