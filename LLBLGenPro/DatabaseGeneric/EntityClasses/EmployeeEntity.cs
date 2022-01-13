﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Employee'.<br/><br/></summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<DocumentEntity> _documents;
		private EntityCollection<EmployeeDepartmentHistoryEntity> _employeeDepartmentHistories;
		private EntityCollection<EmployeePayHistoryEntity> _employeePayHistories;
		private EntityCollection<JobCandidateEntity> _jobCandidates;
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaders;
		private PersonEntity _person;
		private SalesPersonEntity _salesPerson;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static EmployeeEntityStaticMetaData _staticMetaData = new EmployeeEntityStaticMetaData();
		private static EmployeeRelations _relationsFactory = new EmployeeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Documents</summary>
			public static readonly string Documents = "Documents";
			/// <summary>Member name EmployeeDepartmentHistories</summary>
			public static readonly string EmployeeDepartmentHistories = "EmployeeDepartmentHistories";
			/// <summary>Member name EmployeePayHistories</summary>
			public static readonly string EmployeePayHistories = "EmployeePayHistories";
			/// <summary>Member name JobCandidates</summary>
			public static readonly string JobCandidates = "JobCandidates";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class EmployeeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public EmployeeEntityStaticMetaData()
			{
				SetEntityCoreInfo("EmployeeEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.EmployeeEntity, typeof(EmployeeEntity), typeof(EmployeeEntityFactory), false);
				AddNavigatorMetaData<EmployeeEntity, EntityCollection<DocumentEntity>>("Documents", a => a._documents, (a, b) => a._documents = b, a => a.Documents, () => new EmployeeRelations().DocumentEntityUsingOwner, typeof(DocumentEntity), (int)AdventureWorks.Dal.Adapter.EntityType.DocumentEntity);
				AddNavigatorMetaData<EmployeeEntity, EntityCollection<EmployeeDepartmentHistoryEntity>>("EmployeeDepartmentHistories", a => a._employeeDepartmentHistories, (a, b) => a._employeeDepartmentHistories = b, a => a.EmployeeDepartmentHistories, () => new EmployeeRelations().EmployeeDepartmentHistoryEntityUsingEmployeeId, typeof(EmployeeDepartmentHistoryEntity), (int)AdventureWorks.Dal.Adapter.EntityType.EmployeeDepartmentHistoryEntity);
				AddNavigatorMetaData<EmployeeEntity, EntityCollection<EmployeePayHistoryEntity>>("EmployeePayHistories", a => a._employeePayHistories, (a, b) => a._employeePayHistories = b, a => a.EmployeePayHistories, () => new EmployeeRelations().EmployeePayHistoryEntityUsingEmployeeId, typeof(EmployeePayHistoryEntity), (int)AdventureWorks.Dal.Adapter.EntityType.EmployeePayHistoryEntity);
				AddNavigatorMetaData<EmployeeEntity, EntityCollection<JobCandidateEntity>>("JobCandidates", a => a._jobCandidates, (a, b) => a._jobCandidates = b, a => a.JobCandidates, () => new EmployeeRelations().JobCandidateEntityUsingEmployeeId, typeof(JobCandidateEntity), (int)AdventureWorks.Dal.Adapter.EntityType.JobCandidateEntity);
				AddNavigatorMetaData<EmployeeEntity, EntityCollection<PurchaseOrderHeaderEntity>>("PurchaseOrderHeaders", a => a._purchaseOrderHeaders, (a, b) => a._purchaseOrderHeaders = b, a => a.PurchaseOrderHeaders, () => new EmployeeRelations().PurchaseOrderHeaderEntityUsingEmployeeId, typeof(PurchaseOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderHeaderEntity);
				AddNavigatorMetaData<EmployeeEntity, PersonEntity>("Person", "Employee", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticEmployeeRelations.PersonEntityUsingEmployeeIdStatic, ()=>new EmployeeRelations().PersonEntityUsingEmployeeId, null, new int[] { (int)EmployeeFieldIndex.EmployeeId }, null, false, (int)AdventureWorks.Dal.Adapter.EntityType.PersonEntity);
				AddNavigatorMetaData<EmployeeEntity, SalesPersonEntity>("SalesPerson", "Employee", (a, b) => a._salesPerson = b, a => a._salesPerson, (a, b) => a.SalesPerson = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticEmployeeRelations.SalesPersonEntityUsingSalesPersonIdStatic, ()=>new EmployeeRelations().SalesPersonEntityUsingSalesPersonId, null, null, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.SalesPersonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static EmployeeEntity()
		{
		}

		/// <summary> CTor</summary>
		public EmployeeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EmployeeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeId) : this(employeeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.EmployeeId = employeeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocuments() { return CreateRelationInfoForNavigator("Documents"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmployeeDepartmentHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeDepartmentHistories() { return CreateRelationInfoForNavigator("EmployeeDepartmentHistories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmployeePayHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeePayHistories() { return CreateRelationInfoForNavigator("EmployeePayHistories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'JobCandidate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoJobCandidates() { return CreateRelationInfoForNavigator("JobCandidates"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaders() { return CreateRelationInfoForNavigator("PurchaseOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson() { return CreateRelationInfoForNavigator("Person"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPerson() { return CreateRelationInfoForNavigator("SalesPerson"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static EmployeeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocuments { get { return _staticMetaData.GetPrefetchPathElement("Documents", CommonEntityBase.CreateEntityCollection<DocumentEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmployeeDepartmentHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeDepartmentHistories { get { return _staticMetaData.GetPrefetchPathElement("EmployeeDepartmentHistories", CommonEntityBase.CreateEntityCollection<EmployeeDepartmentHistoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmployeePayHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeePayHistories { get { return _staticMetaData.GetPrefetchPathElement("EmployeePayHistories", CommonEntityBase.CreateEntityCollection<EmployeePayHistoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'JobCandidate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathJobCandidates { get { return _staticMetaData.GetPrefetchPathElement("JobCandidates", CommonEntityBase.CreateEntityCollection<JobCandidateEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("PurchaseOrderHeaders", CommonEntityBase.CreateEntityCollection<PurchaseOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPerson { get { return _staticMetaData.GetPrefetchPathElement("SalesPerson", CommonEntityBase.CreateEntityCollection<SalesPersonEntity>()); } }

		/// <summary>The BirthDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."BirthDate".<br/>Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BirthDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.BirthDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.BirthDate, value); }
		}

		/// <summary>The CurrentFlag property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."CurrentFlag".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean CurrentFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.CurrentFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.CurrentFlag, value); }
		}

		/// <summary>The EmployeeId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeId, true); }
			set { SetValue((int)EmployeeFieldIndex.EmployeeId, value); }		}

		/// <summary>The Gender property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Gender".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Gender
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Gender, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Gender, value); }
		}

		/// <summary>The HireDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."HireDate".<br/>Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime HireDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.HireDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.HireDate, value); }
		}

		/// <summary>The LoginId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."LoginID".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LoginId
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LoginId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LoginId, value); }
		}

		/// <summary>The MaritalStatus property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."MaritalStatus".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MaritalStatus
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.MaritalStatus, true); }
			set	{ SetValue((int)EmployeeFieldIndex.MaritalStatus, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The NationalIdnumber property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."NationalIDNumber".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String NationalIdnumber
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.NationalIdnumber, true); }
			set	{ SetValue((int)EmployeeFieldIndex.NationalIdnumber, value); }
		}

		/// <summary>The OrganizationLevel property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."OrganizationLevel".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> OrganizationLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)EmployeeFieldIndex.OrganizationLevel, false); }
		}

		/// <summary>The OrganizationNode property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."OrganizationNode".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 892.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String OrganizationNode
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.OrganizationNode, true); }
			set	{ SetValue((int)EmployeeFieldIndex.OrganizationNode, value); }
		}

		/// <summary>The Rowguid property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)EmployeeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Rowguid, value); }
		}

		/// <summary>The SalariedFlag property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SalariedFlag".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean SalariedFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.SalariedFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SalariedFlag, value); }
		}

		/// <summary>The SickLeaveHours property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SickLeaveHours".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SickLeaveHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.SickLeaveHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SickLeaveHours, value); }
		}

		/// <summary>The Title property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."JobTitle".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Title, value); }
		}

		/// <summary>The VacationHours property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."VacationHours".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 VacationHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.VacationHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.VacationHours, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'DocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DocumentEntity))]
		public virtual EntityCollection<DocumentEntity> Documents { get { return GetOrCreateEntityCollection<DocumentEntity, DocumentEntityFactory>("Employee", true, false, ref _documents); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'EmployeeDepartmentHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeDepartmentHistoryEntity))]
		public virtual EntityCollection<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistories { get { return GetOrCreateEntityCollection<EmployeeDepartmentHistoryEntity, EmployeeDepartmentHistoryEntityFactory>("Employee", true, false, ref _employeeDepartmentHistories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'EmployeePayHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeePayHistoryEntity))]
		public virtual EntityCollection<EmployeePayHistoryEntity> EmployeePayHistories { get { return GetOrCreateEntityCollection<EmployeePayHistoryEntity, EmployeePayHistoryEntityFactory>("Employee", true, false, ref _employeePayHistories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'JobCandidateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(JobCandidateEntity))]
		public virtual EntityCollection<JobCandidateEntity> JobCandidates { get { return GetOrCreateEntityCollection<JobCandidateEntity, JobCandidateEntityFactory>("Employee", true, false, ref _jobCandidates); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaders { get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("Employee", true, false, ref _purchaseOrderHeaders); } }

		/// <summary>Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set { SetSingleRelatedEntityNavigator(value, "Person"); }
		}

		/// <summary>Gets / sets related entity of type 'SalesPersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get { return _salesPerson; }
			set { SetSingleRelatedEntityNavigator(value, "SalesPerson"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum EmployeeFieldIndex
	{
		///<summary>BirthDate. </summary>
		BirthDate,
		///<summary>CurrentFlag. </summary>
		CurrentFlag,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Gender. </summary>
		Gender,
		///<summary>HireDate. </summary>
		HireDate,
		///<summary>LoginId. </summary>
		LoginId,
		///<summary>MaritalStatus. </summary>
		MaritalStatus,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>NationalIdnumber. </summary>
		NationalIdnumber,
		///<summary>OrganizationLevel. </summary>
		OrganizationLevel,
		///<summary>OrganizationNode. </summary>
		OrganizationNode,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalariedFlag. </summary>
		SalariedFlag,
		///<summary>SickLeaveHours. </summary>
		SickLeaveHours,
		///<summary>Title. </summary>
		Title,
		///<summary>VacationHours. </summary>
		VacationHours,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Employee. </summary>
	public partial class EmployeeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and DocumentEntity over the 1:n relation they have, using the relation between the fields: Employee.EmployeeId - Document.Owner</summary>
		public virtual IEntityRelation DocumentEntityUsingOwner
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Documents", true, new[] { EmployeeFields.EmployeeId, DocumentFields.Owner }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have, using the relation between the fields: Employee.EmployeeId - EmployeeDepartmentHistory.EmployeeId</summary>
		public virtual IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "EmployeeDepartmentHistories", true, new[] { EmployeeFields.EmployeeId, EmployeeDepartmentHistoryFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeePayHistoryEntity over the 1:n relation they have, using the relation between the fields: Employee.EmployeeId - EmployeePayHistory.EmployeeId</summary>
		public virtual IEntityRelation EmployeePayHistoryEntityUsingEmployeeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "EmployeePayHistories", true, new[] { EmployeeFields.EmployeeId, EmployeePayHistoryFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and JobCandidateEntity over the 1:n relation they have, using the relation between the fields: Employee.EmployeeId - JobCandidate.EmployeeId</summary>
		public virtual IEntityRelation JobCandidateEntityUsingEmployeeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "JobCandidates", true, new[] { EmployeeFields.EmployeeId, JobCandidateFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: Employee.EmployeeId - PurchaseOrderHeader.EmployeeId</summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PurchaseOrderHeaders", true, new[] { EmployeeFields.EmployeeId, PurchaseOrderHeaderFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PersonEntity over the 1:1 relation they have, using the relation between the fields: Employee.EmployeeId - Person.BusinessEntityId</summary>
		public virtual IEntityRelation PersonEntityUsingEmployeeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "Person", false, new[] { PersonFields.BusinessEntityId, EmployeeFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and SalesPersonEntity over the 1:1 relation they have, using the relation between the fields: Employee.EmployeeId - SalesPerson.SalesPersonId</summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "SalesPerson", true, new[] { EmployeeFields.EmployeeId, SalesPersonFields.SalesPersonId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeeRelations
	{
		internal static readonly IEntityRelation DocumentEntityUsingOwnerStatic = new EmployeeRelations().DocumentEntityUsingOwner;
		internal static readonly IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeIdStatic = new EmployeeRelations().EmployeeDepartmentHistoryEntityUsingEmployeeId;
		internal static readonly IEntityRelation EmployeePayHistoryEntityUsingEmployeeIdStatic = new EmployeeRelations().EmployeePayHistoryEntityUsingEmployeeId;
		internal static readonly IEntityRelation JobCandidateEntityUsingEmployeeIdStatic = new EmployeeRelations().JobCandidateEntityUsingEmployeeId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeIdStatic = new EmployeeRelations().PurchaseOrderHeaderEntityUsingEmployeeId;
		internal static readonly IEntityRelation PersonEntityUsingEmployeeIdStatic = new EmployeeRelations().PersonEntityUsingEmployeeId;
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIdStatic = new EmployeeRelations().SalesPersonEntityUsingSalesPersonId;

		/// <summary>CTor</summary>
		static StaticEmployeeRelations() { }
	}
}
