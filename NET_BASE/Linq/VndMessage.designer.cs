﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test")]
	public partial class VndMessageDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public VndMessageDataContext() : 
				base(global::Linq.Properties.Settings.Default.TestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VndMessageDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VndMessageDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VndMessageDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VndMessageDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VndMessage> VndMessage
		{
			get
			{
				return this.GetTable<VndMessage>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VndMessage")]
	public partial class VndMessage
	{
		
		private string _VndID;
		
		private string _VndName;
		
		private string _Address;
		
		private string _Contacts;
		
		private string _Phone;
		
		private string _Email;
		
		public VndMessage()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VndID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string VndID
		{
			get
			{
				return this._VndID;
			}
			set
			{
				if ((this._VndID != value))
				{
					this._VndID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VndName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string VndName
		{
			get
			{
				return this._VndName;
			}
			set
			{
				if ((this._VndName != value))
				{
					this._VndName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(500)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contacts", DbType="NVarChar(10)")]
		public string Contacts
		{
			get
			{
				return this._Contacts;
			}
			set
			{
				if ((this._Contacts != value))
				{
					this._Contacts = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(20)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
