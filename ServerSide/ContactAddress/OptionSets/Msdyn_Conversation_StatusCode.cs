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
	/// Reason for the status of live conversation record
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_Conversation_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 1, "#70278B", null, "Active")]
		Active = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Closed", 3, "#68D8FC", null, "Closed")]
		Closed = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Open", 0, "#F93B96", null, "Open")]
		Open = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Waiting", 2, "#4C7AF2", null, "Waiting")]
		Waiting = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Wrap-up", 4, "#009EB3", null, "Wrap-up")]
		Wrapup = 5,
	}
}
#pragma warning restore CS1591
