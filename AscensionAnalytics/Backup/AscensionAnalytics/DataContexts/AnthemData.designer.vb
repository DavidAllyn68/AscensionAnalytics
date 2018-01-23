﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5485
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
Partial Public Class AnthemDataDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertanthem_claims_summary(instance As anthem_claims_summary)
    End Sub
  Partial Private Sub Updateanthem_claims_summary(instance As anthem_claims_summary)
    End Sub
  Partial Private Sub Deleteanthem_claims_summary(instance As anthem_claims_summary)
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
	
	Public ReadOnly Property anthem_claims_summaries() As System.Data.Linq.Table(Of anthem_claims_summary)
		Get
			Return Me.GetTable(Of anthem_claims_summary)
		End Get
	End Property
	
	Public ReadOnly Property AnthemSchoolgroups() As System.Data.Linq.Table(Of AnthemSchoolgroup)
		Get
			Return Me.GetTable(Of AnthemSchoolgroup)
		End Get
	End Property
	
	<FunctionAttribute(Name:="dbo.AnthemClaimsSummary_LoadDenormForNightlyCompile")>  _
	Public Function AnthemClaimsSummary_LoadDenormForNightlyCompile() As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<FunctionAttribute(Name:="dbo.AnthemClaimsSummary_FinishAndCleanUp")>  _
	Public Function AnthemClaimsSummary_FinishAndCleanUp() As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Table(Name:="dbo.anthem_claims_summary")>  _
Partial Public Class anthem_claims_summary
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _rowIdent As Integer
	
	Private _policyyear As String
	
	Private _schoolgroup_cd As String
	
	Private _date_ending As Date
	
	Private _rx_benefit As Integer
	
	Private _paid As Decimal
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnrowIdentChanging(value As Integer)
    End Sub
    Partial Private Sub OnrowIdentChanged()
    End Sub
    Partial Private Sub OnpolicyyearChanging(value As String)
    End Sub
    Partial Private Sub OnpolicyyearChanged()
    End Sub
    Partial Private Sub Onschoolgroup_cdChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_cdChanged()
    End Sub
    Partial Private Sub Ondate_endingChanging(value As Date)
    End Sub
    Partial Private Sub Ondate_endingChanged()
    End Sub
    Partial Private Sub Onrx_benefitChanging(value As Integer)
    End Sub
    Partial Private Sub Onrx_benefitChanged()
    End Sub
    Partial Private Sub OnpaidChanging(value As Decimal)
    End Sub
    Partial Private Sub OnpaidChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_rowIdent", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property rowIdent() As Integer
		Get
			Return Me._rowIdent
		End Get
		Set
			If ((Me._rowIdent = value)  _
						= false) Then
				Me.OnrowIdentChanging(value)
				Me.SendPropertyChanging
				Me._rowIdent = value
				Me.SendPropertyChanged("rowIdent")
				Me.OnrowIdentChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_policyyear", DbType:="Char(9) NOT NULL", CanBeNull:=false)>  _
	Public Property policyyear() As String
		Get
			Return Me._policyyear
		End Get
		Set
			If (String.Equals(Me._policyyear, value) = false) Then
				Me.OnpolicyyearChanging(value)
				Me.SendPropertyChanging
				Me._policyyear = value
				Me.SendPropertyChanged("policyyear")
				Me.OnpolicyyearChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_cd", DbType:="Char(10) NOT NULL", CanBeNull:=false)>  _
	Public Property schoolgroup_cd() As String
		Get
			Return Me._schoolgroup_cd
		End Get
		Set
			If (String.Equals(Me._schoolgroup_cd, value) = false) Then
				Me.Onschoolgroup_cdChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_cd = value
				Me.SendPropertyChanged("schoolgroup_cd")
				Me.Onschoolgroup_cdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_date_ending", DbType:="SmallDateTime NOT NULL")>  _
	Public Property date_ending() As Date
		Get
			Return Me._date_ending
		End Get
		Set
			If ((Me._date_ending = value)  _
						= false) Then
				Me.Ondate_endingChanging(value)
				Me.SendPropertyChanging
				Me._date_ending = value
				Me.SendPropertyChanged("date_ending")
				Me.Ondate_endingChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_rx_benefit", DbType:="Int NOT NULL")>  _
	Public Property rx_benefit() As Integer
		Get
			Return Me._rx_benefit
		End Get
		Set
			If ((Me._rx_benefit = value)  _
						= false) Then
				Me.Onrx_benefitChanging(value)
				Me.SendPropertyChanging
				Me._rx_benefit = value
				Me.SendPropertyChanged("rx_benefit")
				Me.Onrx_benefitChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_paid", DbType:="Money NOT NULL")>  _
	Public Property paid() As Decimal
		Get
			Return Me._paid
		End Get
		Set
			If ((Me._paid = value)  _
						= false) Then
				Me.OnpaidChanging(value)
				Me.SendPropertyChanging
				Me._paid = value
				Me.SendPropertyChanged("paid")
				Me.OnpaidChanged
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

<Table(Name:="dbo.schoolgroups")>  _
Partial Public Class AnthemSchoolgroup
	
	Private _school_nm As String
	
	Private _schoolgroup_cd As String
	
	Private _schoolgroup_nm As String
	
	Private _schoolgroup As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_school_nm", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property school_nm() As String
		Get
			Return Me._school_nm
		End Get
		Set
			If (String.Equals(Me._school_nm, value) = false) Then
				Me._school_nm = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_cd", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property schoolgroup_cd() As String
		Get
			Return Me._schoolgroup_cd
		End Get
		Set
			If (String.Equals(Me._schoolgroup_cd, value) = false) Then
				Me._schoolgroup_cd = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_nm", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property schoolgroup_nm() As String
		Get
			Return Me._schoolgroup_nm
		End Get
		Set
			If (String.Equals(Me._schoolgroup_nm, value) = false) Then
				Me._schoolgroup_nm = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup", DbType:="VarChar(103)")>  _
	Public Property schoolgroup() As String
		Get
			Return Me._schoolgroup
		End Get
		Set
			If (String.Equals(Me._schoolgroup, value) = false) Then
				Me._schoolgroup = value
			End If
		End Set
	End Property
End Class