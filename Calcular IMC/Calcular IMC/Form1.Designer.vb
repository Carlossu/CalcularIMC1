﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.btnCalcularIMC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIMC = New System.Windows.Forms.Label()
        Me.lblRiesgo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(160, 33)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 0
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(160, 72)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 1
        '
        'btnCalcularIMC
        '
        Me.btnCalcularIMC.Location = New System.Drawing.Point(92, 127)
        Me.btnCalcularIMC.Name = "btnCalcularIMC"
        Me.btnCalcularIMC.Size = New System.Drawing.Size(107, 30)
        Me.btnCalcularIMC.TabIndex = 2
        Me.btnCalcularIMC.Text = "Calcular IMC"
        Me.btnCalcularIMC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese Peso (kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese Altura (m)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRiesgo)
        Me.GroupBox1.Controls.Add(Me.lblIMC)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 109)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masa Corporal"
        '
        'lblIMC
        '
        Me.lblIMC.AutoSize = True
        Me.lblIMC.Location = New System.Drawing.Point(76, 29)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.Size = New System.Drawing.Size(39, 13)
        Me.lblIMC.TabIndex = 0
        Me.lblIMC.Text = "Label3"
        '
        'lblRiesgo
        '
        Me.lblRiesgo.AutoSize = True
        Me.lblRiesgo.Location = New System.Drawing.Point(76, 67)
        Me.lblRiesgo.Name = "lblRiesgo"
        Me.lblRiesgo.Size = New System.Drawing.Size(39, 13)
        Me.lblRiesgo.TabIndex = 1
        Me.lblRiesgo.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcularIMC)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtPeso)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcularIMC As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIMC As System.Windows.Forms.Label
    Friend WithEvents lblRiesgo As System.Windows.Forms.Label

End Class
