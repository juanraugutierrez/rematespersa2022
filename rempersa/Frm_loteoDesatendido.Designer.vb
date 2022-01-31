<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_loteoDesatendido
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtgDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminaReg = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Dtgadjudicatarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cmb_remate = New System.Windows.Forms.ComboBox()
        Me.TxtNeto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtReg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUnid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dtgadjudicatarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtgDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 237)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'DtgDetalle
        '
        Me.DtgDetalle.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtgDetalle.Location = New System.Drawing.Point(3, 16)
        Me.DtgDetalle.Name = "DtgDetalle"
        Me.DtgDetalle.Size = New System.Drawing.Size(863, 218)
        Me.DtgDetalle.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminaReg)
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.BtnCargar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 535)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnEliminaReg
        '
        Me.BtnEliminaReg.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnEliminaReg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminaReg.Location = New System.Drawing.Point(345, 19)
        Me.BtnEliminaReg.Name = "BtnEliminaReg"
        Me.BtnEliminaReg.Size = New System.Drawing.Size(120, 58)
        Me.BtnEliminaReg.TabIndex = 2
        Me.BtnEliminaReg.Text = "Eliminar Registros"
        Me.BtnEliminaReg.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(471, 19)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(120, 58)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCargar
        '
        Me.BtnCargar.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnCargar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.Location = New System.Drawing.Point(219, 19)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(120, 58)
        Me.BtnCargar.TabIndex = 0
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.TxtNeto)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtReg)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtUnid)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnImportar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(866, 274)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loteo Desatendido"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 153)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(484, 59)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(396, 20)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Cierre"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(252, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Papeles"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(171, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Boletas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(90, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Catalogo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Martillero"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Dtgadjudicatarios)
        Me.GroupBox5.Location = New System.Drawing.Point(518, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(342, 202)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'Dtgadjudicatarios
        '
        Me.Dtgadjudicatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgadjudicatarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtgadjudicatarios.Location = New System.Drawing.Point(3, 16)
        Me.Dtgadjudicatarios.Name = "Dtgadjudicatarios"
        Me.Dtgadjudicatarios.Size = New System.Drawing.Size(336, 183)
        Me.Dtgadjudicatarios.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_fecha)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Cmb_remate)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 129)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'Txt_fecha
        '
        Me.Txt_fecha.Location = New System.Drawing.Point(7, 72)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.Size = New System.Drawing.Size(195, 20)
        Me.Txt_fecha.TabIndex = 18
        Me.Txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Fecha del Remate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Remate"
        '
        'Cmb_remate
        '
        Me.Cmb_remate.FormattingEnabled = True
        Me.Cmb_remate.Location = New System.Drawing.Point(6, 26)
        Me.Cmb_remate.Name = "Cmb_remate"
        Me.Cmb_remate.Size = New System.Drawing.Size(196, 21)
        Me.Cmb_remate.TabIndex = 15
        '
        'TxtNeto
        '
        Me.TxtNeto.Location = New System.Drawing.Point(353, 70)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.Size = New System.Drawing.Size(159, 20)
        Me.TxtNeto.TabIndex = 7
        Me.TxtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Neto "
        '
        'TxtReg
        '
        Me.TxtReg.Location = New System.Drawing.Point(353, 44)
        Me.TxtReg.Name = "TxtReg"
        Me.TxtReg.Size = New System.Drawing.Size(159, 20)
        Me.TxtReg.TabIndex = 5
        Me.TxtReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nro de Registros"
        '
        'TxtUnid
        '
        Me.TxtUnid.Location = New System.Drawing.Point(353, 18)
        Me.TxtUnid.Name = "TxtUnid"
        Me.TxtUnid.Size = New System.Drawing.Size(159, 20)
        Me.TxtUnid.TabIndex = 3
        Me.TxtUnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro de unidades"
        '
        'BtnImportar
        '
        Me.BtnImportar.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnImportar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.Location = New System.Drawing.Point(737, 224)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(120, 32)
        Me.BtnImportar.TabIndex = 1
        Me.BtnImportar.Text = "Importar Datos"
        Me.BtnImportar.UseVisualStyleBackColor = False
        '
        'Frm_loteoDesatendido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 641)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_loteoDesatendido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loteo Desatendido"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Dtgadjudicatarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtgDetalle As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCargar As Button
    Friend WithEvents BtnImportar As Button
    Friend WithEvents TxtUnid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNeto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtReg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txt_fecha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Cmb_remate As ComboBox
    Friend WithEvents BtnEliminaReg As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Dtgadjudicatarios As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class