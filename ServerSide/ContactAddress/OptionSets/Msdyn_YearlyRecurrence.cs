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
	/// Defines a booking recurrence that occurs on a yearly basis
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_YearlyRecurrence
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Day of the month", 0, "#0000ff")]
		Dayofthemonth = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Day of the week and month", 1, "#0000ff")]
		Dayoftheweekandmonth = 192350001,
	}
}
#pragma warning restore CS1591
