﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;

using System.Text;

namespace BSD_Test4.Models 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IEvent));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IEvent, BSD_Test4.Models.Event>();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IPerformance));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IPerformance, BSD_Test4.Models.Performance>();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IPhoto));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IPhoto, BSD_Test4.Models.Photo>();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IPerson));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IPerson, BSD_Test4.Models.Person>();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IProduction));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IProduction, BSD_Test4.Models.Production>();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IProductionMember));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IProductionMember, BSD_Test4.Models.ProductionMember>();
    		provider.AddMappingsForType(TypeMappings, typeof(BSD_Test4.Models.IRole));
    		TypeMappings.SetImplMapping<BSD_Test4.Models.IRole, BSD_Test4.Models.Role>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified BrightstarDB
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the BrightstarDB Data Object Store that will provide the entity objects</param>
        /// <param name="typeMappings">OPTIONAL: A <see cref="EntityMappingStore"/> that overrides the default mappings generated by reflection.</param>
    	public MyEntityContext(IDataObjectStore dataObjectStore, EntityMappingStore typeMappings = null) : base(typeMappings ?? TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
        /// <param name="updateGraphUri">OPTIONAL: The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// not defined, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">OPTIONAL: The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If not defined, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">OPTIONAL: The URI identifier of the graph that contains version number statements for entities. 
        /// If not defined, the <paramref name="updateGraphUri"/> will be used.</param>
        /// <param name="typeMappings">OPTIONAL: A <see cref="EntityMappingStore"/> that overrides the default mappings generated by reflection.</param>
    	public MyEntityContext(
    	    string connectionString, 
    		bool? enableOptimisticLocking=null,
    		string updateGraphUri = null,
    		IEnumerable<string> datasetGraphUris = null,
    		string versionGraphUri = null,
            EntityMappingStore typeMappings = null
        ) : base(typeMappings ?? TypeMappings, connectionString, enableOptimisticLocking, updateGraphUri, datasetGraphUris, versionGraphUri)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
        /// <param name="typeMappings">OPTIONAL: A <see cref="EntityMappingStore"/> that overrides the default mappings generated by reflection.</param>
    	public MyEntityContext(EntityMappingStore typeMappings = null) : base(typeMappings ?? TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration and the
    	//  specified target graphs
    	/// </summary>
        /// <param name="updateGraphUri">The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// set to null, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If set to null, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">The URI identifier of the graph that contains version number statements for entities. 
        /// If set to null, the value of <paramref name="updateGraphUri"/> will be used.</param>
        /// <param name="typeMappings">OPTIONAL: A <see cref="EntityMappingStore"/> that overrides the default mappings generated by reflection.</param>
    	public MyEntityContext(
    		string updateGraphUri,
    		IEnumerable<string> datasetGraphUris,
    		string versionGraphUri,
            EntityMappingStore typeMappings = null
    	) : base(typeMappings ?? TypeMappings, updateGraphUri:updateGraphUri, datasetGraphUris:datasetGraphUris, versionGraphUri:versionGraphUri)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Events = 	new BrightstarEntitySet<BSD_Test4.Models.IEvent>(this);
    		Performances = 	new BrightstarEntitySet<BSD_Test4.Models.IPerformance>(this);
    		Photos = 	new BrightstarEntitySet<BSD_Test4.Models.IPhoto>(this);
    		Persons = 	new BrightstarEntitySet<BSD_Test4.Models.IPerson>(this);
    		Productions = 	new BrightstarEntitySet<BSD_Test4.Models.IProduction>(this);
    		ProductionMembers = 	new BrightstarEntitySet<BSD_Test4.Models.IProductionMember>(this);
    		Roles = 	new BrightstarEntitySet<BSD_Test4.Models.IRole>(this);
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IEvent> Events
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IPerformance> Performances
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IPhoto> Photos
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IPerson> Persons
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IProduction> Productions
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IProductionMember> ProductionMembers
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BSD_Test4.Models.IRole> Roles
    	{
    		get; private set;
    	}
    	
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class Event : BrightstarEntityObject, IEvent 
    {
    	public Event(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Event() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BSD_Test4.Models.IEvent
    
    	public System.DateTime DateTime
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateTime"); }
            		set { SetRelatedProperty("DateTime", value); }
    	}
    	#endregion
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class Performance : BrightstarEntityObject, IPerformance 
    {
    	public Performance(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Performance() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BSD_Test4.Models.IPerformance
    
    	public BSD_Test4.Models.IProduction Production
    	{
            get { return GetRelatedObject<BSD_Test4.Models.IProduction>("Production"); }
            set { SetRelatedObject<BSD_Test4.Models.IProduction>("Production", value); }
    	}
    	#endregion
    	#region Implementation of BSD_Test4.Models.IEvent
    
    	public System.DateTime DateTime
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateTime"); }
            		set { SetRelatedProperty("DateTime", value); }
    	}
    	#endregion
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class Photo : BrightstarEntityObject, IPhoto 
    {
    	public Photo(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Photo() : base() { }
    	#region Implementation of BSD_Test4.Models.IPhoto
    
    	public BSD_Test4.Models.IProduction Production
    	{
            get { return GetRelatedObject<BSD_Test4.Models.IProduction>("Production"); }
            set { SetRelatedObject<BSD_Test4.Models.IProduction>("Production", value); }
    	}
    	#endregion
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class Person : BrightstarEntityObject, IPerson 
    {
    	public Person(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Person() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BSD_Test4.Models.IPerson
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String Nickname
    	{
            		get { return GetRelatedProperty<System.String>("Nickname"); }
            		set { SetRelatedProperty("Nickname", value); }
    	}
    
    	public System.String FirstName
    	{
            		get { return GetRelatedProperty<System.String>("FirstName"); }
            		set { SetRelatedProperty("FirstName", value); }
    	}
    
    	public System.String LastName
    	{
            		get { return GetRelatedProperty<System.String>("LastName"); }
            		set { SetRelatedProperty("LastName", value); }
    	}
    	#endregion
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class Production : BrightstarEntityObject, IProduction 
    {
    	public Production(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Production() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BSD_Test4.Models.IProduction
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String Title1
    	{
            		get { return GetRelatedProperty<System.String>("Title1"); }
            		set { SetRelatedProperty("Title1", value); }
    	}
    	public System.Collections.Generic.ICollection<BSD_Test4.Models.IPerformance> Performances
    	{
    		get { return GetRelatedObjects<BSD_Test4.Models.IPerformance>("Performances"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Performances", value); }
    								}
    	public System.Collections.Generic.ICollection<BSD_Test4.Models.IProductionMember> ProductionTeam
    	{
    		get { return GetRelatedObjects<BSD_Test4.Models.IProductionMember>("ProductionTeam"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("ProductionTeam", value); }
    								}
    	public System.Collections.Generic.ICollection<BSD_Test4.Models.IPhoto> Photos
    	{
    		get { return GetRelatedObjects<BSD_Test4.Models.IPhoto>("Photos"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Photos", value); }
    								}
    	#endregion
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class ProductionMember : BrightstarEntityObject, IProductionMember 
    {
    	public ProductionMember(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public ProductionMember() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BSD_Test4.Models.IProductionMember
    
    	public BSD_Test4.Models.IPerson Person
    	{
            get { return GetRelatedObject<BSD_Test4.Models.IPerson>("Person"); }
            set { SetRelatedObject<BSD_Test4.Models.IPerson>("Person", value); }
    	}
    
    	public BSD_Test4.Models.IRole Role
    	{
            get { return GetRelatedObject<BSD_Test4.Models.IRole>("Role"); }
            set { SetRelatedObject<BSD_Test4.Models.IRole>("Role", value); }
    	}
    
    	public BSD_Test4.Models.IProduction Production
    	{
            get { return GetRelatedObject<BSD_Test4.Models.IProduction>("Production"); }
            set { SetRelatedObject<BSD_Test4.Models.IProduction>("Production", value); }
    	}
    	#endregion
    }
}
namespace BSD_Test4.Models 
{
    
    public partial class Role : BrightstarEntityObject, IRole 
    {
    	public Role(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Role() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BSD_Test4.Models.IRole
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.String RoleType
    	{
            		get { return GetRelatedProperty<System.String>("RoleType"); }
            		set { SetRelatedProperty("RoleType", value); }
    	}
    	#endregion
    }
}
