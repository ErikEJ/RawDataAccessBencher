﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductModelIllustration'.</summary>
	public partial class ProductModelIllustration : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ProductModelIllustration"/> class.</summary>
		public ProductModelIllustration() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the IllustrationId field. </summary>
		public System.Int32 IllustrationId { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the ProductModelId field. </summary>
		public System.Int32 ProductModelId { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelIllustration.Illustration - Illustration.ProductModelIllustrations (m:1)'</summary>
		public virtual Illustration Illustration { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelIllustration.ProductModel - ProductModel.ProductModelIllustrations (m:1)'</summary>
		public virtual ProductModel ProductModel { get; set; } = null!;
	}
}
