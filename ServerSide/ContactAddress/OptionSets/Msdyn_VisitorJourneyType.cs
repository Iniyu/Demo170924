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
	/// Option set for type of the navigation that user performed.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_VisitorJourneyType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Custom Action", 3, "#0000ff")]
		CustomAction = 192350100,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("KB Article", 2, "#0000ff")]
		KBArticle = 192350002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Page View", 0, "#0000ff")]
		PageView = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Search", 1, "#0000ff")]
		Search = 192350001,
	}
}
#pragma warning restore CS1591
