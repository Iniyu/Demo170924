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
	/// This option set is used to list different Search Types.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_IotSearchType
	{
		
		/// <summary>
		/// The desired data is contained in a direct path.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Direct Path", 0, "#0000ff", "The desired data is contained in a direct path.")]
		DirectPath = 192350000,
		
		/// <summary>
		/// The desired data is contained in a key value path.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Key Value Path", 1, "#0000ff", "The desired data is contained in a key value path.")]
		KeyValuePath = 192350001,
	}
}
#pragma warning restore CS1591
