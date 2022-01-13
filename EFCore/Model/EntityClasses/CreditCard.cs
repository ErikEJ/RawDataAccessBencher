﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CreditCard'.</summary>
	public partial class CreditCard : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="CreditCard"/> class.</summary>
		public CreditCard() : base()
		{
			this.ContactCreditCards = new List<ContactCreditCard>();
			this.SalesOrderHeaders = new List<SalesOrderHeader>();
			this.CardNumber = string.Empty;
			this.CardType = string.Empty;
			OnCreated();
		}

		/// <summary>Gets or sets the CardNumber field. </summary>
		public System.String CardNumber { get; set; }
		/// <summary>Gets or sets the CardType field. </summary>
		public System.String CardType { get; set; }
		/// <summary>Gets or sets the CreditCardId field. </summary>
		public System.Int32 CreditCardId { get; set; }
		/// <summary>Gets or sets the ExpMonth field. </summary>
		public System.Byte ExpMonth { get; set; }
		/// <summary>Gets or sets the ExpYear field. </summary>
		public System.Int16 ExpYear { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.CreditCard - CreditCard.ContactCreditCards (m:1)'</summary>
		public virtual List<ContactCreditCard> ContactCreditCards { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.CreditCard - CreditCard.SalesOrderHeaders (m:1)'</summary>
		public virtual List<SalesOrderHeader> SalesOrderHeaders { get; set; }
	}
}
