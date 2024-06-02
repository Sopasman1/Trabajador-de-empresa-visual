<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        apellidop = New TextBox()
        correotxt = New TextBox()
        apellidom = New TextBox()
        nombre = New TextBox()
        curptxt = New TextBox()
        EDADtxt = New TextBox()
        telefonotxt = New TextBox()
        rfctxt = New TextBox()
        fechatxt = New DateTimePicker()
        puestocb = New ComboBox()
        Horascb = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Datostrabajador = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        CType(Datostrabajador, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' apellidop
        ' 
        apellidop.Location = New Point(12, 149)
        apellidop.Name = "apellidop"
        apellidop.Size = New Size(173, 23)
        apellidop.TabIndex = 0
        ' 
        ' correotxt
        ' 
        correotxt.Location = New Point(254, 223)
        correotxt.Name = "correotxt"
        correotxt.Size = New Size(173, 23)
        correotxt.TabIndex = 1
        ' 
        ' apellidom
        ' 
        apellidom.Location = New Point(12, 223)
        apellidom.Name = "apellidom"
        apellidom.Size = New Size(173, 23)
        apellidom.TabIndex = 2
        ' 
        ' nombre
        ' 
        nombre.Location = New Point(12, 69)
        nombre.Name = "nombre"
        nombre.Size = New Size(173, 23)
        nombre.TabIndex = 3
        ' 
        ' curptxt
        ' 
        curptxt.Location = New Point(254, 69)
        curptxt.Name = "curptxt"
        curptxt.Size = New Size(173, 23)
        curptxt.TabIndex = 4
        ' 
        ' EDADtxt
        ' 
        EDADtxt.Location = New Point(12, 292)
        EDADtxt.Name = "EDADtxt"
        EDADtxt.Size = New Size(173, 23)
        EDADtxt.TabIndex = 5
        ' 
        ' telefonotxt
        ' 
        telefonotxt.Location = New Point(254, 292)
        telefonotxt.Name = "telefonotxt"
        telefonotxt.Size = New Size(173, 23)
        telefonotxt.TabIndex = 6
        ' 
        ' rfctxt
        ' 
        rfctxt.Location = New Point(254, 149)
        rfctxt.Name = "rfctxt"
        rfctxt.Size = New Size(173, 23)
        rfctxt.TabIndex = 7
        ' 
        ' fechatxt
        ' 
        fechatxt.Location = New Point(12, 369)
        fechatxt.Name = "fechatxt"
        fechatxt.Size = New Size(200, 23)
        fechatxt.TabIndex = 8
        ' 
        ' puestocb
        ' 
        puestocb.FormattingEnabled = True
        puestocb.Items.AddRange(New Object() {"Operario", "Supervisor", "Vicepresidente"})
        puestocb.Location = New Point(12, 456)
        puestocb.Name = "puestocb"
        puestocb.Size = New Size(121, 23)
        puestocb.TabIndex = 9
        ' 
        ' Horascb
        ' 
        Horascb.FormattingEnabled = True
        Horascb.Items.AddRange(New Object() {"2 horas", "4 horas", "5 horas", "6 horas", "7 horas", "8 horas "})
        Horascb.Location = New Point(254, 456)
        Horascb.Name = "Horascb"
        Horascb.Size = New Size(121, 23)
        Horascb.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 567)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 23)
        Button1.TabIndex = 11
        Button1.Text = "Guardar Empleado"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(188, 567)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 23)
        Button2.TabIndex = 12
        Button2.Text = "Guardar como"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(540, 68)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 23)
        Button3.TabIndex = 14
        Button3.Text = "Cargar empleados"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(540, 148)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 23)
        Button4.TabIndex = 15
        Button4.Text = "Borrar empleado"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 16
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 17
        Label2.Text = "Apellido Paterno" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 18
        Label3.Text = "Apellido Materno"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 19
        Label4.Text = "Edad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(254, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 20
        Label5.Text = "CURP"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(254, 131)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 21
        Label6.Text = "RFC"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(254, 205)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 15)
        Label7.TabIndex = 22
        Label7.Text = "Correo Electronico"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(254, 274)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 15)
        Label8.TabIndex = 23
        Label8.Text = "Numero Telefonico"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 351)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 15)
        Label9.TabIndex = 24
        Label9.Text = "Fecha de Nacimento"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 438)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 15)
        Label10.TabIndex = 25
        Label10.Text = "Puesto de trabajo"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(254, 438)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 15)
        Label11.TabIndex = 26
        Label11.Text = "Horas de trabajo"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(12, 482)
        Label12.Name = "Label12"
        Label12.Size = New Size(47, 15)
        Label12.TabIndex = 27
        Label12.Text = "Label12"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(254, 482)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 15)
        Label13.TabIndex = 28
        Label13.Text = "Label13"
        ' 
        ' Datostrabajador
        ' 
        Datostrabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Datostrabajador.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        Datostrabajador.Location = New Point(685, 12)
        Datostrabajador.Name = "Datostrabajador"
        Datostrabajador.Size = New Size(753, 594)
        Datostrabajador.TabIndex = 33
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "#Nombre"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "#ApellidoPaterno"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "#ApellidoMaterno"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "#Edad"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "#Fecha de nacimiento"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "#CURP"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "#RFC"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "#Correo Electronico"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "#Numero telefonico"
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "#Puesto de trabajo"
        Column10.Name = "Column10"
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "#Horas  Trabajadas"
        Column11.Name = "Column11"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "#Sueldo"
        Column12.Name = "Column12"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1450, 618)
        Controls.Add(Datostrabajador)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Horascb)
        Controls.Add(puestocb)
        Controls.Add(fechatxt)
        Controls.Add(rfctxt)
        Controls.Add(telefonotxt)
        Controls.Add(EDADtxt)
        Controls.Add(curptxt)
        Controls.Add(nombre)
        Controls.Add(apellidom)
        Controls.Add(correotxt)
        Controls.Add(apellidop)
        Name = "Form1"
        Text = "Form1"
        CType(Datostrabajador, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents apellidop As TextBox
    Friend WithEvents correotxt As TextBox
    Friend WithEvents apellidom As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents curptxt As TextBox
    Friend WithEvents EDADtxt As TextBox
    Friend WithEvents telefonotxt As TextBox
    Friend WithEvents rfctxt As TextBox
    Friend WithEvents fechatxt As DateTimePicker
    Friend WithEvents puestocb As ComboBox
    Friend WithEvents Horascb As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Private WithEvents Datostrabajador As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents Column6 As DataGridViewTextBoxColumn
    Private WithEvents Column7 As DataGridViewTextBoxColumn
    Private WithEvents Column8 As DataGridViewTextBoxColumn
    Private WithEvents Column9 As DataGridViewTextBoxColumn
    Private WithEvents Column10 As DataGridViewTextBoxColumn
    Private WithEvents Column11 As DataGridViewTextBoxColumn
    Private WithEvents Column12 As DataGridViewTextBoxColumn

End Class
