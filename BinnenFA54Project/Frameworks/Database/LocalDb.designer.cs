﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if LOCAL_DATABASE
namespace BinnenFA54Project.Frameworks.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LocalBinnenschifffahrt")]
	public partial class LocalDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
#region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertT_SBF_Binnen(T_SBF_Binnen instance);
    partial void UpdateT_SBF_Binnen(T_SBF_Binnen instance);
    partial void DeleteT_SBF_Binnen(T_SBF_Binnen instance);
    partial void InsertT_Fragenbogen_Thema(T_Fragenbogen_Thema instance);
    partial void UpdateT_Fragenbogen_Thema(T_Fragenbogen_Thema instance);
    partial void DeleteT_Fragenbogen_Thema(T_Fragenbogen_Thema instance);
#endregion
		
		public LocalDbDataContext() : 
				base(global::BinnenFA54Project.Properties.Settings.Default.LocalBinnenschifffahrtConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LocalDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LocalDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LocalDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LocalDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<T_Fragebogen_unter_Maschine> T_Fragebogen_unter_Maschines
		{
			get
			{
				return this.GetTable<T_Fragebogen_unter_Maschine>();
			}
		}
		
		public System.Data.Linq.Table<T_SBF_Binnen> T_SBF_Binnens
		{
			get
			{
				return this.GetTable<T_SBF_Binnen>();
			}
		}
		
		public System.Data.Linq.Table<T_Fragenbogen_Thema> T_Fragenbogen_Themas
		{
			get
			{
				return this.GetTable<T_Fragenbogen_Thema>();
			}
		}
		
		public System.Data.Linq.Table<View_Topics_And_Question> View_Topics_And_Questions
		{
			get
			{
				return this.GetTable<View_Topics_And_Question>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Fragebogen_unter_Maschine")]
	public partial class T_Fragebogen_unter_Maschine
	{
		
		private int _FragebogenNr;
		
		private int _F_Id_SBF_Binnen;
		
		public T_Fragebogen_unter_Maschine()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FragebogenNr", DbType="Int NOT NULL")]
		public int FragebogenNr
		{
			get
			{
				return this._FragebogenNr;
			}
			set
			{
				if ((this._FragebogenNr != value))
				{
					this._FragebogenNr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_F_Id_SBF_Binnen", DbType="Int NOT NULL")]
		public int F_Id_SBF_Binnen
		{
			get
			{
				return this._F_Id_SBF_Binnen;
			}
			set
			{
				if ((this._F_Id_SBF_Binnen != value))
				{
					this._F_Id_SBF_Binnen = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_SBF_Binnen")]
	public partial class T_SBF_Binnen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_Id;
		
		private string _Frage;
		
		private string _Antwort1;
		
		private string _Antwort2;
		
		private string _Antwort3;
		
		private string _Antwort4;
		
		private System.Nullable<byte> _RichtigeAntwort;
		
#region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IdChanging(int value);
    partial void OnP_IdChanged();
    partial void OnFrageChanging(string value);
    partial void OnFrageChanged();
    partial void OnAntwort1Changing(string value);
    partial void OnAntwort1Changed();
    partial void OnAntwort2Changing(string value);
    partial void OnAntwort2Changed();
    partial void OnAntwort3Changing(string value);
    partial void OnAntwort3Changed();
    partial void OnAntwort4Changing(string value);
    partial void OnAntwort4Changed();
    partial void OnRichtigeAntwortChanging(System.Nullable<byte> value);
    partial void OnRichtigeAntwortChanged();
#endregion
		
		public T_SBF_Binnen()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_Id
		{
			get
			{
				return this._P_Id;
			}
			set
			{
				if ((this._P_Id != value))
				{
					this.OnP_IdChanging(value);
					this.SendPropertyChanging();
					this._P_Id = value;
					this.SendPropertyChanged("P_Id");
					this.OnP_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frage", DbType="VarChar(500)")]
		public string Frage
		{
			get
			{
				return this._Frage;
			}
			set
			{
				if ((this._Frage != value))
				{
					this.OnFrageChanging(value);
					this.SendPropertyChanging();
					this._Frage = value;
					this.SendPropertyChanged("Frage");
					this.OnFrageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort1", DbType="VarChar(500)")]
		public string Antwort1
		{
			get
			{
				return this._Antwort1;
			}
			set
			{
				if ((this._Antwort1 != value))
				{
					this.OnAntwort1Changing(value);
					this.SendPropertyChanging();
					this._Antwort1 = value;
					this.SendPropertyChanged("Antwort1");
					this.OnAntwort1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort2", DbType="VarChar(500)")]
		public string Antwort2
		{
			get
			{
				return this._Antwort2;
			}
			set
			{
				if ((this._Antwort2 != value))
				{
					this.OnAntwort2Changing(value);
					this.SendPropertyChanging();
					this._Antwort2 = value;
					this.SendPropertyChanged("Antwort2");
					this.OnAntwort2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort3", DbType="VarChar(500)")]
		public string Antwort3
		{
			get
			{
				return this._Antwort3;
			}
			set
			{
				if ((this._Antwort3 != value))
				{
					this.OnAntwort3Changing(value);
					this.SendPropertyChanging();
					this._Antwort3 = value;
					this.SendPropertyChanged("Antwort3");
					this.OnAntwort3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort4", DbType="VarChar(500)")]
		public string Antwort4
		{
			get
			{
				return this._Antwort4;
			}
			set
			{
				if ((this._Antwort4 != value))
				{
					this.OnAntwort4Changing(value);
					this.SendPropertyChanging();
					this._Antwort4 = value;
					this.SendPropertyChanged("Antwort4");
					this.OnAntwort4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RichtigeAntwort", DbType="TinyInt")]
		public System.Nullable<byte> RichtigeAntwort
		{
			get
			{
				return this._RichtigeAntwort;
			}
			set
			{
				if ((this._RichtigeAntwort != value))
				{
					this.OnRichtigeAntwortChanging(value);
					this.SendPropertyChanging();
					this._RichtigeAntwort = value;
					this.SendPropertyChanged("RichtigeAntwort");
					this.OnRichtigeAntwortChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Fragenbogen_Thema")]
	public partial class T_Fragenbogen_Thema : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FragebogenNr;
		
		private string _Thema;
		
		private string _Beschreib;
		
#region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFragebogenNrChanging(int value);
    partial void OnFragebogenNrChanged();
    partial void OnThemaChanging(string value);
    partial void OnThemaChanged();
    partial void OnBeschreibChanging(string value);
    partial void OnBeschreibChanged();
#endregion
		
		public T_Fragenbogen_Thema()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FragebogenNr", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int FragebogenNr
		{
			get
			{
				return this._FragebogenNr;
			}
			set
			{
				if ((this._FragebogenNr != value))
				{
					this.OnFragebogenNrChanging(value);
					this.SendPropertyChanging();
					this._FragebogenNr = value;
					this.SendPropertyChanged("FragebogenNr");
					this.OnFragebogenNrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thema", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Thema
		{
			get
			{
				return this._Thema;
			}
			set
			{
				if ((this._Thema != value))
				{
					this.OnThemaChanging(value);
					this.SendPropertyChanging();
					this._Thema = value;
					this.SendPropertyChanged("Thema");
					this.OnThemaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Beschreib", DbType="NChar(100)")]
		public string Beschreib
		{
			get
			{
				return this._Beschreib;
			}
			set
			{
				if ((this._Beschreib != value))
				{
					this.OnBeschreibChanging(value);
					this.SendPropertyChanging();
					this._Beschreib = value;
					this.SendPropertyChanged("Beschreib");
					this.OnBeschreibChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Topics_And_Questions")]
	public partial class View_Topics_And_Question
	{
		
		private int _P_Id;
		
		private string _Frage;
		
		private string _Antwort1;
		
		private string _Antwort2;
		
		private string _Antwort3;
		
		private string _Antwort4;
		
		private int _FragebogenNr;
		
		private System.Nullable<byte> _RichtigeAntwort;
		
		public View_Topics_And_Question()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Id", DbType="Int NOT NULL")]
		public int P_Id
		{
			get
			{
				return this._P_Id;
			}
			set
			{
				if ((this._P_Id != value))
				{
					this._P_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frage", DbType="VarChar(500)")]
		public string Frage
		{
			get
			{
				return this._Frage;
			}
			set
			{
				if ((this._Frage != value))
				{
					this._Frage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort1", DbType="VarChar(500)")]
		public string Antwort1
		{
			get
			{
				return this._Antwort1;
			}
			set
			{
				if ((this._Antwort1 != value))
				{
					this._Antwort1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort2", DbType="VarChar(500)")]
		public string Antwort2
		{
			get
			{
				return this._Antwort2;
			}
			set
			{
				if ((this._Antwort2 != value))
				{
					this._Antwort2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort3", DbType="VarChar(500)")]
		public string Antwort3
		{
			get
			{
				return this._Antwort3;
			}
			set
			{
				if ((this._Antwort3 != value))
				{
					this._Antwort3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Antwort4", DbType="VarChar(500)")]
		public string Antwort4
		{
			get
			{
				return this._Antwort4;
			}
			set
			{
				if ((this._Antwort4 != value))
				{
					this._Antwort4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FragebogenNr", DbType="Int NOT NULL")]
		public int FragebogenNr
		{
			get
			{
				return this._FragebogenNr;
			}
			set
			{
				if ((this._FragebogenNr != value))
				{
					this._FragebogenNr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RichtigeAntwort", DbType="TinyInt")]
		public System.Nullable<byte> RichtigeAntwort
		{
			get
			{
				return this._RichtigeAntwort;
			}
			set
			{
				if ((this._RichtigeAntwort != value))
				{
					this._RichtigeAntwort = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
#endif