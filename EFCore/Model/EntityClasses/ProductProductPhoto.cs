﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductProductPhoto'.</summary>
	public partial class ProductProductPhoto : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ProductProductPhoto"/> class.</summary>
		public ProductProductPhoto() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Primary field. </summary>
		public System.Boolean Primary { get; set; }
		/// <summary>Gets or sets the ProductId field. </summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets or sets the ProductPhotoId field. </summary>
		public System.Int32 ProductPhotoId { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ProductProductPhoto.Product - Product.ProductProductPhotos (m:1)'</summary>
		public virtual Product Product { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'ProductProductPhoto.ProductPhoto - ProductPhoto.ProductProductPhotos (m:1)'</summary>
		public virtual ProductPhoto ProductPhoto { get; set; } = null!;
	}
}
