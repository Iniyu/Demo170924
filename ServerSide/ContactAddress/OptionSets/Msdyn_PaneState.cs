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
	/// The panel state for a session
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_PaneState
	{
		
		/// <summary>
		/// The panel will be expanded
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Docked", 0, "#0000ff", "The panel will be expanded", "docked")]
		Docked = 100000000,
		
		/// <summary>
		/// The panel will be hidden
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Hidden", 2, "#0000ff", "The panel will be hidden", "hidden")]
		Hidden = 100000002,
		
		/// <summary>
		/// The panel will be minimized
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Minimized", 1, "#0000ff", "The panel will be minimized", "minimized")]
		Minimized = 100000001,
	}
}
#pragma warning restore CS1591
