#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataverseModel
{
	
	
	/// <summary>
	/// Shows billing status of transactions.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_BillingStatus
	{
		
		/// <summary>
		/// Canceled billing status of transactions.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Canceled", 4, null, "Canceled billing status of transactions.")]
		Canceled = 192350003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Customer Invoice Created", 2)]
		CustomerInvoiceCreated = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Customer Invoice Posted", 3)]
		CustomerInvoicePosted = 192350002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Unbilled Sales Created", 1)]
		UnbilledSalesCreated = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Work order closed - posted", 0, "#0000ff")]
		Workorderclosedposted = 690970000,
	}
}
#pragma warning restore CS1591
