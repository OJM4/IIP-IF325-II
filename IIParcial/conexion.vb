Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion

    'Data Source= DESKTOP-FA1HDUQ//el valor de data source varia de acuerdo al nombre del servidor en sql
    'Catalog es el nombre de la base de datos

    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-FA1HDUQ;Initial Catalog=Ejemplo; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
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

    Public Sub consulta(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
End Class
