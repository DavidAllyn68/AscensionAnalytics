﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5456
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="David")>  _
Partial Public Class ReportViewerDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertReportViewer_AvailableGroupingItem(instance As ReportViewer_AvailableGroupingItem)
    End Sub
  Partial Private Sub UpdateReportViewer_AvailableGroupingItem(instance As ReportViewer_AvailableGroupingItem)
    End Sub
  Partial Private Sub DeleteReportViewer_AvailableGroupingItem(instance As ReportViewer_AvailableGroupingItem)
    End Sub
  Partial Private Sub InsertReportViewer_RecordFilter(instance As ReportViewer_RecordFilter)
    End Sub
  Partial Private Sub UpdateReportViewer_RecordFilter(instance As ReportViewer_RecordFilter)
    End Sub
  Partial Private Sub DeleteReportViewer_RecordFilter(instance As ReportViewer_RecordFilter)
    End Sub
  Partial Private Sub InsertReportViewer_User(instance As ReportViewer_User)
    End Sub
  Partial Private Sub UpdateReportViewer_User(instance As ReportViewer_User)
    End Sub
  Partial Private Sub DeleteReportViewer_User(instance As ReportViewer_User)
    End Sub
  Partial Private Sub InsertReportViewer_AvailableReportParameterValue(instance As ReportViewer_AvailableReportParameterValue)
    End Sub
  Partial Private Sub UpdateReportViewer_AvailableReportParameterValue(instance As ReportViewer_AvailableReportParameterValue)
    End Sub
  Partial Private Sub DeleteReportViewer_AvailableReportParameterValue(instance As ReportViewer_AvailableReportParameterValue)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.AscensionAnalytics.My.MySettings.Default.DavidConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property ReportViewer_AvailableBenefitCodes() As System.Data.Linq.Table(Of ReportViewer_AvailableBenefitCode)
		Get
			Return Me.GetTable(Of ReportViewer_AvailableBenefitCode)
		End Get
	End Property
	
	Public ReadOnly Property ReportViewer_AvailableGroupingItems() As System.Data.Linq.Table(Of ReportViewer_AvailableGroupingItem)
		Get
			Return Me.GetTable(Of ReportViewer_AvailableGroupingItem)
		End Get
	End Property
	
	Public ReadOnly Property ReportViewer_AvailableSchoolgroups() As System.Data.Linq.Table(Of ReportViewer_AvailableSchoolgroup)
		Get
			Return Me.GetTable(Of ReportViewer_AvailableSchoolgroup)
		End Get
	End Property
	
	Public ReadOnly Property ReportViewer_RecordFilters() As System.Data.Linq.Table(Of ReportViewer_RecordFilter)
		Get
			Return Me.GetTable(Of ReportViewer_RecordFilter)
		End Get
	End Property
	
	Public ReadOnly Property ReportViewer_Users() As System.Data.Linq.Table(Of ReportViewer_User)
		Get
			Return Me.GetTable(Of ReportViewer_User)
		End Get
	End Property
	
	Public ReadOnly Property ReportViewer_AvailableReportParameterValues() As System.Data.Linq.Table(Of ReportViewer_AvailableReportParameterValue)
		Get
			Return Me.GetTable(Of ReportViewer_AvailableReportParameterValue)
		End Get
	End Property
End Class

<Table(Name:="dbo.ReportViewer_AvailableBenefitCodes")>  _
Partial Public Class ReportViewer_AvailableBenefitCode
	
	Private _BenefitCode As String
	
	Private _BenefitDescription As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_BenefitCode", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property BenefitCode() As String
		Get
			Return Me._BenefitCode
		End Get
		Set
			If (String.Equals(Me._BenefitCode, value) = false) Then
				Me._BenefitCode = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_BenefitDescription", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property BenefitDescription() As String
		Get
			Return Me._BenefitDescription
		End Get
		Set
			If (String.Equals(Me._BenefitDescription, value) = false) Then
				Me._BenefitDescription = value
			End If
		End Set
	End Property
End Class

<Table(Name:="dbo.ReportViewer_AvailableGroupingItems")>  _
Partial Public Class ReportViewer_AvailableGroupingItem
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _GroupingItemId As Integer
	
	Private _GroupingValue As String
	
	Private _GroupingDisplay As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnGroupingItemIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnGroupingItemIdChanged()
    End Sub
    Partial Private Sub OnGroupingValueChanging(value As String)
    End Sub
    Partial Private Sub OnGroupingValueChanged()
    End Sub
    Partial Private Sub OnGroupingDisplayChanging(value As String)
    End Sub
    Partial Private Sub OnGroupingDisplayChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_GroupingItemId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property GroupingItemId() As Integer
		Get
			Return Me._GroupingItemId
		End Get
		Set
			If ((Me._GroupingItemId = value)  _
						= false) Then
				Me.OnGroupingItemIdChanging(value)
				Me.SendPropertyChanging
				Me._GroupingItemId = value
				Me.SendPropertyChanged("GroupingItemId")
				Me.OnGroupingItemIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_GroupingValue", DbType:="VarChar(2000)")>  _
	Public Property GroupingValue() As String
		Get
			Return Me._GroupingValue
		End Get
		Set
			If (String.Equals(Me._GroupingValue, value) = false) Then
				Me.OnGroupingValueChanging(value)
				Me.SendPropertyChanging
				Me._GroupingValue = value
				Me.SendPropertyChanged("GroupingValue")
				Me.OnGroupingValueChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_GroupingDisplay", DbType:="VarChar(25)")>  _
	Public Property GroupingDisplay() As String
		Get
			Return Me._GroupingDisplay
		End Get
		Set
			If (String.Equals(Me._GroupingDisplay, value) = false) Then
				Me.OnGroupingDisplayChanging(value)
				Me.SendPropertyChanging
				Me._GroupingDisplay = value
				Me.SendPropertyChanged("GroupingDisplay")
				Me.OnGroupingDisplayChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.ReportViewer_AvailableSchoolgroups")>  _
Partial Public Class ReportViewer_AvailableSchoolgroup
	
	Private _SchoolgroupCode As String
	
	Private _SchoolgroupDescription As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_SchoolgroupCode", DbType:="Char(10)")>  _
	Public Property SchoolgroupCode() As String
		Get
			Return Me._SchoolgroupCode
		End Get
		Set
			If (String.Equals(Me._SchoolgroupCode, value) = false) Then
				Me._SchoolgroupCode = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_SchoolgroupDescription", DbType:="VarChar(63)")>  _
	Public Property SchoolgroupDescription() As String
		Get
			Return Me._SchoolgroupDescription
		End Get
		Set
			If (String.Equals(Me._SchoolgroupDescription, value) = false) Then
				Me._SchoolgroupDescription = value
			End If
		End Set
	End Property
End Class

<Table(Name:="dbo.ReportViewer_RecordFilters")>  _
Partial Public Class ReportViewer_RecordFilter
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Name As String
	
	Private _TableName As String
	
	Private _DisplayField As String
	
	Private _ValueField As String
	
	Private _DataType As System.Nullable(Of Integer)
	
	Private _FilterType As System.Nullable(Of Integer)
	
	Private _LookupExpression As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnTableNameChanging(value As String)
    End Sub
    Partial Private Sub OnTableNameChanged()
    End Sub
    Partial Private Sub OnDisplayFieldChanging(value As String)
    End Sub
    Partial Private Sub OnDisplayFieldChanged()
    End Sub
    Partial Private Sub OnValueFieldChanging(value As String)
    End Sub
    Partial Private Sub OnValueFieldChanged()
    End Sub
    Partial Private Sub OnDataTypeChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnDataTypeChanged()
    End Sub
    Partial Private Sub OnFilterTypeChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnFilterTypeChanged()
    End Sub
    Partial Private Sub OnLookupExpressionChanging(value As String)
    End Sub
    Partial Private Sub OnLookupExpressionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Name", DbType:="VarChar(50)")>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_TableName", DbType:="VarChar(50)")>  _
	Public Property TableName() As String
		Get
			Return Me._TableName
		End Get
		Set
			If (String.Equals(Me._TableName, value) = false) Then
				Me.OnTableNameChanging(value)
				Me.SendPropertyChanging
				Me._TableName = value
				Me.SendPropertyChanged("TableName")
				Me.OnTableNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_DisplayField", DbType:="VarChar(50)")>  _
	Public Property DisplayField() As String
		Get
			Return Me._DisplayField
		End Get
		Set
			If (String.Equals(Me._DisplayField, value) = false) Then
				Me.OnDisplayFieldChanging(value)
				Me.SendPropertyChanging
				Me._DisplayField = value
				Me.SendPropertyChanged("DisplayField")
				Me.OnDisplayFieldChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ValueField", DbType:="VarChar(50)")>  _
	Public Property ValueField() As String
		Get
			Return Me._ValueField
		End Get
		Set
			If (String.Equals(Me._ValueField, value) = false) Then
				Me.OnValueFieldChanging(value)
				Me.SendPropertyChanging
				Me._ValueField = value
				Me.SendPropertyChanged("ValueField")
				Me.OnValueFieldChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_DataType", DbType:="Int")>  _
	Public Property DataType() As System.Nullable(Of Integer)
		Get
			Return Me._DataType
		End Get
		Set
			If (Me._DataType.Equals(value) = false) Then
				Me.OnDataTypeChanging(value)
				Me.SendPropertyChanging
				Me._DataType = value
				Me.SendPropertyChanged("DataType")
				Me.OnDataTypeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_FilterType", DbType:="Int")>  _
	Public Property FilterType() As System.Nullable(Of Integer)
		Get
			Return Me._FilterType
		End Get
		Set
			If (Me._FilterType.Equals(value) = false) Then
				Me.OnFilterTypeChanging(value)
				Me.SendPropertyChanging
				Me._FilterType = value
				Me.SendPropertyChanged("FilterType")
				Me.OnFilterTypeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_LookupExpression", DbType:="VarChar(200)")>  _
	Public Property LookupExpression() As String
		Get
			Return Me._LookupExpression
		End Get
		Set
			If (String.Equals(Me._LookupExpression, value) = false) Then
				Me.OnLookupExpressionChanging(value)
				Me.SendPropertyChanging
				Me._LookupExpression = value
				Me.SendPropertyChanged("LookupExpression")
				Me.OnLookupExpressionChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.ReportViewer_Users")>  _
Partial Public Class ReportViewer_User
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ReportViewerUserId As Integer
	
	Private _Name As String
	
	Private _WindowsLogin As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnReportViewerUserIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnReportViewerUserIdChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnWindowsLoginChanging(value As String)
    End Sub
    Partial Private Sub OnWindowsLoginChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_ReportViewerUserId", AutoSync:=AutoSync.Always, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ReportViewerUserId() As Integer
		Get
			Return Me._ReportViewerUserId
		End Get
		Set
			If ((Me._ReportViewerUserId = value)  _
						= false) Then
				Me.OnReportViewerUserIdChanging(value)
				Me.SendPropertyChanging
				Me._ReportViewerUserId = value
				Me.SendPropertyChanged("ReportViewerUserId")
				Me.OnReportViewerUserIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Name", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_WindowsLogin", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property WindowsLogin() As String
		Get
			Return Me._WindowsLogin
		End Get
		Set
			If (String.Equals(Me._WindowsLogin, value) = false) Then
				Me.OnWindowsLoginChanging(value)
				Me.SendPropertyChanging
				Me._WindowsLogin = value
				Me.SendPropertyChanged("WindowsLogin")
				Me.OnWindowsLoginChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.ReportViewer_AvailableReportParameterValues")>  _
Partial Public Class ReportViewer_AvailableReportParameterValue
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ReportViewerParameterValuesId As Integer
	
	Private _ParameterName As String
	
	Private _ParameterDescription As String
	
	Private _ParameterValuesSqlStatement As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnReportViewerParameterValuesIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnReportViewerParameterValuesIdChanged()
    End Sub
    Partial Private Sub OnParameterNameChanging(value As String)
    End Sub
    Partial Private Sub OnParameterNameChanged()
    End Sub
    Partial Private Sub OnParameterDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnParameterDescriptionChanged()
    End Sub
    Partial Private Sub OnParameterValuesSqlStatementChanging(value As String)
    End Sub
    Partial Private Sub OnParameterValuesSqlStatementChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_ReportViewerParameterValuesId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ReportViewerParameterValuesId() As Integer
		Get
			Return Me._ReportViewerParameterValuesId
		End Get
		Set
			If ((Me._ReportViewerParameterValuesId = value)  _
						= false) Then
				Me.OnReportViewerParameterValuesIdChanging(value)
				Me.SendPropertyChanging
				Me._ReportViewerParameterValuesId = value
				Me.SendPropertyChanged("ReportViewerParameterValuesId")
				Me.OnReportViewerParameterValuesIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ParameterName", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property ParameterName() As String
		Get
			Return Me._ParameterName
		End Get
		Set
			If (String.Equals(Me._ParameterName, value) = false) Then
				Me.OnParameterNameChanging(value)
				Me.SendPropertyChanging
				Me._ParameterName = value
				Me.SendPropertyChanged("ParameterName")
				Me.OnParameterNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ParameterDescription", DbType:="VarChar(500) NOT NULL", CanBeNull:=false)>  _
	Public Property ParameterDescription() As String
		Get
			Return Me._ParameterDescription
		End Get
		Set
			If (String.Equals(Me._ParameterDescription, value) = false) Then
				Me.OnParameterDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._ParameterDescription = value
				Me.SendPropertyChanged("ParameterDescription")
				Me.OnParameterDescriptionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ParameterValuesSqlStatement", DbType:="VarChar(4000) NOT NULL", CanBeNull:=false)>  _
	Public Property ParameterValuesSqlStatement() As String
		Get
			Return Me._ParameterValuesSqlStatement
		End Get
		Set
			If (String.Equals(Me._ParameterValuesSqlStatement, value) = false) Then
				Me.OnParameterValuesSqlStatementChanging(value)
				Me.SendPropertyChanging
				Me._ParameterValuesSqlStatement = value
				Me.SendPropertyChanged("ParameterValuesSqlStatement")
				Me.OnParameterValuesSqlStatementChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
