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
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_SuggestionType
	{
		
		/// <summary>
		/// Bot Suggestion
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Bot Suggestion", 2, "#0000ff", "Bot Suggestion")]
		BotSuggestion = 192360002,
		
		/// <summary>
		/// Knowledge Article Suggestion
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Knowledge Article Suggestion", 0, "#0000ff", "Knowledge Article Suggestion")]
		KnowledgeArticleSuggestion = 192360000,
		
		/// <summary>
		/// Similar Case Suggestions
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Similar Case Suggestion", 1, "#0000ff", "Similar Case Suggestions")]
		SimilarCaseSuggestion = 192360001,
	}
}
#pragma warning restore CS1591
