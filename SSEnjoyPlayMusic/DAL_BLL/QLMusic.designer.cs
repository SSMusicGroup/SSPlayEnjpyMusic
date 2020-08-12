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

namespace DAL_BLL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_Music")]
	public partial class QLMusicDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBaiHat(BaiHat instance);
    partial void UpdateBaiHat(BaiHat instance);
    partial void DeleteBaiHat(BaiHat instance);
    partial void InsertPlaylist(Playlist instance);
    partial void UpdatePlaylist(Playlist instance);
    partial void DeletePlaylist(Playlist instance);
    partial void InsertBaiHatVaPlayList(BaiHatVaPlayList instance);
    partial void UpdateBaiHatVaPlayList(BaiHatVaPlayList instance);
    partial void DeleteBaiHatVaPlayList(BaiHatVaPlayList instance);
    partial void InsertCaSi(CaSi instance);
    partial void UpdateCaSi(CaSi instance);
    partial void DeleteCaSi(CaSi instance);
    #endregion
		
		public QLMusicDataContext() : 
				base(global::DAL_BLL.Properties.Settings.Default.QL_MusicConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLMusicDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLMusicDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLMusicDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLMusicDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BaiHat> BaiHats
		{
			get
			{
				return this.GetTable<BaiHat>();
			}
		}
		
		public System.Data.Linq.Table<Playlist> Playlists
		{
			get
			{
				return this.GetTable<Playlist>();
			}
		}
		
		public System.Data.Linq.Table<BaiHatVaPlayList> BaiHatVaPlayLists
		{
			get
			{
				return this.GetTable<BaiHatVaPlayList>();
			}
		}
		
		public System.Data.Linq.Table<CaSi> CaSis
		{
			get
			{
				return this.GetTable<CaSi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BaiHat")]
	public partial class BaiHat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maBaiHat;
		
		private string _tenBaiHat;
		
		private string _maCaSi;
		
		private string _pathBaiHat;
		
		private EntitySet<BaiHatVaPlayList> _BaiHatVaPlayLists;
		
		private EntityRef<CaSi> _CaSi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaBaiHatChanging(string value);
    partial void OnmaBaiHatChanged();
    partial void OntenBaiHatChanging(string value);
    partial void OntenBaiHatChanged();
    partial void OnmaCaSiChanging(string value);
    partial void OnmaCaSiChanged();
    partial void OnpathBaiHatChanging(string value);
    partial void OnpathBaiHatChanged();
    #endregion
		
		public BaiHat()
		{
			this._BaiHatVaPlayLists = new EntitySet<BaiHatVaPlayList>(new Action<BaiHatVaPlayList>(this.attach_BaiHatVaPlayLists), new Action<BaiHatVaPlayList>(this.detach_BaiHatVaPlayLists));
			this._CaSi = default(EntityRef<CaSi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maBaiHat", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maBaiHat
		{
			get
			{
				return this._maBaiHat;
			}
			set
			{
				if ((this._maBaiHat != value))
				{
					this.OnmaBaiHatChanging(value);
					this.SendPropertyChanging();
					this._maBaiHat = value;
					this.SendPropertyChanged("maBaiHat");
					this.OnmaBaiHatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenBaiHat", DbType="NVarChar(50)")]
		public string tenBaiHat
		{
			get
			{
				return this._tenBaiHat;
			}
			set
			{
				if ((this._tenBaiHat != value))
				{
					this.OntenBaiHatChanging(value);
					this.SendPropertyChanging();
					this._tenBaiHat = value;
					this.SendPropertyChanged("tenBaiHat");
					this.OntenBaiHatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maCaSi", DbType="NChar(10)")]
		public string maCaSi
		{
			get
			{
				return this._maCaSi;
			}
			set
			{
				if ((this._maCaSi != value))
				{
					if (this._CaSi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaCaSiChanging(value);
					this.SendPropertyChanging();
					this._maCaSi = value;
					this.SendPropertyChanged("maCaSi");
					this.OnmaCaSiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pathBaiHat", DbType="NChar(100)")]
		public string pathBaiHat
		{
			get
			{
				return this._pathBaiHat;
			}
			set
			{
				if ((this._pathBaiHat != value))
				{
					this.OnpathBaiHatChanging(value);
					this.SendPropertyChanging();
					this._pathBaiHat = value;
					this.SendPropertyChanged("pathBaiHat");
					this.OnpathBaiHatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BaiHat_BaiHatVaPlayList", Storage="_BaiHatVaPlayLists", ThisKey="maBaiHat", OtherKey="maBaiHat")]
		public EntitySet<BaiHatVaPlayList> BaiHatVaPlayLists
		{
			get
			{
				return this._BaiHatVaPlayLists;
			}
			set
			{
				this._BaiHatVaPlayLists.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CaSi_BaiHat", Storage="_CaSi", ThisKey="maCaSi", OtherKey="maCaSi", IsForeignKey=true)]
		public CaSi CaSi
		{
			get
			{
				return this._CaSi.Entity;
			}
			set
			{
				CaSi previousValue = this._CaSi.Entity;
				if (((previousValue != value) 
							|| (this._CaSi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CaSi.Entity = null;
						previousValue.BaiHats.Remove(this);
					}
					this._CaSi.Entity = value;
					if ((value != null))
					{
						value.BaiHats.Add(this);
						this._maCaSi = value.maCaSi;
					}
					else
					{
						this._maCaSi = default(string);
					}
					this.SendPropertyChanged("CaSi");
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
		
		private void attach_BaiHatVaPlayLists(BaiHatVaPlayList entity)
		{
			this.SendPropertyChanging();
			entity.BaiHat = this;
		}
		
		private void detach_BaiHatVaPlayLists(BaiHatVaPlayList entity)
		{
			this.SendPropertyChanging();
			entity.BaiHat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Playlist")]
	public partial class Playlist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maPlaylist;
		
		private string _tenPlaylist;
		
		private EntitySet<BaiHatVaPlayList> _BaiHatVaPlayLists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaPlaylistChanging(string value);
    partial void OnmaPlaylistChanged();
    partial void OntenPlaylistChanging(string value);
    partial void OntenPlaylistChanged();
    #endregion
		
		public Playlist()
		{
			this._BaiHatVaPlayLists = new EntitySet<BaiHatVaPlayList>(new Action<BaiHatVaPlayList>(this.attach_BaiHatVaPlayLists), new Action<BaiHatVaPlayList>(this.detach_BaiHatVaPlayLists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maPlaylist", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maPlaylist
		{
			get
			{
				return this._maPlaylist;
			}
			set
			{
				if ((this._maPlaylist != value))
				{
					this.OnmaPlaylistChanging(value);
					this.SendPropertyChanging();
					this._maPlaylist = value;
					this.SendPropertyChanged("maPlaylist");
					this.OnmaPlaylistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenPlaylist", DbType="NVarChar(50)")]
		public string tenPlaylist
		{
			get
			{
				return this._tenPlaylist;
			}
			set
			{
				if ((this._tenPlaylist != value))
				{
					this.OntenPlaylistChanging(value);
					this.SendPropertyChanging();
					this._tenPlaylist = value;
					this.SendPropertyChanged("tenPlaylist");
					this.OntenPlaylistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Playlist_BaiHatVaPlayList", Storage="_BaiHatVaPlayLists", ThisKey="maPlaylist", OtherKey="maPlaylist")]
		public EntitySet<BaiHatVaPlayList> BaiHatVaPlayLists
		{
			get
			{
				return this._BaiHatVaPlayLists;
			}
			set
			{
				this._BaiHatVaPlayLists.Assign(value);
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
		
		private void attach_BaiHatVaPlayLists(BaiHatVaPlayList entity)
		{
			this.SendPropertyChanging();
			entity.Playlist = this;
		}
		
		private void detach_BaiHatVaPlayLists(BaiHatVaPlayList entity)
		{
			this.SendPropertyChanging();
			entity.Playlist = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BaiHatVaPlayList")]
	public partial class BaiHatVaPlayList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maBaiHat;
		
		private string _maPlaylist;
		
		private EntityRef<BaiHat> _BaiHat;
		
		private EntityRef<Playlist> _Playlist;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaBaiHatChanging(string value);
    partial void OnmaBaiHatChanged();
    partial void OnmaPlaylistChanging(string value);
    partial void OnmaPlaylistChanged();
    #endregion
		
		public BaiHatVaPlayList()
		{
			this._BaiHat = default(EntityRef<BaiHat>);
			this._Playlist = default(EntityRef<Playlist>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maBaiHat", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maBaiHat
		{
			get
			{
				return this._maBaiHat;
			}
			set
			{
				if ((this._maBaiHat != value))
				{
					if (this._BaiHat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaBaiHatChanging(value);
					this.SendPropertyChanging();
					this._maBaiHat = value;
					this.SendPropertyChanged("maBaiHat");
					this.OnmaBaiHatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maPlaylist", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maPlaylist
		{
			get
			{
				return this._maPlaylist;
			}
			set
			{
				if ((this._maPlaylist != value))
				{
					if (this._Playlist.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaPlaylistChanging(value);
					this.SendPropertyChanging();
					this._maPlaylist = value;
					this.SendPropertyChanged("maPlaylist");
					this.OnmaPlaylistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BaiHat_BaiHatVaPlayList", Storage="_BaiHat", ThisKey="maBaiHat", OtherKey="maBaiHat", IsForeignKey=true)]
		public BaiHat BaiHat
		{
			get
			{
				return this._BaiHat.Entity;
			}
			set
			{
				BaiHat previousValue = this._BaiHat.Entity;
				if (((previousValue != value) 
							|| (this._BaiHat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BaiHat.Entity = null;
						previousValue.BaiHatVaPlayLists.Remove(this);
					}
					this._BaiHat.Entity = value;
					if ((value != null))
					{
						value.BaiHatVaPlayLists.Add(this);
						this._maBaiHat = value.maBaiHat;
					}
					else
					{
						this._maBaiHat = default(string);
					}
					this.SendPropertyChanged("BaiHat");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Playlist_BaiHatVaPlayList", Storage="_Playlist", ThisKey="maPlaylist", OtherKey="maPlaylist", IsForeignKey=true)]
		public Playlist Playlist
		{
			get
			{
				return this._Playlist.Entity;
			}
			set
			{
				Playlist previousValue = this._Playlist.Entity;
				if (((previousValue != value) 
							|| (this._Playlist.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Playlist.Entity = null;
						previousValue.BaiHatVaPlayLists.Remove(this);
					}
					this._Playlist.Entity = value;
					if ((value != null))
					{
						value.BaiHatVaPlayLists.Add(this);
						this._maPlaylist = value.maPlaylist;
					}
					else
					{
						this._maPlaylist = default(string);
					}
					this.SendPropertyChanged("Playlist");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CaSi")]
	public partial class CaSi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maCaSi;
		
		private string _tenCaSi;
		
		private EntitySet<BaiHat> _BaiHats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaCaSiChanging(string value);
    partial void OnmaCaSiChanged();
    partial void OntenCaSiChanging(string value);
    partial void OntenCaSiChanged();
    #endregion
		
		public CaSi()
		{
			this._BaiHats = new EntitySet<BaiHat>(new Action<BaiHat>(this.attach_BaiHats), new Action<BaiHat>(this.detach_BaiHats));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maCaSi", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maCaSi
		{
			get
			{
				return this._maCaSi;
			}
			set
			{
				if ((this._maCaSi != value))
				{
					this.OnmaCaSiChanging(value);
					this.SendPropertyChanging();
					this._maCaSi = value;
					this.SendPropertyChanged("maCaSi");
					this.OnmaCaSiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenCaSi", DbType="NVarChar(50)")]
		public string tenCaSi
		{
			get
			{
				return this._tenCaSi;
			}
			set
			{
				if ((this._tenCaSi != value))
				{
					this.OntenCaSiChanging(value);
					this.SendPropertyChanging();
					this._tenCaSi = value;
					this.SendPropertyChanged("tenCaSi");
					this.OntenCaSiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CaSi_BaiHat", Storage="_BaiHats", ThisKey="maCaSi", OtherKey="maCaSi")]
		public EntitySet<BaiHat> BaiHats
		{
			get
			{
				return this._BaiHats;
			}
			set
			{
				this._BaiHats.Assign(value);
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
		
		private void attach_BaiHats(BaiHat entity)
		{
			this.SendPropertyChanging();
			entity.CaSi = this;
		}
		
		private void detach_BaiHats(BaiHat entity)
		{
			this.SendPropertyChanging();
			entity.CaSi = null;
		}
	}
}
#pragma warning restore 1591
