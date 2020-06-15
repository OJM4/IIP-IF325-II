<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.SystemColors.Highlight
        Me.panelSuperior.Controls.Add(Me.btnRestaurar)
        Me.panelSuperior.Controls.Add(Me.btnMinimizar)
        Me.panelSuperior.Controls.Add(Me.btnMaximizar)
        Me.panelSuperior.Controls.Add(Me.btnCerrar)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1100, 40)
        Me.panelSuperior.TabIndex = 0
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.SystemColors.GrayText
        Me.PanelLateral.Controls.Add(Me.Label1)
        Me.PanelLateral.Controls.Add(Me.PictureBox1)
        Me.PanelLateral.Controls.Add(Me.Panel3)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.btnEmpleados)
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Controls.Add(Me.btnClientes)
        Me.PanelLateral.Controls.Add(Me.btnProductos)
        Me.PanelLateral.Controls.Add(Me.btnMenu)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 40)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(220, 520)
        Me.PanelLateral.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(57, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mi empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Location = New System.Drawing.Point(1, 243)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 50)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Location = New System.Drawing.Point(1, 187)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 50)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(1, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 50)
        Me.Panel1.TabIndex = 2
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.Salmon
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(220, 40)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(880, 520)
        Me.PanelForms.TabIndex = 2
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrar
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IIParcial.My.Resources.Resources.empresa
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmpleados.Image = Global.IIParcial.My.Resources.Resources.empleados
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(-2, 243)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(220, 50)
        Me.btnEmpleados.TabIndex = 3
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClientes.Image = Global.IIParcial.My.Resources.Resources.clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(-2, 187)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(220, 50)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProductos.Image = Global.IIParcial.My.Resources.Resources.producto
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(-2, 131)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(220, 50)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.IIParcial.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(176, 5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(40, 40)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.IIParcial.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1023, 1)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.IIParcial.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(988, 1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.IIParcial.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1024, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.IIParcial.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(1058, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 560)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.panelSuperior.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSuperior As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelForms As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
