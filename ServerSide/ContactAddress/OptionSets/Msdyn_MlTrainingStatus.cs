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
	/// Indicates model's training status
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Msdyn_MlTrainingStatus
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Draft", 8)]
		Draft = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Loading Data", 9)]
		LoadingData = 326340008,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Publish completed", 2)]
		Publishcompleted = 326340003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Publish config created", 7)]
		Publishconfigcreated = 326340007,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Publish failed", 1)]
		Publishfailed = 326340002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Publish in progress", 0)]
		Publishinprogress = 326340000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Train config created", 3)]
		Trainconfigcreated = 326340001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Training completed", 6)]
		Trainingcompleted = 326340006,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Training failed", 4)]
		Trainingfailed = 326340004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Training in progress", 5)]
		Traininginprogress = 326340005,
	}
}
#pragma warning restore CS1591
