﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductInventory'.</summary>
	public partial class ProductInventory : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ProductInventory"/> class.</summary>
		public ProductInventory() : base()
		{
			this.Shelf = string.Empty;
			OnCreated();
		}

		/// <summary>Gets or sets the Bin field. </summary>
		public System.Byte Bin { get; set; }
		/// <summary>Gets or sets the LocationId field. </summary>
		public System.Int16 LocationId { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the ProductId field. </summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets or sets the Quantity field. </summary>
		public System.Int16 Quantity { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the Shelf field. </summary>
		public System.String Shelf { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ProductInventory.Location - Location.ProductInventories (m:1)'</summary>
		public virtual Location Location { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'ProductInventory.Product - Product.ProductInventories (m:1)'</summary>
		public virtual Product Product { get; set; } = null!;
	}
}
