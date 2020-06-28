Public Class frmEstudiante
    ' se instancia la clase conexion.vb con el nombre conexion para ser utilizada dentro del formulario
    Dim conexion As conexion = New conexion()
    Private Sub frmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'en el evento load del formulario se abre la conexion a la base de datos
        conexion.conectar()
        mostrarDatos()
    End Sub

    Public Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegApellido.Clear()
        txtEdad.Clear()
        cmbSexo.Items.Clear()
    End Sub

    Private Sub mostrarDatos()
        conexion.consulta("select * from personas.estudiante", "personas.estudiante")
        dtgRegistros.DataSource = conexion.ds.Tables("personas.estudiante")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim guardar As String =
        "insert into personas.estudiante values(" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtPrimerApellido.Text + "',
        '" + txtSegApellido.Text + "','" + txtEdad.Text + "','" + cmbSexo.Text + "')"
        If (conexion.insertar(guardar)) Then
            MessageBox.Show("Guardado")
            mostrarDatos()
            Limpiar()
        Else
            MessageBox.Show("Error al guardar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (conexion.eliminar("personas.estudiante", "codigo=" + txtCodigo.Text)) Then
            MessageBox.Show("Eliminado")
            mostrarDatos()
        Else
            MessageBox.Show("Error al Eliminar")
        End If
    End Sub

    Private Sub dtgRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellContentClick
        Dim dtg As DataGridViewRow = dtgRegistros.Rows(e.RowIndex)
        txtCodigo.Text = dtg.Cells(0).Value.ToString()
        txtNombre.Text = dtg.Cells(1).Value.ToString()
        txtPrimerApellido.Text = dtg.Cells(2).Value.ToString()
        txtSegApellido.Text = dtg.Cells(3).Value.ToString()
        txtEdad.Text = dtg.Cells(4).Value.ToString()
        cmbSexo.Text = dtg.Cells(5).Value.ToString()

    End Sub

End Class

