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
	/// The kind of dependency.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum DependencyType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0)]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Published", 2)]
		Published = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Solution Internal", 1)]
		SolutionInternal = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Unpublished", 3)]
		Unpublished = 4,
	}
}
#pragma warning restore CS1591
