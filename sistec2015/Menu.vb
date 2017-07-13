Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class FrmMenu
    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        REGISTRO.Show()
    End Sub

    Private Sub MaestrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestrosToolStripMenuItem.Click
        MEDICAMENTO.Show()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasToolStripMenuItem.Click
        SERVICIO.Show()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label1.Text = hoy()
    End Sub

    Private Sub DENTISTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DENTISTAToolStripMenuItem.Click
        DENTISTA.Show()
    End Sub

    Private Sub RECETAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECETAToolStripMenuItem.Click
        RECETA.Show()
    End Sub
End Class