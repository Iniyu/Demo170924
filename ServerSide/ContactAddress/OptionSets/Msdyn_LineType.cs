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
	/// An option set to distinguish between project service lines and field service lines
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_LineType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Field Service Line", 1, "#0000ff")]
		FieldServiceLine = 690970001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Project Service Line", 0, "#0000ff")]
		ProjectServiceLine = 690970000,
	}
}
#pragma warning restore CS1591
