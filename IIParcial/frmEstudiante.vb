Public Class frmEstudiante
    ' se instancia la clase conexion.vb con el nombre conexion para ser utilizada dentro del formulario
    Dim conexion As conexion = New conexion()
    Private Sub frmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'en el evento load del formulario se abre la conexion a la base de datos
        conexion.conectar()
        mostrarDatos()
    End Sub

    Private Sub mostrarDatos()
        conexion.consulta("select * from personas.estudiante", "personas.estudiante")
        dtgRegistros.DataSource = conexion.ds.Tables("personas.estudiante")
    End Sub
End Class