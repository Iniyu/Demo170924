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
	/// The mode of the OC hub being used.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_OCAdminMode
	{
		
		/// <summary>
		/// Experience through the legacy app.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Legacy", 0, "#0000ff", "Experience through the legacy app.")]
		Legacy = 717210000,
		
		/// <summary>
		/// Experience through the simplified app.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Simplified", 1, "#0000ff", "Experience through the simplified app.")]
		Simplified = 717210001,
	}
}
#pragma warning restore CS1591
