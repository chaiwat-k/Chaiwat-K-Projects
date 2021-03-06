﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace CarPass.TicTacToe.Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TicTacToeModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TicTacToeModelContainer object using the connection string found in the 'TicTacToeModelContainer' section of the application configuration file.
        /// </summary>
        public TicTacToeModelContainer() : base("name=TicTacToeModelContainer", "TicTacToeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TicTacToeModelContainer object.
        /// </summary>
        public TicTacToeModelContainer(string connectionString) : base(connectionString, "TicTacToeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TicTacToeModelContainer object.
        /// </summary>
        public TicTacToeModelContainer(EntityConnection connection) : base(connection, "TicTacToeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TicTacToeGame> TicTacToeGameSet
        {
            get
            {
                if ((_TicTacToeGameSet == null))
                {
                    _TicTacToeGameSet = base.CreateObjectSet<TicTacToeGame>("TicTacToeGameSet");
                }
                return _TicTacToeGameSet;
            }
        }
        private ObjectSet<TicTacToeGame> _TicTacToeGameSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TicTacToeGameSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTicTacToeGameSet(TicTacToeGame ticTacToeGame)
        {
            base.AddObject("TicTacToeGameSet", ticTacToeGame);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TicTacToeModel", Name="TicTacToeGame")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TicTacToeGame : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TicTacToeGame object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        /// <param name="startDate">Initial value of the StartDate property.</param>
        /// <param name="durationInSec">Initial value of the DurationInSec property.</param>
        public static TicTacToeGame CreateTicTacToeGame(global::System.Int32 id, global::System.Int16 status, global::System.DateTime startDate, global::System.Int32 durationInSec)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.Id = id;
            ticTacToeGame.Status = status;
            ticTacToeGame.StartDate = startDate;
            ticTacToeGame.DurationInSec = durationInSec;
            return ticTacToeGame;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.Int16 _Status;
        partial void OnStatusChanging(global::System.Int16 value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                OnStartDateChanging(value);
                ReportPropertyChanging("StartDate");
                _StartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StartDate");
                OnStartDateChanged();
            }
        }
        private global::System.DateTime _StartDate;
        partial void OnStartDateChanging(global::System.DateTime value);
        partial void OnStartDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DurationInSec
        {
            get
            {
                return _DurationInSec;
            }
            set
            {
                OnDurationInSecChanging(value);
                ReportPropertyChanging("DurationInSec");
                _DurationInSec = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DurationInSec");
                OnDurationInSecChanged();
            }
        }
        private global::System.Int32 _DurationInSec;
        partial void OnDurationInSecChanging(global::System.Int32 value);
        partial void OnDurationInSecChanged();

        #endregion
    
    }

    #endregion
    
}
