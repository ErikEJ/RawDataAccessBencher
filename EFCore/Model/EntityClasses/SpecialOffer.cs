﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SpecialOffer'.</summary>
	public partial class SpecialOffer : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="SpecialOffer"/> class.</summary>
		public SpecialOffer() : base()
		{
			this.SpecialOfferProducts = new List<SpecialOfferProduct>();
			this.Category = string.Empty;
			this.Description = string.Empty;
			this.Type = string.Empty;
			OnCreated();
		}

		/// <summary>Gets or sets the Category field. </summary>
		public System.String Category { get; set; }
		/// <summary>Gets or sets the Description field. </summary>
		public System.String Description { get; set; }
		/// <summary>Gets or sets the DiscountPct field. </summary>
		public System.Decimal DiscountPct { get; set; }
		/// <summary>Gets or sets the EndDate field. </summary>
		public System.DateTime EndDate { get; set; }
		/// <summary>Gets or sets the MaxQty field. </summary>
		public Nullable<System.Int32> MaxQty { get; set; }
		/// <summary>Gets or sets the MinQty field. </summary>
		public System.Int32 MinQty { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the SpecialOfferId field. </summary>
		public System.Int32 SpecialOfferId { get; set; }
		/// <summary>Gets or sets the StartDate field. </summary>
		public System.DateTime StartDate { get; set; }
		/// <summary>Gets or sets the Type field. </summary>
		public System.String Type { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SpecialOfferProduct.SpecialOffer - SpecialOffer.SpecialOfferProducts (m:1)'</summary>
		public virtual List<SpecialOfferProduct> SpecialOfferProducts { get; set; }
	}
}
