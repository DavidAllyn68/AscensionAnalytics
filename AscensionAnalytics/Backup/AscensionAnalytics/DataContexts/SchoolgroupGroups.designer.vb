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
Partial Public Class SchoolgroupGroupsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertschoolgroup_group(instance As schoolgroup_group)
    End Sub
  Partial Private Sub Updateschoolgroup_group(instance As schoolgroup_group)
    End Sub
  Partial Private Sub Deleteschoolgroup_group(instance As schoolgroup_group)
    End Sub
  Partial Private Sub Insertschoolgroup_group_x_schoolgroup(instance As schoolgroup_group_x_schoolgroup)
    End Sub
  Partial Private Sub Updateschoolgroup_group_x_schoolgroup(instance As schoolgroup_group_x_schoolgroup)
    End Sub
  Partial Private Sub Deleteschoolgroup_group_x_schoolgroup(instance As schoolgroup_group_x_schoolgroup)
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
	
	Public ReadOnly Property schoolgroup_groups() As System.Data.Linq.Table(Of schoolgroup_group)
		Get
			Return Me.GetTable(Of schoolgroup_group)
		End Get
	End Property
	
	Public ReadOnly Property schoolgroup_group_x_schoolgroups() As System.Data.Linq.Table(Of schoolgroup_group_x_schoolgroup)
		Get
			Return Me.GetTable(Of schoolgroup_group_x_schoolgroup)
		End Get
	End Property
	
	Public ReadOnly Property schoolgroup_group_schoolgroups() As System.Data.Linq.Table(Of schoolgroup_group_schoolgroups)
		Get
			Return Me.GetTable(Of schoolgroup_group_schoolgroups)
		End Get
	End Property
	
	<FunctionAttribute(Name:="dbo.schoolgroups_selectAssociated")>  _
	Public Function schoolgroups_selectAssociated(<Parameter(DbType:="Char(10)")> ByVal schoolgroup_group_cd As String) As ISingleResult(Of schoolgroups_selectAssociatedResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), schoolgroup_group_cd)
		Return CType(result.ReturnValue,ISingleResult(Of schoolgroups_selectAssociatedResult))
	End Function
	
	<FunctionAttribute(Name:="dbo.schoolgroups_selectNotAssociated")>  _
	Public Function schoolgroups_selectNotAssociated(<Parameter(DbType:="Char(10)")> ByVal schoolgroup_group_cd As String) As ISingleResult(Of schoolgroups_selectNotAssociatedResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), schoolgroup_group_cd)
		Return CType(result.ReturnValue,ISingleResult(Of schoolgroups_selectNotAssociatedResult))
	End Function
	
	<FunctionAttribute(Name:="dbo.schoolgroup_group_insertAssociation")>  _
	Public Function schoolgroup_group_insertAssociation(<Parameter(DbType:="Int")> ByVal schoolgroup_group_id As System.Nullable(Of Integer), <Parameter(DbType:="Char(10)")> ByVal schoolgroup_cd As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), schoolgroup_group_id, schoolgroup_cd)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<FunctionAttribute(Name:="dbo.schoolgroup_group_deleteAssociation")>  _
	Public Function schoolgroup_group_deleteAssociation(<Parameter(DbType:="Int")> ByVal schoolgroup_group_id As System.Nullable(Of Integer), <Parameter(DbType:="Char(10)")> ByVal schoolgroup_cd As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), schoolgroup_group_id, schoolgroup_cd)
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Table(Name:="dbo.schoolgroup_group")>  _
Partial Public Class schoolgroup_group
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _schoolgroup_group_id As Integer
	
	Private _schoolgroup_group_cd As String
	
	Private _schoolgroup_group_ds As String
	
	Private _is_active As System.Nullable(Of Integer)
	
	Private _schoolgroup_group_x_schoolgroups As EntitySet(Of schoolgroup_group_x_schoolgroup)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onschoolgroup_group_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onschoolgroup_group_idChanged()
    End Sub
    Partial Private Sub Onschoolgroup_group_cdChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_group_cdChanged()
    End Sub
    Partial Private Sub Onschoolgroup_group_dsChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_group_dsChanged()
    End Sub
    Partial Private Sub Onis_activeChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub Onis_activeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._schoolgroup_group_x_schoolgroups = New EntitySet(Of schoolgroup_group_x_schoolgroup)(AddressOf Me.attach_schoolgroup_group_x_schoolgroups, AddressOf Me.detach_schoolgroup_group_x_schoolgroups)
		OnCreated
	End Sub
	
	<Column(Storage:="_schoolgroup_group_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property schoolgroup_group_id() As Integer
		Get
			Return Me._schoolgroup_group_id
		End Get
		Set
			If ((Me._schoolgroup_group_id = value)  _
						= false) Then
				Me.Onschoolgroup_group_idChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_group_id = value
				Me.SendPropertyChanged("schoolgroup_group_id")
				Me.Onschoolgroup_group_idChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_group_cd", DbType:="Char(10)")>  _
	Public Property schoolgroup_group_cd() As String
		Get
			Return Me._schoolgroup_group_cd
		End Get
		Set
			If (String.Equals(Me._schoolgroup_group_cd, value) = false) Then
				Me.Onschoolgroup_group_cdChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_group_cd = value
				Me.SendPropertyChanged("schoolgroup_group_cd")
				Me.Onschoolgroup_group_cdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_group_ds", DbType:="VarChar(50)")>  _
	Public Property schoolgroup_group_ds() As String
		Get
			Return Me._schoolgroup_group_ds
		End Get
		Set
			If (String.Equals(Me._schoolgroup_group_ds, value) = false) Then
				Me.Onschoolgroup_group_dsChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_group_ds = value
				Me.SendPropertyChanged("schoolgroup_group_ds")
				Me.Onschoolgroup_group_dsChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_is_active", DbType:="Int")>  _
	Public Property is_active() As System.Nullable(Of Integer)
		Get
			Return Me._is_active
		End Get
		Set
			If (Me._is_active.Equals(value) = false) Then
				Me.Onis_activeChanging(value)
				Me.SendPropertyChanging
				Me._is_active = value
				Me.SendPropertyChanged("is_active")
				Me.Onis_activeChanged
			End If
		End Set
	End Property
	
	<Association(Name:="schoolgroup_group_schoolgroup_group_x_schoolgroup", Storage:="_schoolgroup_group_x_schoolgroups", ThisKey:="schoolgroup_group_id", OtherKey:="schoolgroup_group_id")>  _
	Public Property schoolgroup_group_x_schoolgroups() As EntitySet(Of schoolgroup_group_x_schoolgroup)
		Get
			Return Me._schoolgroup_group_x_schoolgroups
		End Get
		Set
			Me._schoolgroup_group_x_schoolgroups.Assign(value)
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
	
	Private Sub attach_schoolgroup_group_x_schoolgroups(ByVal entity As schoolgroup_group_x_schoolgroup)
		Me.SendPropertyChanging
		entity.schoolgroup_group = Me
	End Sub
	
	Private Sub detach_schoolgroup_group_x_schoolgroups(ByVal entity As schoolgroup_group_x_schoolgroup)
		Me.SendPropertyChanging
		entity.schoolgroup_group = Nothing
	End Sub
End Class

<Table(Name:="dbo.schoolgroup_group_x_schoolgroup")>  _
Partial Public Class schoolgroup_group_x_schoolgroup
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _schoolgroup_group_x_id As Integer
	
	Private _schoolgroup_group_id As System.Nullable(Of Integer)
	
	Private _schoolgroup_cd As String
	
	Private _is_active As System.Nullable(Of Integer)
	
	Private _schoolgroup_group As EntityRef(Of schoolgroup_group)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onschoolgroup_group_x_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onschoolgroup_group_x_idChanged()
    End Sub
    Partial Private Sub Onschoolgroup_group_idChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub Onschoolgroup_group_idChanged()
    End Sub
    Partial Private Sub Onschoolgroup_cdChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_cdChanged()
    End Sub
    Partial Private Sub Onis_activeChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub Onis_activeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._schoolgroup_group = CType(Nothing, EntityRef(Of schoolgroup_group))
		OnCreated
	End Sub
	
	<Column(Storage:="_schoolgroup_group_x_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property schoolgroup_group_x_id() As Integer
		Get
			Return Me._schoolgroup_group_x_id
		End Get
		Set
			If ((Me._schoolgroup_group_x_id = value)  _
						= false) Then
				Me.Onschoolgroup_group_x_idChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_group_x_id = value
				Me.SendPropertyChanged("schoolgroup_group_x_id")
				Me.Onschoolgroup_group_x_idChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_group_id", DbType:="Int")>  _
	Public Property schoolgroup_group_id() As System.Nullable(Of Integer)
		Get
			Return Me._schoolgroup_group_id
		End Get
		Set
			If (Me._schoolgroup_group_id.Equals(value) = false) Then
				If Me._schoolgroup_group.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.Onschoolgroup_group_idChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_group_id = value
				Me.SendPropertyChanged("schoolgroup_group_id")
				Me.Onschoolgroup_group_idChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_cd", DbType:="Char(10)")>  _
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
	
	<Column(Storage:="_is_active", DbType:="Int")>  _
	Public Property is_active() As System.Nullable(Of Integer)
		Get
			Return Me._is_active
		End Get
		Set
			If (Me._is_active.Equals(value) = false) Then
				Me.Onis_activeChanging(value)
				Me.SendPropertyChanging
				Me._is_active = value
				Me.SendPropertyChanged("is_active")
				Me.Onis_activeChanged
			End If
		End Set
	End Property
	
	<Association(Name:="schoolgroup_group_schoolgroup_group_x_schoolgroup", Storage:="_schoolgroup_group", ThisKey:="schoolgroup_group_id", OtherKey:="schoolgroup_group_id", IsForeignKey:=true, DeleteRule:="CASCADE")>  _
	Public Property schoolgroup_group() As schoolgroup_group
		Get
			Return Me._schoolgroup_group.Entity
		End Get
		Set
			Dim previousValue As schoolgroup_group = Me._schoolgroup_group.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._schoolgroup_group.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._schoolgroup_group.Entity = Nothing
					previousValue.schoolgroup_group_x_schoolgroups.Remove(Me)
				End If
				Me._schoolgroup_group.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.schoolgroup_group_x_schoolgroups.Add(Me)
					Me._schoolgroup_group_id = value.schoolgroup_group_id
				Else
					Me._schoolgroup_group_id = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("schoolgroup_group")
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
Partial Public Class schoolgroup_group_schoolgroups
	
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

Partial Public Class schoolgroups_selectAssociatedResult
	
	Private _prem_schoolid As Integer
	
	Private _school_nm As String
	
	Private _prem_schoolgroupid As Integer
	
	Private _claims_schoolgroupid As Short
	
	Private _schoolgroup_cd As String
	
	Private _schoolgroup_nm As String
	
	Private _schoolgroup As String
	
	Private _isConsortium As Byte
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_prem_schoolid", DbType:="Int NOT NULL")>  _
	Public Property prem_schoolid() As Integer
		Get
			Return Me._prem_schoolid
		End Get
		Set
			If ((Me._prem_schoolid = value)  _
						= false) Then
				Me._prem_schoolid = value
			End If
		End Set
	End Property
	
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
	
	<Column(Storage:="_prem_schoolgroupid", DbType:="Int NOT NULL")>  _
	Public Property prem_schoolgroupid() As Integer
		Get
			Return Me._prem_schoolgroupid
		End Get
		Set
			If ((Me._prem_schoolgroupid = value)  _
						= false) Then
				Me._prem_schoolgroupid = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_claims_schoolgroupid", DbType:="SmallInt NOT NULL")>  _
	Public Property claims_schoolgroupid() As Short
		Get
			Return Me._claims_schoolgroupid
		End Get
		Set
			If ((Me._claims_schoolgroupid = value)  _
						= false) Then
				Me._claims_schoolgroupid = value
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
	
	<Column(Storage:="_schoolgroup", DbType:="VarChar(63)")>  _
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
	
	<Column(Storage:="_isConsortium", DbType:="TinyInt NOT NULL")>  _
	Public Property isConsortium() As Byte
		Get
			Return Me._isConsortium
		End Get
		Set
			If ((Me._isConsortium = value)  _
						= false) Then
				Me._isConsortium = value
			End If
		End Set
	End Property
End Class

Partial Public Class schoolgroups_selectNotAssociatedResult
	
	Private _prem_schoolid As Integer
	
	Private _school_nm As String
	
	Private _prem_schoolgroupid As Integer
	
	Private _claims_schoolgroupid As Short
	
	Private _schoolgroup_cd As String
	
	Private _schoolgroup_nm As String
	
	Private _schoolgroup As String
	
	Private _isConsortium As Byte
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_prem_schoolid", DbType:="Int NOT NULL")>  _
	Public Property prem_schoolid() As Integer
		Get
			Return Me._prem_schoolid
		End Get
		Set
			If ((Me._prem_schoolid = value)  _
						= false) Then
				Me._prem_schoolid = value
			End If
		End Set
	End Property
	
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
	
	<Column(Storage:="_prem_schoolgroupid", DbType:="Int NOT NULL")>  _
	Public Property prem_schoolgroupid() As Integer
		Get
			Return Me._prem_schoolgroupid
		End Get
		Set
			If ((Me._prem_schoolgroupid = value)  _
						= false) Then
				Me._prem_schoolgroupid = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_claims_schoolgroupid", DbType:="SmallInt NOT NULL")>  _
	Public Property claims_schoolgroupid() As Short
		Get
			Return Me._claims_schoolgroupid
		End Get
		Set
			If ((Me._claims_schoolgroupid = value)  _
						= false) Then
				Me._claims_schoolgroupid = value
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
	
	<Column(Storage:="_schoolgroup", DbType:="VarChar(63)")>  _
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
	
	<Column(Storage:="_isConsortium", DbType:="TinyInt NOT NULL")>  _
	Public Property isConsortium() As Byte
		Get
			Return Me._isConsortium
		End Get
		Set
			If ((Me._isConsortium = value)  _
						= false) Then
				Me._isConsortium = value
			End If
		End Set
	End Property
End Class
