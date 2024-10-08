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
	/// Select the records to send the direct email to
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum BulkEmail_Recipient
	{
		
		/// <summary>
		/// Send direct email to all the records on all the pages in the current view.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("All records on all pages", 2, null, "Send direct email to all the records on all the pages in the current view.")]
		Allrecordsonallpages = 3,
		
		/// <summary>
		/// Send direct email to all the records on this page.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("All records on current page", 1, null, "Send direct email to all the records on this page.")]
		Allrecordsoncurrentpage = 2,
		
		/// <summary>
		/// Send direct email only to the records you selected on this page.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Selected records on current page", 0, null, "Send direct email only to the records you selected on this page.")]
		Selectedrecordsoncurrentpage = 1,
	}
}
#pragma warning restore CS1591
