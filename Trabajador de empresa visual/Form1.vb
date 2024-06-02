Imports System.Text
Imports System.Xml
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports Word = Microsoft.Office.Interop.Word
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports Newtonsoft.Json
Imports System.IO
Imports System.Reflection.Emit
Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub showMensaje()
        MessageBox.Show("Bienvenido a Registro de Empresa")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)
        Dim fullnombre As persona = New persona()
        fullnombre.Nombre = nombre.Text
        fullnombre.ApellidoPaterno = apellidop.Text
        fullnombre.ApellidoMaterno = apellidom.Text

        Dim fechas As Fechas = New Fechas()
        fechas.Edad = EDADtxt.Text
        fechas.Fdn = fechatxt.Value

        Dim correo As datoscorreo = New datoscorreo("", "", "", "")
        correo.CURP = curptxt.Text
        correo.RFC = rfctxt.Text
        correo.Correo = correotxt.Text
        correo.Phone = telefonotxt.Text


        Dim file As DataGridViewRow = New DataGridViewRow()
        file.CreateCells(Datostrabajador)

        file.Cells(0).Value = nombre.Text
        file.Cells(1).Value = apellidop.Text
        file.Cells(2).Value = apellidom.Text
        file.Cells(3).Value = EDADtxt.Text
        file.Cells(4).Value = fechatxt.Value
        file.Cells(5).Value = curptxt.Text
        file.Cells(6).Value = rfctxt.Text
        file.Cells(7).Value = correotxt.Text
        file.Cells(8).Value = telefonotxt.Text
        file.Cells(9).Value = puestocb.Text
        file.Cells(10).Value = Horascb.Text
        file.Cells(11).Value = Single.Parse(Label12.Text) * Single.Parse(Label13.Text)
        Datostrabajador.Rows.Add(file)

        nombre.Text = CSharpImpl.__Assign(apellidop.Text, CSharpImpl.__Assign(apellidom.Text, CSharpImpl.__Assign(EDADtxt.Text, CSharpImpl.__Assign(fechatxt.Text, CSharpImpl.__Assign(curptxt.Text, CSharpImpl.__Assign(rfctxt.Text, CSharpImpl.__Assign(correotxt.Text, CSharpImpl.__Assign(telefonotxt.Text, CSharpImpl.__Assign(puestocb.Text, CSharpImpl.__Assign(Horascb.Text, ""))))))))))



    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim sueldo As Single
        sueldo = puestocb.SelectedIndex

        Select Case sueldo
            Case 0
                Label12.Text = "80"
            Case 1
                Label12.Text = "90"
            Case Else
                Label12.Text = "100"

        End Select
    End Sub

    Private Sub comboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim Horas As Single
        Horas = Horascb.SelectedIndex
        Select Case Horas
            Case 0
                Label13.Text = "2"
            Case 1
                Label13.Text = "4"
            Case 2
                Label13.Text = "5"
            Case 3
                Label13.Text = "6"
            Case 4
                Label13.Text = "7"
            Case Else
                Label13.Text = "8"
        End Select


    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs)
        Try
            Dim rppta = MessageBox.Show("¿Eliminar empleado", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rppta = DialogResult.Yes Then
                Datostrabajador.Rows.Remove(Datostrabajador.CurrentRow)

            End If

        Catch
        End Try

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs)
        Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
        saveFileDialog1.Filter = "Documento de Word (*.docx)|*.docx|Archivo Excel (*.xlsx)|*.xlsx|Archivo PDF (*.pdf)|*.pdf|Archivo de Texto (*.txt)|*.txt|Archivo de XML(*.XML)|*.XML|Archivo de json(*.json)*.json|"
        saveFileDialog1.Title = "Guardar como archivo"
        saveFileDialog1.ShowDialog()

        ' Si se selecciona un archivo y se confirma la selección
        If Not Equals(saveFileDialog1.FileName, "") Then
            Try
                Dim fileName = saveFileDialog1.FileName

                ' Si el usuario selecciona exportar a un archivo de Word
                If saveFileDialog1.FilterIndex = 1 Then
                    ExportarAWord(fileName)
                    ' Si el usuario selecciona exportar a un archivo de Excel
                ElseIf saveFileDialog1.FilterIndex = 2 Then
                    ExportarAExcel(fileName)
                    ' Si el usuario selecciona exportar a un archivo PDF
                ElseIf saveFileDialog1.FilterIndex = 3 Then
                    ExportarAPDF(fileName)
                    ' Si el usuario selecciona exportar a un archivo de texto
                ElseIf saveFileDialog1.FilterIndex = 4 Then
                    ExportarATexto(fileName)

                ElseIf saveFileDialog1.FilterIndex = 5 Then
                    ExportarAXML(fileName)

                ElseIf saveFileDialog1.FilterIndex = 6 Then
                    ExportarAJSON(fileName)
                End If


                MessageBox.Show("Los datos se exportaron correctamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al exportar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ExportarATexto(fileName As String)
        ' Crear un StringBuilder para construir el contenido del archivo de texto
        Dim sb As StringBuilder = New StringBuilder()

        ' Escribe los encabezados de las columnas
        For Each column As DataGridViewColumn In Datostrabajador.Columns
            sb.Append(column.HeaderText & vbTab)
        Next
        sb.AppendLine()

        ' Escribe el contenido de cada celda
        For Each row As DataGridViewRow In Datostrabajador.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then
                    sb.Append(cell.Value.ToString() & vbTab)
                Else
                    sb.Append(vbTab) ' Si el valor es nulo, solo agregamos una tabulación
                End If
            Next
            sb.AppendLine()
        Next

        ' Escribir el contenido del StringBuilder en el archivo de texto
        Call File.WriteAllText(fileName, sb.ToString())
    End Sub

    Private Sub ExportarAExcel(fileName As String)
        Dim excelApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()

        ' Crea un nuevo libro de Excel
        Dim workbook As Workbook = excelApp.Workbooks.Add()

        ' Obtiene la primera hoja de trabajo del libro
        Dim worksheet = CType(workbook.Sheets(1), Worksheet)

        ' Escribe los datos del DataGridView en la hoja de trabajo
        For i = 0 To Datostrabajador.Columns.Count - 1
            worksheet.Cells(1, i + 1) = Datostrabajador.Columns(i).HeaderText
        Next

        For i = 0 To Datostrabajador.Rows.Count - 1
            For j = 0 To Datostrabajador.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = Datostrabajador.Rows(i).Cells(j).Value
            Next
        Next

        ' Guarda el libro en un archivo
        workbook.SaveAs(fileName)

        ' Cierra el libro y Excel
        workbook.Close()
        excelApp.Quit()
    End Sub

    Private Sub ExportarAWord(fileName As String)
        Dim wordApp As Word.Application = New Word.Application()
        Dim doc As Word.Document = wordApp.Documents.Add()

        Dim para As Word.Paragraph = doc.Paragraphs.Add()
        para.Range.Text = "Datos exportados desde DataGridView:"

        Dim table = doc.Tables.Add(para.Range, Datostrabajador.Rows.Count + 1, Datostrabajador.Columns.Count)
        For i = 0 To Datostrabajador.Columns.Count - 1
            table.Cell(1, i + 1).Range.Text = Datostrabajador.Columns(i).HeaderText
        Next

        For i = 0 To Datostrabajador.Rows.Count - 1
            For j = 0 To Datostrabajador.Columns.Count - 1
                table.Cell(i + 2, j + 1).Range.Text = Datostrabajador.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        ' Guarda el documento en un archivo
        Dim fileNameObject As Object = fileName
        Dim fileFormat As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        doc.SaveAs(fileNameObject, fileFormat)

        ' Cierra el documento y Word
        Dim saveChanges As Object = False
        doc.Close(saveChanges)
        wordApp.Quit()
    End Sub

    Private Sub ExportarAPDF(fileName As String)
        ' Crear un nuevo documento PDF
        Dim doc As Document = New Document()

        ' Crear un objeto PdfWriter para escribir en el archivo PDF
        Call PdfWriter.GetInstance(doc, New FileStream(fileName, FileMode.Create))

        ' Abrir el documento para escribir en él
        doc.Open()

        ' Agregar un párrafo al documento
        Dim paragraph As Paragraph = New Paragraph("Datos exportados desde DataGridView:")
        doc.Add(paragraph)

        ' Crear una tabla con el mismo número de columnas que el DataGridView
        Dim table As PdfPTable = New PdfPTable(Datostrabajador.Columns.Count)

        ' Agregar encabezados de columnas a la tabla
        For i = 0 To Datostrabajador.Columns.Count - 1
            table.AddCell(New Phrase(Datostrabajador.Columns(i).HeaderText))
        Next

        ' Agregar datos de celdas a la tabla
        For i = 0 To Datostrabajador.Rows.Count - 1
            For j = 0 To Datostrabajador.Columns.Count - 1
                If Datostrabajador.Rows(i).Cells(j).Value IsNot Nothing Then
                    table.AddCell(New Phrase(Datostrabajador.Rows(i).Cells(j).Value.ToString()))
                Else
                    table.AddCell(New Phrase(""))
                End If
            Next
        Next

        ' Agregar la tabla al documento
        doc.Add(table)

        ' Cerrar el documento
        doc.Close()
    End Sub
    Private Sub ExportarAXML(fileName As String)
        ' Crea un objeto XmlWriterSettings para establecer el formato de escritura XML
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True ' Formatea el XML para que sea legible

        ' Crea un XmlWriter para escribir en el archivo XML
        Using writer = XmlWriter.Create(fileName, settings)
            ' Escribe el encabezado del documento XML
            writer.WriteStartDocument()

            ' Escribe el elemento raíz del documento XML
            writer.WriteStartElement("Datos")

            ' Escribe los datos del DataGridView como elementos XML
            For Each row As DataGridViewRow In Datostrabajador.Rows
                writer.WriteStartElement("Registro")

                For Each cell As DataGridViewCell In row.Cells
                    Dim columnName = Datostrabajador.Columns(cell.ColumnIndex).HeaderText
                    writer.WriteElementString(columnName, cell.Value.ToString())
                Next

                writer.WriteEndElement() ' Cierra el elemento "Registro"
            Next

            writer.WriteEndElement() ' Cierra el elemento "Datos"
            writer.WriteEndDocument() ' Finaliza el documento XML
        End Using


    End Sub
    Private Sub ExportarAJSON(fileName As String)
        ' Crear una lista para almacenar los datos del DataGridView
        Dim data As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()

        ' Recorrer las filas del DataGridView y convertir los datos a un formato compatible con JSON
        For Each row As DataGridViewRow In Datostrabajador.Rows
            Dim rowData As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            For Each cell As DataGridViewCell In row.Cells
                Dim columnName = Datostrabajador.Columns(cell.ColumnIndex).HeaderText
                rowData(columnName) = cell.Value
            Next
            data.Add(rowData)
        Next

        ' Serializar la lista a formato JSON y escribirlo en un archivo
        Dim jsonData = JsonConvert.SerializeObject(data)
        File.WriteAllText(fileName, jsonData)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs)
        Using openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "TXT files (*.txt)|*.txt"
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath = openFileDialog.FileName
                Try
                    Dim lines = File.ReadAllLines(filePath)

                    ' Limpiar el DataGridView antes de cargar nuevos datos
                    Datostrabajador.Rows.Clear()

                    For Each line In lines
                        ' Si la línea comienza con '#' (comentario), no la cargamos
                        If line.StartsWith("#") Then
                            Continue For ' Pasamos a la siguiente línea
                        End If

                        Dim fields = line.Split(ChrW(9)) ' Utilizar '\t' como delimitador

                        ' Agregar una fila al DataGridView y establecer sus valores de celda
                        Datostrabajador.Rows.Add(fields)
                    Next

                    MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using

    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class

End Class
