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
	/// Defines type of the rule set
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_DecisionRuleSetType
	{
		
		/// <summary>
		/// Embellishing the work-item using dataverse components
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Dataverse Components", 1, "#0000ee", "Embellishing the work-item using dataverse components")]
		DataverseComponents = 192350002,
		
		/// <summary>
		/// Embellishing the work-item using conditional expressions on different entities
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Declarative", 0, "#0000ff", "Embellishing the work-item using conditional expressions on different entities")]
		Declarative = 192350000,
		
		/// <summary>
		/// Route conversations using an LLM model based prediction
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Intelligent Conversation Distribution", 3, "#0000ff", "Route conversations using an LLM model based prediction")]
		IntelligentConversationDistribution = 192350003,
		
		/// <summary>
		/// Embellishing the work-item using ML model
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ML model based", 2, "#0000ff", "Embellishing the work-item using ML model")]
		MLmodelbased = 192350001,
	}
}
#pragma warning restore CS1591
