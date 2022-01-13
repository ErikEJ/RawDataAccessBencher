﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'BusinessEntityAddress'.</summary>
	public partial class BusinessEntityAddress : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="BusinessEntityAddress"/> class.</summary>
		public BusinessEntityAddress() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the AddressId field. </summary>
		public System.Int32 AddressId { get; set; }
		/// <summary>Gets or sets the AddressTypeId field. </summary>
		public System.Int32 AddressTypeId { get; set; }
		/// <summary>Gets or sets the BusinessEntityId field. </summary>
		public System.Int32 BusinessEntityId { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.Address - Address.BusinessEntityAddresses (m:1)'</summary>
		public virtual Address Address { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.AddressType - AddressType.BusinessEntityAddresses (m:1)'</summary>
		public virtual AddressType AddressType { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.BusinessEntity - BusinessEntity.BusinessEntityAddresses (m:1)'</summary>
		public virtual BusinessEntity BusinessEntity { get; set; } = null!;
	}
}
