'Imports System.Data
Imports System.Data.SqlClient
'Imports System.Windows.Forms
Public Class conexion

    'Data Source= DESKTOP-FA1HDUQ//el valor de data source varia de acuerdo al nombre del servidor en sql
    'Catalog es el nombre de la base de datos

    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-FA1HDUQ;Initial Catalog=Ejemplo; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public cmd As New SqlCommand
    'Public dr As New SqlDataReader
    ' se crea un procedimiento para conectar a la base de datos y en el caso de existir alguna excepcion que esta la retorne 
    Public Sub conectar()
        Try
            'conexion es el nombre de la clase; open() abre la conexion con sql, si se abre la conexion muestra e msj conectado sino cierra la conexion
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consulta() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultaEstudiante", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                'conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Function buscarEstudiante(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from personas.estudiante " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



End Class
