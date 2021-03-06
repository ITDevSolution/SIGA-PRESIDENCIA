﻿Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes


Public Class frmCalculoSuplementaria
    Inherits System.Windows.Forms.Form

    Dim empleado As Empleado
    Dim parametroMensual As Periodo

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvEmpleados As System.Data.DataView
    Friend WithEvents gdvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_PATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_MATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_CALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CALIDAD_JURIDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLASIFICACION_EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_CLASIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCalculo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblUTM As System.Windows.Forms.Label
    Friend WithEvents txtnombrePeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaPago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUTM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcParametroMensual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents lblHoraTerminoEstimada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHoraInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnVerLiquidaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnVerLibroremuneraciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnVerLiquidacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcOpcionesProceso As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblHoraInical As System.Windows.Forms.Label
    Friend WithEvents lblHoraFinal As System.Windows.Forms.Label
    Friend WithEvents lblTipoCalculo As System.Windows.Forms.Label
    Friend WithEvents FECHA_ING_INSTITUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminaProcesoEmpleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminaProcesoEmpleadoInactivo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl
        Me.gdvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.APELLIDO_PATERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.APELLIDO_MATERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOMBRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CALIDAD_JURIDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESC_CALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GRADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CLASIFICACION_EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESCRIPCION_CLASIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FECHA_ING_INSTITUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dvEmpleados = New System.Data.DataView
        Me.btnCalculo = New DevExpress.XtraEditors.SimpleButton
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.lblFechaPago = New System.Windows.Forms.Label
        Me.lblUF = New System.Windows.Forms.Label
        Me.lblUTM = New System.Windows.Forms.Label
        Me.txtnombrePeriodo = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaPago = New DevExpress.XtraEditors.TextEdit
        Me.txtUF = New DevExpress.XtraEditors.TextEdit
        Me.txtUTM = New DevExpress.XtraEditors.TextEdit
        Me.gpcParametroMensual = New DevExpress.XtraEditors.GroupControl
        Me.lblTipoCalculo = New System.Windows.Forms.Label
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup
        Me.progreso = New System.Windows.Forms.ProgressBar
        Me.lblHoraTerminoEstimada = New DevExpress.XtraEditors.LabelControl
        Me.lblHoraInicio = New DevExpress.XtraEditors.LabelControl
        Me.lblHoraInical = New System.Windows.Forms.Label
        Me.lblHoraFinal = New System.Windows.Forms.Label
        Me.btnVerLiquidaciones = New DevExpress.XtraEditors.SimpleButton
        Me.btnVerLibroremuneraciones = New DevExpress.XtraEditors.SimpleButton
        Me.btnVerLiquidacion = New DevExpress.XtraEditors.SimpleButton
        Me.gpcOpcionesProceso = New DevExpress.XtraEditors.GroupControl
        Me.btnEliminaProcesoEmpleado = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminaProcesoEmpleadoInactivo = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUTM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcParametroMensual.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcOpcionesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcOpcionesProceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'gdcEmpleados
        '
        Me.gdcEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcEmpleados.EmbeddedNavigator
        '
        Me.gdcEmpleados.EmbeddedNavigator.Name = ""
        Me.gdcEmpleados.Location = New System.Drawing.Point(8, 112)
        Me.gdcEmpleados.MainView = Me.gdvEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.Size = New System.Drawing.Size(768, 328)
        Me.gdcEmpleados.TabIndex = 0
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleados, Me.GridView1})
        '
        'gdvEmpleados
        '
        Me.gdvEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EMPLEADO_ID, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.NOMBRES, Me.RUT, Me.DV, Me.CALIDAD_JURIDICA_ID, Me.DESC_CALIDAD_JURIDICA, Me.GRADO_ID, Me.GRADO_ALIAS, Me.CLASIFICACION_EMPLEADO_ID, Me.DESCRIPCION_CLASIFICACION, Me.FECHA_ING_INSTITUCION})
        Me.gdvEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvEmpleados.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvEmpleados.Name = "gdvEmpleados"
        Me.gdvEmpleados.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvEmpleados.OptionsSelection.InvertSelection = True
        Me.gdvEmpleados.OptionsSelection.MultiSelect = True
        Me.gdvEmpleados.OptionsView.ColumnAutoWidth = False
        Me.gdvEmpleados.SynchronizeClones = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.APELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_PATERNO.Visible = True
        Me.APELLIDO_PATERNO.VisibleIndex = 0
        Me.APELLIDO_PATERNO.Width = 159
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.APELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_MATERNO.Visible = True
        Me.APELLIDO_MATERNO.VisibleIndex = 1
        Me.APELLIDO_MATERNO.Width = 143
        '
        'NOMBRES
        '
        Me.NOMBRES.Caption = "Nombre"
        Me.NOMBRES.FieldName = "NOMBRES"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.Visible = True
        Me.NOMBRES.VisibleIndex = 2
        Me.NOMBRES.Width = 190
        '
        'RUT
        '
        Me.RUT.Caption = "Rut"
        Me.RUT.FieldName = "RUT"
        Me.RUT.Name = "RUT"
        Me.RUT.OptionsColumn.ReadOnly = True
        Me.RUT.Visible = True
        Me.RUT.VisibleIndex = 3
        Me.RUT.Width = 63
        '
        'DV
        '
        Me.DV.Caption = "DV"
        Me.DV.FieldName = "DV"
        Me.DV.Name = "DV"
        Me.DV.OptionsColumn.ReadOnly = True
        Me.DV.Visible = True
        Me.DV.VisibleIndex = 4
        Me.DV.Width = 65
        '
        'CALIDAD_JURIDICA_ID
        '
        Me.CALIDAD_JURIDICA_ID.Caption = "ID Calidad Juridica"
        Me.CALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Name = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.OptionsColumn.ReadOnly = True
        '
        'DESC_CALIDAD_JURIDICA
        '
        Me.DESC_CALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.DESC_CALIDAD_JURIDICA.FieldName = "DESC_CALIDAD_JURIDICA"
        Me.DESC_CALIDAD_JURIDICA.Name = "DESC_CALIDAD_JURIDICA"
        Me.DESC_CALIDAD_JURIDICA.OptionsColumn.ReadOnly = True
        Me.DESC_CALIDAD_JURIDICA.Visible = True
        Me.DESC_CALIDAD_JURIDICA.VisibleIndex = 5
        Me.DESC_CALIDAD_JURIDICA.Width = 180
        '
        'GRADO_ID
        '
        Me.GRADO_ID.Caption = "ID Grado"
        Me.GRADO_ID.FieldName = "GRADO_ID"
        Me.GRADO_ID.Name = "GRADO_ID"
        Me.GRADO_ID.OptionsColumn.ReadOnly = True
        '
        'GRADO_ALIAS
        '
        Me.GRADO_ALIAS.Caption = "Grado"
        Me.GRADO_ALIAS.FieldName = "GRADO_ALIAS"
        Me.GRADO_ALIAS.Name = "GRADO_ALIAS"
        Me.GRADO_ALIAS.OptionsColumn.ReadOnly = True
        Me.GRADO_ALIAS.Visible = True
        Me.GRADO_ALIAS.VisibleIndex = 6
        Me.GRADO_ALIAS.Width = 85
        '
        'CLASIFICACION_EMPLEADO_ID
        '
        Me.CLASIFICACION_EMPLEADO_ID.Caption = "ID Clasificación"
        Me.CLASIFICACION_EMPLEADO_ID.FieldName = "CLASIFICACION_EMPLEADO_ID"
        Me.CLASIFICACION_EMPLEADO_ID.Name = "CLASIFICACION_EMPLEADO_ID"
        Me.CLASIFICACION_EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'DESCRIPCION_CLASIFICACION
        '
        Me.DESCRIPCION_CLASIFICACION.Caption = "Clasificación Empleado"
        Me.DESCRIPCION_CLASIFICACION.FieldName = "DESCRIPCION_CLASIFICACION"
        Me.DESCRIPCION_CLASIFICACION.Name = "DESCRIPCION_CLASIFICACION"
        Me.DESCRIPCION_CLASIFICACION.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_CLASIFICACION.Visible = True
        Me.DESCRIPCION_CLASIFICACION.VisibleIndex = 7
        Me.DESCRIPCION_CLASIFICACION.Width = 162
        '
        'FECHA_ING_INSTITUCION
        '
        Me.FECHA_ING_INSTITUCION.Caption = "Fecha Ing. Institución"
        Me.FECHA_ING_INSTITUCION.FieldName = "FECHA_ING_INSTITUCION"
        Me.FECHA_ING_INSTITUCION.Name = "FECHA_ING_INSTITUCION"
        Me.FECHA_ING_INSTITUCION.OptionsColumn.ReadOnly = True
        Me.FECHA_ING_INSTITUCION.Visible = True
        Me.FECHA_ING_INSTITUCION.VisibleIndex = 8
        Me.FECHA_ING_INSTITUCION.Width = 108
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEmpleados
        Me.GridView1.Name = "GridView1"
        '
        'btnCalculo
        '
        Me.btnCalculo.Location = New System.Drawing.Point(24, 520)
        Me.btnCalculo.Name = "btnCalculo"
        Me.btnCalculo.Size = New System.Drawing.Size(296, 23)
        Me.btnCalculo.TabIndex = 1
        Me.btnCalculo.Text = "Procesar a Empleados seleccionados"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 40)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 2
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaPago
        '
        Me.lblFechaPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFechaPago.Location = New System.Drawing.Point(24, 76)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaPago.TabIndex = 3
        Me.lblFechaPago.Text = "Fecha Pago"
        Me.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUF
        '
        Me.lblUF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUF.Location = New System.Drawing.Point(248, 40)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(80, 16)
        Me.lblUF.TabIndex = 4
        Me.lblUF.Text = "Valor U.F."
        Me.lblUF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUTM
        '
        Me.lblUTM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUTM.Location = New System.Drawing.Point(248, 76)
        Me.lblUTM.Name = "lblUTM"
        Me.lblUTM.Size = New System.Drawing.Size(80, 16)
        Me.lblUTM.TabIndex = 5
        Me.lblUTM.Text = "Valor U.T.M."
        Me.lblUTM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtnombrePeriodo
        '
        Me.txtnombrePeriodo.Enabled = False
        Me.txtnombrePeriodo.Location = New System.Drawing.Point(112, 40)
        Me.txtnombrePeriodo.Name = "txtnombrePeriodo"
        '
        'txtnombrePeriodo.Properties
        '
        Me.txtnombrePeriodo.Properties.ReadOnly = True
        Me.txtnombrePeriodo.TabIndex = 6
        '
        'txtFechaPago
        '
        Me.txtFechaPago.Enabled = False
        Me.txtFechaPago.Location = New System.Drawing.Point(112, 72)
        Me.txtFechaPago.Name = "txtFechaPago"
        '
        'txtFechaPago.Properties
        '
        Me.txtFechaPago.Properties.Mask.EditMask = "d"
        Me.txtFechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFechaPago.Properties.ReadOnly = True
        Me.txtFechaPago.TabIndex = 7
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(328, 32)
        Me.txtUF.Name = "txtUF"
        '
        'txtUF.Properties
        '
        Me.txtUF.Properties.Mask.EditMask = "n2"
        Me.txtUF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUF.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUF.Properties.ReadOnly = True
        Me.txtUF.TabIndex = 8
        '
        'txtUTM
        '
        Me.txtUTM.Enabled = False
        Me.txtUTM.Location = New System.Drawing.Point(336, 72)
        Me.txtUTM.Name = "txtUTM"
        '
        'txtUTM.Properties
        '
        Me.txtUTM.Properties.Mask.EditMask = "n0"
        Me.txtUTM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUTM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUTM.Properties.ReadOnly = True
        Me.txtUTM.TabIndex = 9
        '
        'gpcParametroMensual
        '
        Me.gpcParametroMensual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcParametroMensual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcParametroMensual.AppearanceCaption.Options.UseFont = True
        Me.gpcParametroMensual.Controls.Add(Me.lblTipoCalculo)
        Me.gpcParametroMensual.Controls.Add(Me.rdgTipoProceso)
        Me.gpcParametroMensual.Controls.Add(Me.txtUF)
        Me.gpcParametroMensual.Location = New System.Drawing.Point(8, 8)
        Me.gpcParametroMensual.Name = "gpcParametroMensual"
        Me.gpcParametroMensual.Size = New System.Drawing.Size(768, 96)
        Me.gpcParametroMensual.TabIndex = 10
        Me.gpcParametroMensual.Text = "Parámetro Mensual"
        '
        'lblTipoCalculo
        '
        Me.lblTipoCalculo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipoCalculo.Location = New System.Drawing.Point(448, 32)
        Me.lblTipoCalculo.Name = "lblTipoCalculo"
        Me.lblTipoCalculo.Size = New System.Drawing.Size(80, 16)
        Me.lblTipoCalculo.TabIndex = 8
        Me.lblTipoCalculo.Text = "Tipo Cálculo"
        Me.lblTipoCalculo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "S"
        Me.rdgTipoProceso.Enabled = False
        Me.rdgTipoProceso.Location = New System.Drawing.Point(536, 32)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Suplementario")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(136, 32)
        Me.rdgTipoProceso.TabIndex = 7
        '
        'progreso
        '
        Me.progreso.Location = New System.Drawing.Point(24, 480)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(736, 24)
        Me.progreso.TabIndex = 11
        '
        'lblHoraTerminoEstimada
        '
        Me.lblHoraTerminoEstimada.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lblHoraTerminoEstimada.Location = New System.Drawing.Point(592, 544)
        Me.lblHoraTerminoEstimada.Name = "lblHoraTerminoEstimada"
        Me.lblHoraTerminoEstimada.Size = New System.Drawing.Size(168, 24)
        Me.lblHoraTerminoEstimada.TabIndex = 12
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lblHoraInicio.Location = New System.Drawing.Point(408, 544)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(152, 24)
        Me.lblHoraInicio.TabIndex = 13
        '
        'lblHoraInical
        '
        Me.lblHoraInical.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblHoraInical.Location = New System.Drawing.Point(408, 528)
        Me.lblHoraInical.Name = "lblHoraInical"
        Me.lblHoraInical.Size = New System.Drawing.Size(176, 16)
        Me.lblHoraInical.TabIndex = 14
        Me.lblHoraInical.Text = "Hora Inicio"
        '
        'lblHoraFinal
        '
        Me.lblHoraFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblHoraFinal.Location = New System.Drawing.Point(592, 528)
        Me.lblHoraFinal.Name = "lblHoraFinal"
        Me.lblHoraFinal.Size = New System.Drawing.Size(176, 16)
        Me.lblHoraFinal.TabIndex = 15
        Me.lblHoraFinal.Text = "Hora Término Estimada"
        '
        'btnVerLiquidaciones
        '
        Me.btnVerLiquidaciones.Location = New System.Drawing.Point(24, 544)
        Me.btnVerLiquidaciones.Name = "btnVerLiquidaciones"
        Me.btnVerLiquidaciones.Size = New System.Drawing.Size(144, 23)
        Me.btnVerLiquidaciones.TabIndex = 16
        Me.btnVerLiquidaciones.Text = "Ver Liquidaciones"
        '
        'btnVerLibroremuneraciones
        '
        Me.btnVerLibroremuneraciones.Location = New System.Drawing.Point(24, 568)
        Me.btnVerLibroremuneraciones.Name = "btnVerLibroremuneraciones"
        Me.btnVerLibroremuneraciones.Size = New System.Drawing.Size(296, 23)
        Me.btnVerLibroremuneraciones.TabIndex = 17
        Me.btnVerLibroremuneraciones.Text = "Ver Libro de Remuneraciones"
        '
        'btnVerLiquidacion
        '
        Me.btnVerLiquidacion.Location = New System.Drawing.Point(176, 544)
        Me.btnVerLiquidacion.Name = "btnVerLiquidacion"
        Me.btnVerLiquidacion.Size = New System.Drawing.Size(144, 23)
        Me.btnVerLiquidacion.TabIndex = 18
        Me.btnVerLiquidacion.Text = "Ver Liquidación (SEL)"
        '
        'gpcOpcionesProceso
        '
        Me.gpcOpcionesProceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcOpcionesProceso.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcOpcionesProceso.AppearanceCaption.Options.UseFont = True
        Me.gpcOpcionesProceso.Controls.Add(Me.btnEliminaProcesoEmpleado)
        Me.gpcOpcionesProceso.Controls.Add(Me.btnEliminaProcesoEmpleadoInactivo)
        Me.gpcOpcionesProceso.Location = New System.Drawing.Point(8, 448)
        Me.gpcOpcionesProceso.Name = "gpcOpcionesProceso"
        Me.gpcOpcionesProceso.Size = New System.Drawing.Size(768, 176)
        Me.gpcOpcionesProceso.TabIndex = 19
        Me.gpcOpcionesProceso.Text = "Opciones a Procesar"
        '
        'btnEliminaProcesoEmpleado
        '
        Me.btnEliminaProcesoEmpleado.Location = New System.Drawing.Point(168, 144)
        Me.btnEliminaProcesoEmpleado.Name = "btnEliminaProcesoEmpleado"
        Me.btnEliminaProcesoEmpleado.Size = New System.Drawing.Size(144, 23)
        Me.btnEliminaProcesoEmpleado.TabIndex = 22
        Me.btnEliminaProcesoEmpleado.Text = "Elimina Proceso Empleado"
        '
        'btnEliminaProcesoEmpleadoInactivo
        '
        Me.btnEliminaProcesoEmpleadoInactivo.Location = New System.Drawing.Point(16, 144)
        Me.btnEliminaProcesoEmpleadoInactivo.Name = "btnEliminaProcesoEmpleadoInactivo"
        Me.btnEliminaProcesoEmpleadoInactivo.Size = New System.Drawing.Size(144, 23)
        Me.btnEliminaProcesoEmpleadoInactivo.TabIndex = 21
        Me.btnEliminaProcesoEmpleadoInactivo.Text = "Elimina Empleado Inactivo"
        '
        'frmCalculoSuplementaria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 638)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.btnVerLiquidacion)
        Me.Controls.Add(Me.btnVerLibroremuneraciones)
        Me.Controls.Add(Me.btnVerLiquidaciones)
        Me.Controls.Add(Me.lblHoraFinal)
        Me.Controls.Add(Me.lblHoraInical)
        Me.Controls.Add(Me.lblHoraInicio)
        Me.Controls.Add(Me.lblHoraTerminoEstimada)
        Me.Controls.Add(Me.txtUTM)
        Me.Controls.Add(Me.txtFechaPago)
        Me.Controls.Add(Me.txtnombrePeriodo)
        Me.Controls.Add(Me.lblUTM)
        Me.Controls.Add(Me.lblUF)
        Me.Controls.Add(Me.lblFechaPago)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.btnCalculo)
        Me.Controls.Add(Me.gdcEmpleados)
        Me.Controls.Add(Me.gpcParametroMensual)
        Me.Controls.Add(Me.gpcOpcionesProceso)
        Me.Name = "frmCalculoSuplementaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo Suplementaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUTM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcParametroMensual.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcOpcionesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcOpcionesProceso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmCalculoSuplementaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New Periodo
        If parametroMensual.procesoSuplementarioCerrado Then
            btnCalculo.Visible = False
        Else
            btnCalculo.Visible = True
        End If
        Dim fechaFinalIngreso As Date
        Dim diasMes As Integer = fechaFinalIngreso.DaysInMonth(parametroMensual.ano, parametroMensual.mes)
        fechaFinalIngreso = New Date(CInt(parametroMensual.ano), parametroMensual.mes, diasMes)
        gdcEmpleados.DataSource = empleado.recuperaMaestroEmpleadoSuplementario(fechaFinalIngreso)
        txtnombrePeriodo.Text = UCase(parametroMensual.nombrePeriodo)
        txtFechaPago.Text = CType(parametroMensual.fechaPagoSueldo, Date)
        txtUF.Text = parametroMensual.UF
        txtUTM.Text = parametroMensual.UTM
    End Sub

    Private Sub btnCalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculo.Click
        Dim numRegistros As Integer = gdvEmpleados.GetSelectedRows().Length
        If numRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim missing As Object = Type.Missing
        Dim thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Try
            
            wb = excel.Workbooks.Open(Application.StartupPath & "\baseCalculo.xls")
            wb.Activate()

            If MessageBox.Show("¿Está seguro que desea iniciar el proceso?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                btnCalculo.Enabled = False
                progreso.Minimum = 0
                'filas() representa una lista de los  rowHandle seleccionados
                Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
                progreso.Maximum = filas.Length - 1
                Dim empleado As Empleado
                Dim i As Integer
                Dim reliquidaBonos As Boolean = False
                lblHoraInicio.Text = (New Date().Now).ToLongTimeString
                Dim cantidadRegistros As Integer
                Dim segundosDiferencia As Integer
                'excel.Visible = True
                For i = 0 To filas.Length - 1
                    Dim inicio As New Date
                    inicio = Now
                    Debug.WriteLine("HORA INICIO: " & Now)
                    Dim row As DataRow = gdvEmpleados.GetDataRow(filas(i))
                    Debug.WriteLine(row("APELLIDO_PATERNO") & " " & row("APELLIDO_MATERNO"))
                    empleado = New Empleado(row("EMPLEADO_ID"), True)
                    Remuneracion.calculaRemuneracion(empleado, wb, rdgTipoProceso.EditValue, parametroMensual, reliquidaBonos)
                    cantidadRegistros += 1
                    Debug.WriteLine("HORA TERMINO: " & Now)
                    Windows.Forms.Application.DoEvents()
                    progreso.Value = i
                    Dim termino As New Date
                    termino = Now
                    segundosDiferencia = termino.Subtract(inicio).Seconds
                    Dim horaTerminoEstimado As Date
                    horaTerminoEstimado = termino.AddSeconds(segundosDiferencia * (filas.Length - (i + 1)))
                    lblHoraTerminoEstimada.Text = horaTerminoEstimado.ToLongTimeString
                Next i
                System.Windows.Forms.MessageBox.Show("Cálculo Finalizado. Se han procesado " & cantidadRegistros & " de remuneraciones.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCalculo.Enabled = True
                excel.Quit()
                excel = Nothing
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            thisThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        End Try

    End Sub


    Private Sub btnVerLiquidaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerLiquidaciones.Click
        If Not empleado Is Nothing Then
            Dim ventanaReporte1 As New ventanaReporte
            Dim reporte As New rptLiquidacion
            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
            ventanaReporte1.rptVisor.SelectionFormula = "{RH_REM_PERIODO.PERIODO_ID}=" & (New Periodo().ID) & " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=" & """" & CType(rdgTipoProceso.EditValue, String) & """"
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ReportSource = reporte
            ventanaReporte1.Show()
        End If
    End Sub


    Private Sub btnVerLibroremuneraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerLibroremuneraciones.Click
        Dim frmFiltroLibroRemu As New frmFiltroLibroRemunera
        frmFiltroLibroRemu.ShowDialog(Me)
    End Sub


    Private Sub btnVerLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerLiquidacion.Click
        Dim row As DataRow
        Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
        If filas.Length > 0 Then
            row = gdvEmpleados.GetDataRow(filas(0))
            If Not empleado Is Nothing Then
                Dim ventanaReporte1 As New ventanaReporte
                Dim reporte As New rptLiquidacion
                WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
                ventanaReporte1.rptVisor.SelectionFormula = "{RH_REM_PERIODO.PERIODO_ID}=" & (New Periodo().ID) & " AND {RH_PER_EMPLEADO.EMPLEADO_ID}=" & row("EMPLEADO_ID") & " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=" & """" & CType(rdgTipoProceso.EditValue, String) & """"
                ventanaReporte1.rptVisor.ShowParameterPanelButton = False
                ventanaReporte1.rptVisor.ShowCloseButton = False
                ventanaReporte1.rptVisor.ShowGroupTreeButton = False
                ventanaReporte1.rptVisor.ReportSource = reporte
                ventanaReporte1.Show()
            End If
        End If
        row = Nothing

    End Sub

    Private Sub btnEliminaProcesoEmpleadoInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaProcesoEmpleadoInactivo.Click
        Try
            frmEmpleadoInactivoConLiquidacion.DefInstance.idPeriodo = parametroMensual.ID
            frmEmpleadoInactivoConLiquidacion.DefInstance.empleado = empleado
            frmEmpleadoInactivoConLiquidacion.DefInstance.tipoProceso = "S"
            frmEmpleadoInactivoConLiquidacion.DefInstance.Owner = Me
            If frmEmpleadoInactivoConLiquidacion.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar carga el formulario. " & ex.Message, MsgBoxStyle.Exclamation)
        Finally

        End Try
    End Sub

    Private Sub btnEliminaProcesoEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaProcesoEmpleado.Click
        Dim numRegistros As Integer = gdvEmpleados.GetSelectedRows().Length
        Dim mensaje As String
        If numRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            If numRegistros = 1 Then
                mensaje = " eliminar el proceso suplementario del registro seleccionado?"
            Else
                mensaje = " eliminar el proceso suplementario de los registros seleccionados?"
            End If
            If MessageBox.Show("¿Está seguro que desea" & mensaje, "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                btnCalculo.Enabled = False
                btnEliminaProcesoEmpleado.Enabled = False
                btnEliminaProcesoEmpleadoInactivo.Enabled = False
                progreso.Minimum = 0
                Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
                progreso.Maximum = filas.Length - 1
                Dim i As Integer
                Dim cantidadRegistros As Integer
                For i = 0 To filas.Length - 1
                    Dim row As DataRow = gdvEmpleados.GetDataRow(filas(i))
                    Remuneracion.eliminaProcesoEmpleado(row("EMPLEADO_ID"), parametroMensual.ID, "S")
                    cantidadRegistros += 1
                    progreso.Value = i
                Next i
                System.Windows.Forms.MessageBox.Show("Proceso de eliminación finalizado. Se han eliminado " & cantidadRegistros & " de remuneraciones.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCalculo.Enabled = True
                btnEliminaProcesoEmpleado.Enabled = True
                btnEliminaProcesoEmpleadoInactivo.Enabled = True
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
End Class
