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
	/// Shows the status of time entry records.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_TimeEntryStatus
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Approved", 2, "#3E7239")]
		Approved = 192350002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Cancelled", 4, "#0000ff")]
		Cancelled = 192354320,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Draft", 0, "#505050")]
		Draft = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Returned", 1, "#AD193E")]
		Returned = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Submitted", 3, "#CE7200")]
		Submitted = 192350003,
	}
}
#pragma warning restore CS1591
