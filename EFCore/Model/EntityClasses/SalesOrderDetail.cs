﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SalesOrderDetail'.</summary>
	public partial class SalesOrderDetail : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="SalesOrderDetail"/> class.</summary>
		public SalesOrderDetail() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the CarrierTrackingNumber field. </summary>
		public System.String? CarrierTrackingNumber { get; set; }
		/// <summary>Gets or sets the LineTotal field. </summary>
		public System.Decimal LineTotal { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the OrderQty field. </summary>
		public System.Int16 OrderQty { get; set; }
		/// <summary>Gets or sets the ProductId field. </summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the SalesOrderDetailId field. </summary>
		public System.Int32 SalesOrderDetailId { get; set; }
		/// <summary>Gets or sets the SalesOrderId field. </summary>
		public System.Int32 SalesOrderId { get; set; }
		/// <summary>Gets or sets the SpecialOfferId field. </summary>
		public System.Int32 SpecialOfferId { get; set; }
		/// <summary>Gets or sets the UnitPrice field. </summary>
		public System.Decimal UnitPrice { get; set; }
		/// <summary>Gets or sets the UnitPriceDiscount field. </summary>
		public System.Decimal UnitPriceDiscount { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderDetail.SalesOrderHeader - SalesOrderHeader.SalesOrderDetails (m:1)'</summary>
		public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderDetail.SpecialOfferProduct - SpecialOfferProduct.SalesOrderDetails (m:1)'</summary>
		public virtual SpecialOfferProduct SpecialOfferProduct { get; set; } = null!;
	}
}
