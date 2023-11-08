Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DESARROLLADORES:
        'DAMARYS ELENA OSORIO GUTIERREZ
        'JOSE RIGOBERTO MENDOZA RIVAS

        ' DEPARTAMENTOS
        cbDepartamento.Items.Add("SONSONATE")
        cbDepartamento.Items.Add("SAN SALVADOR")
        cbDepartamento.Items.Add("SAN MIGUEL")
        cbDepartamento.Items.Add("CHALATENANGO")


        ' MUNICIPIOS
        cbMunicipio.Items.Add("SONSONATE")
        cbMunicipio.Items.Add("JUAYUA")
        cbMunicipio.Items.Add("SAN ANTONIO DEL MONTE")
        cbMunicipio.Items.Add("SAN SALVADOR")
        cbMunicipio.Items.Add("ANTIGUO CUSCATLAN")
        cbMunicipio.Items.Add("SANTA TECLA")
        cbMunicipio.Items.Add("MONCAGUA")
        cbMunicipio.Items.Add("CHIRILAGUA")
        cbMunicipio.Items.Add("CHAPELTIQUE")
        cbMunicipio.Items.Add("AGUA CALIENTE")
        cbMunicipio.Items.Add("COMALAPA")
        cbMunicipio.Items.Add("EL PARAISO")






    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim nombre As String = tbNombre.Text
        Dim apellido As String = tbApellido.Text
        Dim departamento As String = cbDepartamento.Text
        Dim municipio As String = cbMunicipio.Text

        ' BASE DE DATOS
        Dim connectionString As String = "Data Source=MENDOZA;Initial Catalog=BDPARCIAL2PROGRA;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' consulta SQL
            Dim query As String = "INSERT INTO Cliente (Nombre, Apellido, Departamento, Municipio) VALUES (@Nombre, @Apellido, @Departamento, @Municipio)"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Apellido", apellido)
                command.Parameters.AddWithValue("@Departamento", departamento)
                command.Parameters.AddWithValue("@Municipio", municipio)

                command.ExecuteNonQuery()
            End Using
        End Using

        tbNombre.Clear()
        tbApellido.Clear()
        cbDepartamento.SelectedIndex = -1
        cbMunicipio.SelectedIndex = -1


    End Sub


End Class

