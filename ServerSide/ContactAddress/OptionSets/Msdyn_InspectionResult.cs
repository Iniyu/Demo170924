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
	/// Options for result of the inspection
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_InspectionResult
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Fail", 1, "#0000ff")]
		Fail = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("NA", 3, "#0000ff")]
		NA = 192350003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Partial Success", 2, "#0000ff")]
		PartialSuccess = 192350002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Pass", 0, "#0000ff")]
		Pass = 192350000,
	}
}
#pragma warning restore CS1591
