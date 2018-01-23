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
Partial Public Class GeneralStatisticsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertGeneralStatistics_Statistic(instance As GeneralStatistics_Statistic)
    End Sub
  Partial Private Sub UpdateGeneralStatistics_Statistic(instance As GeneralStatistics_Statistic)
    End Sub
  Partial Private Sub DeleteGeneralStatistics_Statistic(instance As GeneralStatistics_Statistic)
    End Sub
  Partial Private Sub InsertGeneralStatistics_Category(instance As GeneralStatistics_Category)
    End Sub
  Partial Private Sub UpdateGeneralStatistics_Category(instance As GeneralStatistics_Category)
    End Sub
  Partial Private Sub DeleteGeneralStatistics_Category(instance As GeneralStatistics_Category)
    End Sub
  Partial Private Sub InsertGeneralStatistics_DevelopedStatistic(instance As GeneralStatistics_DevelopedStatistic)
    End Sub
  Partial Private Sub UpdateGeneralStatistics_DevelopedStatistic(instance As GeneralStatistics_DevelopedStatistic)
    End Sub
  Partial Private Sub DeleteGeneralStatistics_DevelopedStatistic(instance As GeneralStatistics_DevelopedStatistic)
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
	
	Public ReadOnly Property GeneralStatistics_Statistics() As System.Data.Linq.Table(Of GeneralStatistics_Statistic)
		Get
			Return Me.GetTable(Of GeneralStatistics_Statistic)
		End Get
	End Property
	
	Public ReadOnly Property GeneralStatistics_Categories() As System.Data.Linq.Table(Of GeneralStatistics_Category)
		Get
			Return Me.GetTable(Of GeneralStatistics_Category)
		End Get
	End Property
	
	Public ReadOnly Property GeneralStatistics_DevelopedStatistics() As System.Data.Linq.Table(Of GeneralStatistics_DevelopedStatistic)
		Get
			Return Me.GetTable(Of GeneralStatistics_DevelopedStatistic)
		End Get
	End Property
	
	<FunctionAttribute(Name:="dbo.GeneralStatistics_DevelopStatistic")>  _
	Public Function GeneralStatistics_DevelopStatistic(<Parameter(Name:="GeneralStatisticId", DbType:="Int")> ByVal generalStatisticId As System.Nullable(Of Integer)) As ISingleResult(Of GeneralStatistics_DevelopStatisticResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), generalStatisticId)
		Return CType(result.ReturnValue,ISingleResult(Of GeneralStatistics_DevelopStatisticResult))
	End Function
	
	<FunctionAttribute(Name:="dbo.GeneralStatistics_DevelopStatisticsForAll")>  _
	Public Function GeneralStatistics_DevelopStatisticsForAll() As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<FunctionAttribute(Name:="dbo.GeneralStatistics_DevelopStatisticsForCategoryId")>  _
	Public Function GeneralStatistics_DevelopStatisticsForCategoryId(<Parameter(Name:="CategoryId", DbType:="Int")> ByVal categoryId As System.Nullable(Of Integer)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), categoryId)
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Table(Name:="dbo.GeneralStatistics_Statistics")>  _
Partial Public Class GeneralStatistics_Statistic
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _GeneralStatisticId As Integer
	
	Private _Name As String
	
	Private _DevelopmentSQL As String
	
	Private _GeneralStatisticCategoryId As Integer
	
	Private _GeneralStatistics_DevelopedStatistics As EntitySet(Of GeneralStatistics_DevelopedStatistic)
	
	Private _GeneralStatistics_Category As EntityRef(Of GeneralStatistics_Category)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnGeneralStatisticIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnGeneralStatisticIdChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnDevelopmentSQLChanging(value As String)
    End Sub
    Partial Private Sub OnDevelopmentSQLChanged()
    End Sub
    Partial Private Sub OnGeneralStatisticsCategoryIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnGeneralStatisticsCategoryIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._GeneralStatistics_DevelopedStatistics = New EntitySet(Of GeneralStatistics_DevelopedStatistic)(AddressOf Me.attach_GeneralStatistics_DevelopedStatistics, AddressOf Me.detach_GeneralStatistics_DevelopedStatistics)
		Me._GeneralStatistics_Category = CType(Nothing, EntityRef(Of GeneralStatistics_Category))
		OnCreated
	End Sub
	
	<Column(Storage:="_GeneralStatisticId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property GeneralStatisticId() As Integer
		Get
			Return Me._GeneralStatisticId
		End Get
		Set
			If ((Me._GeneralStatisticId = value)  _
						= false) Then
				Me.OnGeneralStatisticIdChanging(value)
				Me.SendPropertyChanging
				Me._GeneralStatisticId = value
				Me.SendPropertyChanged("GeneralStatisticId")
				Me.OnGeneralStatisticIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Name", DbType:="VarChar(500) NOT NULL", CanBeNull:=false)>  _
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
	
	<Column(Storage:="_DevelopmentSQL", DbType:="VarChar(8000) NOT NULL", CanBeNull:=false)>  _
	Public Property DevelopmentSQL() As String
		Get
			Return Me._DevelopmentSQL
		End Get
		Set
			If (String.Equals(Me._DevelopmentSQL, value) = false) Then
				Me.OnDevelopmentSQLChanging(value)
				Me.SendPropertyChanging
				Me._DevelopmentSQL = value
				Me.SendPropertyChanged("DevelopmentSQL")
				Me.OnDevelopmentSQLChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_GeneralStatisticCategoryId", DbType:="Int NOT NULL")>  _
	Public Property GeneralStatisticsCategoryId() As Integer
		Get
			Return Me._GeneralStatisticCategoryId
		End Get
		Set
			If ((Me._GeneralStatisticCategoryId = value)  _
						= false) Then
				If Me._GeneralStatistics_Category.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnGeneralStatisticsCategoryIdChanging(value)
				Me.SendPropertyChanging
				Me._GeneralStatisticCategoryId = value
				Me.SendPropertyChanged("GeneralStatisticsCategoryId")
				Me.OnGeneralStatisticsCategoryIdChanged
			End If
		End Set
	End Property
	
	<Association(Name:="GeneralStatistics_Statistic_GeneralStatistics_DevelopedStatistic", Storage:="_GeneralStatistics_DevelopedStatistics", ThisKey:="GeneralStatisticId", OtherKey:="GeneralStatisticId")>  _
	Public Property GeneralStatistics_DevelopedStatistics() As EntitySet(Of GeneralStatistics_DevelopedStatistic)
		Get
			Return Me._GeneralStatistics_DevelopedStatistics
		End Get
		Set
			Me._GeneralStatistics_DevelopedStatistics.Assign(value)
		End Set
	End Property
	
	<Association(Name:="GeneralStatistics_Category_GeneralStatistics_Statistic", Storage:="_GeneralStatistics_Category", ThisKey:="GeneralStatisticsCategoryId", OtherKey:="GeneralStatisticsCategoryId", IsForeignKey:=true)>  _
	Public Property GeneralStatistics_Category() As GeneralStatistics_Category
		Get
			Return Me._GeneralStatistics_Category.Entity
		End Get
		Set
			Dim previousValue As GeneralStatistics_Category = Me._GeneralStatistics_Category.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._GeneralStatistics_Category.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._GeneralStatistics_Category.Entity = Nothing
					previousValue.GeneralStatistics_Statistics.Remove(Me)
				End If
				Me._GeneralStatistics_Category.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.GeneralStatistics_Statistics.Add(Me)
					Me._GeneralStatisticCategoryId = value.GeneralStatisticsCategoryId
				Else
					Me._GeneralStatisticCategoryId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("GeneralStatistics_Category")
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
	
	Private Sub attach_GeneralStatistics_DevelopedStatistics(ByVal entity As GeneralStatistics_DevelopedStatistic)
		Me.SendPropertyChanging
		entity.GeneralStatistics_Statistic = Me
	End Sub
	
	Private Sub detach_GeneralStatistics_DevelopedStatistics(ByVal entity As GeneralStatistics_DevelopedStatistic)
		Me.SendPropertyChanging
		entity.GeneralStatistics_Statistic = Nothing
	End Sub
End Class

<Table(Name:="dbo.GeneralStatistics_Categories")>  _
Partial Public Class GeneralStatistics_Category
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _GeneralStatisticsCategoryId As Integer
	
	Private _StatisticsCategory As String
	
	Private _GeneralStatistics_Statistics As EntitySet(Of GeneralStatistics_Statistic)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnGeneralStatisticsCategoryIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnGeneralStatisticsCategoryIdChanged()
    End Sub
    Partial Private Sub OnStatisticsCategoryChanging(value As String)
    End Sub
    Partial Private Sub OnStatisticsCategoryChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._GeneralStatistics_Statistics = New EntitySet(Of GeneralStatistics_Statistic)(AddressOf Me.attach_GeneralStatistics_Statistics, AddressOf Me.detach_GeneralStatistics_Statistics)
		OnCreated
	End Sub
	
	<Column(Storage:="_GeneralStatisticsCategoryId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property GeneralStatisticsCategoryId() As Integer
		Get
			Return Me._GeneralStatisticsCategoryId
		End Get
		Set
			If ((Me._GeneralStatisticsCategoryId = value)  _
						= false) Then
				Me.OnGeneralStatisticsCategoryIdChanging(value)
				Me.SendPropertyChanging
				Me._GeneralStatisticsCategoryId = value
				Me.SendPropertyChanged("GeneralStatisticsCategoryId")
				Me.OnGeneralStatisticsCategoryIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_StatisticsCategory", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property StatisticsCategory() As String
		Get
			Return Me._StatisticsCategory
		End Get
		Set
			If (String.Equals(Me._StatisticsCategory, value) = false) Then
				Me.OnStatisticsCategoryChanging(value)
				Me.SendPropertyChanging
				Me._StatisticsCategory = value
				Me.SendPropertyChanged("StatisticsCategory")
				Me.OnStatisticsCategoryChanged
			End If
		End Set
	End Property
	
	<Association(Name:="GeneralStatistics_Category_GeneralStatistics_Statistic", Storage:="_GeneralStatistics_Statistics", ThisKey:="GeneralStatisticsCategoryId", OtherKey:="GeneralStatisticsCategoryId")>  _
	Public Property GeneralStatistics_Statistics() As EntitySet(Of GeneralStatistics_Statistic)
		Get
			Return Me._GeneralStatistics_Statistics
		End Get
		Set
			Me._GeneralStatistics_Statistics.Assign(value)
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
	
	Private Sub attach_GeneralStatistics_Statistics(ByVal entity As GeneralStatistics_Statistic)
		Me.SendPropertyChanging
		entity.GeneralStatistics_Category = Me
	End Sub
	
	Private Sub detach_GeneralStatistics_Statistics(ByVal entity As GeneralStatistics_Statistic)
		Me.SendPropertyChanging
		entity.GeneralStatistics_Category = Nothing
	End Sub
End Class

<Table(Name:="dbo.GeneralStatistics_DevelopedStatistics")>  _
Partial Public Class GeneralStatistics_DevelopedStatistic
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _GeneralStatisticsDevelopmentId As Integer
	
	Private _GeneralStatisticId As Integer
	
	Private _Result As String
	
	Private _DevelopmentTime As Date
	
	Private _GeneralStatistics_Statistic As EntityRef(Of GeneralStatistics_Statistic)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnGeneralStatisticsDevelopmentIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnGeneralStatisticsDevelopmentIdChanged()
    End Sub
    Partial Private Sub OnGeneralStatisticIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnGeneralStatisticIdChanged()
    End Sub
    Partial Private Sub OnResultChanging(value As String)
    End Sub
    Partial Private Sub OnResultChanged()
    End Sub
    Partial Private Sub OnDevelopmentTimeChanging(value As Date)
    End Sub
    Partial Private Sub OnDevelopmentTimeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._GeneralStatistics_Statistic = CType(Nothing, EntityRef(Of GeneralStatistics_Statistic))
		OnCreated
	End Sub
	
	<Column(Storage:="_GeneralStatisticsDevelopmentId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property GeneralStatisticsDevelopmentId() As Integer
		Get
			Return Me._GeneralStatisticsDevelopmentId
		End Get
		Set
			If ((Me._GeneralStatisticsDevelopmentId = value)  _
						= false) Then
				Me.OnGeneralStatisticsDevelopmentIdChanging(value)
				Me.SendPropertyChanging
				Me._GeneralStatisticsDevelopmentId = value
				Me.SendPropertyChanged("GeneralStatisticsDevelopmentId")
				Me.OnGeneralStatisticsDevelopmentIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_GeneralStatisticId", DbType:="Int NOT NULL")>  _
	Public Property GeneralStatisticId() As Integer
		Get
			Return Me._GeneralStatisticId
		End Get
		Set
			If ((Me._GeneralStatisticId = value)  _
						= false) Then
				If Me._GeneralStatistics_Statistic.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnGeneralStatisticIdChanging(value)
				Me.SendPropertyChanging
				Me._GeneralStatisticId = value
				Me.SendPropertyChanged("GeneralStatisticId")
				Me.OnGeneralStatisticIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Result", DbType:="VarChar(2000) NOT NULL", CanBeNull:=false)>  _
	Public Property Result() As String
		Get
			Return Me._Result
		End Get
		Set
			If (String.Equals(Me._Result, value) = false) Then
				Me.OnResultChanging(value)
				Me.SendPropertyChanging
				Me._Result = value
				Me.SendPropertyChanged("Result")
				Me.OnResultChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_DevelopmentTime", DbType:="SmallDateTime NOT NULL")>  _
	Public Property DevelopmentTime() As Date
		Get
			Return Me._DevelopmentTime
		End Get
		Set
			If ((Me._DevelopmentTime = value)  _
						= false) Then
				Me.OnDevelopmentTimeChanging(value)
				Me.SendPropertyChanging
				Me._DevelopmentTime = value
				Me.SendPropertyChanged("DevelopmentTime")
				Me.OnDevelopmentTimeChanged
			End If
		End Set
	End Property
	
	<Association(Name:="GeneralStatistics_Statistic_GeneralStatistics_DevelopedStatistic", Storage:="_GeneralStatistics_Statistic", ThisKey:="GeneralStatisticId", OtherKey:="GeneralStatisticId", IsForeignKey:=true)>  _
	Public Property GeneralStatistics_Statistic() As GeneralStatistics_Statistic
		Get
			Return Me._GeneralStatistics_Statistic.Entity
		End Get
		Set
			Dim previousValue As GeneralStatistics_Statistic = Me._GeneralStatistics_Statistic.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._GeneralStatistics_Statistic.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._GeneralStatistics_Statistic.Entity = Nothing
					previousValue.GeneralStatistics_DevelopedStatistics.Remove(Me)
				End If
				Me._GeneralStatistics_Statistic.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.GeneralStatistics_DevelopedStatistics.Add(Me)
					Me._GeneralStatisticId = value.GeneralStatisticId
				Else
					Me._GeneralStatisticId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("GeneralStatistics_Statistic")
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

Partial Public Class GeneralStatistics_DevelopStatisticResult
	
	Private _DevelopedStatistic As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_DevelopedStatistic", DbType:="VarChar(2000)")>  _
	Public Property DevelopedStatistic() As String
		Get
			Return Me._DevelopedStatistic
		End Get
		Set
			If (String.Equals(Me._DevelopedStatistic, value) = false) Then
				Me._DevelopedStatistic = value
			End If
		End Set
	End Property
End Class
