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
	/// Type of activity.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ActivityPointer_ActivityTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Appointment", 4)]
		Appointment = 4201,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Booking Alert", 24)]
		BookingAlert = 10967,
		
		/// <summary>
		/// Aufgabe, die von einem Benutzer für die Planung oder Durchführung einer Kampagne ausgeführt wurde oder auszuführen ist.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Campaign Activity", 11, null, "Aufgabe, die von einem Benutzer für die Planung oder Durchführung einer Kampagne " +
			"ausgeführt wurde oder auszuführen ist.")]
		CampaignActivity = 4402,
		
		/// <summary>
		/// Reaktion von einem bestehenden oder einem potenziellen neuen Kunden auf eine Kampagne.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Campaign Response", 12, null, "Reaktion von einem bestehenden oder einem potenziellen neuen Kunden auf eine Kamp" +
			"agne.")]
		CampaignResponse = 4401,
		
		/// <summary>
		/// Spezieller Aktivitätstyp, der die Beschreibung des Abschlusses, den Fakturierungsstatus und die Dauer der Anfrage einschließt.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Case Resolution", 13, null, "Spezieller Aktivitätstyp, der die Beschreibung des Abschlusses, den Fakturierungs" +
			"status und die Dauer der Anfrage einschließt.")]
		CaseResolution = 4206,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Conversation", 21)]
		Conversation = 10692,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Copilot Transcript", 23)]
		CopilotTranscript = 10878,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Customer Voice alert", 18)]
		CustomerVoicealert = 10602,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Customer Voice survey invite", 19)]
		CustomerVoicesurveyinvite = 10612,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Customer Voice survey response", 20)]
		CustomerVoicesurveyresponse = 10614,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Email", 2)]
		Email = 4202,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Fax", 0)]
		Fax = 4204,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invite Redemption", 8)]
		InviteRedemption = 10312,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Letter", 3)]
		Letter = 4207,
		
		/// <summary>
		/// Aktivität, die bei Abschluss einer Verkaufschance automatisch erstellt wird und die Informationen wie die Beschreibung des Abschlusses und den tatsächlichen Umsatz enthält.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Opportunity Close", 15, null, "Aktivität, die bei Abschluss einer Verkaufschance automatisch erstellt wird und d" +
			"ie Informationen wie die Beschreibung des Abschlusses und den tatsächlichen Umsa" +
			"tz enthält.")]
		OpportunityClose = 4208,
		
		/// <summary>
		/// Aktivität, die bei Abschluss eines Auftrags automatisch generiert wird.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Order Close", 16, null, "Aktivität, die bei Abschluss eines Auftrags automatisch generiert wird.")]
		OrderClose = 4209,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Outbound message", 25)]
		Outboundmessage = 11164,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Phone Call", 1)]
		PhoneCall = 4210,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Portal Comment", 9)]
		PortalComment = 10313,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Quick Campaign", 10)]
		QuickCampaign = 4406,
		
		/// <summary>
		/// Aktivität, die bei Abschluss eines Angebots erzeugt wird.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Quote Close", 17, null, "Aktivität, die bei Abschluss eines Angebots erzeugt wird.")]
		QuoteClose = 4211,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Recurring Appointment", 6)]
		RecurringAppointment = 4251,
		
		/// <summary>
		/// Aktivität, die von der Organisation angeboten wird, um die Bedürfnisse ihrer Kunden zu erfüllen. Jede Serviceaktivität enthält ein Datum, eine Uhrzeit, eine Dauer und die benötigten Ressourcen.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Service Activity", 14, null, "Aktivität, die von der Organisation angeboten wird, um die Bedürfnisse ihrer Kund" +
			"en zu erfüllen. Jede Serviceaktivität enthält ein Datum, eine Uhrzeit, eine Daue" +
			"r und die benötigten Ressourcen.")]
		ServiceActivity = 4214,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Session", 22)]
		Session = 10709,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Task", 5)]
		Task = 4212,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Teams chat", 7)]
		Teamschat = 10185,
	}
}
#pragma warning restore CS1591
