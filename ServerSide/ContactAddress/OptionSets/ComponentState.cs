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
	/// The state of this component.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ComponentState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Deleted", 2)]
		Deleted = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Deleted Unpublished", 3)]
		DeletedUnpublished = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Published", 0)]
		Published = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Unpublished", 1)]
		Unpublished = 1,
	}
}
#pragma warning restore CS1591
