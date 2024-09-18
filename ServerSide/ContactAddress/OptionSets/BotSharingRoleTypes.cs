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
	/// Type of sharing roles associated with Power Virtual Agents bots.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum BotSharingRoleTypes
	{
		
		/// <summary>
		/// Creates, edit and maintains bot content (trigger phrases, topic content, entities and variables). USes Power Automate solutions, authentication action and other extensibility integrations (e.g. skill) provided by developers in content editing.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Copilot author", 1, "#0000ff", "Creates, edit and maintains bot content (trigger phrases, topic content, entities" +
			" and variables). USes Power Automate solutions, authentication action and other " +
			"extensibility integrations (e.g. skill) provided by developers in content editin" +
			"g.")]
		Copilotauthor = 2,
		
		/// <summary>
		/// A manager has full access to all bot content, can publish content, is accountable for bot operations, and can configure hand-off, channels and other operational information.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Copilot manager", 0, "#0000ff", "A manager has full access to all bot content, can publish content, is accountable" +
			" for bot operations, and can configure hand-off, channels and other operational " +
			"information.")]
		Copilotmanager = 1,
		
		/// <summary>
		/// View bot performance in analytics section, monitors CSAT, provides feedback and suggestions.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Copilot reviewer", 2, "#0000ff", "View bot performance in analytics section, monitors CSAT, provides feedback and s" +
			"uggestions.")]
		Copilotreviewer = 3,
	}
}
#pragma warning restore CS1591
