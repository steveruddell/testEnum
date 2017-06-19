Option Infer On

'Each enum provides enumerated access to the fields returned in a datarow from the table with the same name


'Each enum provides enumerated access to the fields returned in a datarow from the table with the same name

Namespace SCM6Enums

	<AttributeUsageAttribute(AttributeTargets.Property Or AttributeTargets.Field, Inherited:=False, AllowMultiple:=False)> _
	Public NotInheritable Class EnumMemberAttribute
		Inherits Attribute
	End Class

#Region "Datarow Result Fields"


	Public Enum eCiteationSearchResultFields

		JournalTitle = 0
		ArticleID = 1
		ArticleTitle = 2
		PDFLink = 3
		ArticleDate = 4
		ArticleTypeName = 5
		AuthorName = 6
		MULTIMEDIAID = 7

	End Enum

	Public Enum eNumberRangesFields As Integer
		ID = 0
		LowEnd = 1
		HighEnd = 2
		Category = 3
		Text = 4
	End Enum

	Public Enum eCMEQuizInfoFields
		QuizInfoID = 0
		SiteID = 1
		ResourceID = 2
		ResourceTypeID = 3
		Description = 4
		IntroText = 5
		CoverPageImageLocation = 6
		CoverPageImageLocationSmall = 7
		MasterResourceID = 8
		MasterResourceTypeID = 9
		MasterResourceName = 10
	End Enum

	Public Enum eResource2HostnamesFields
		ID = 0
		ResourceID = 1
		ResourceTypeID = 2
		SiteID = 3
		Hostname = 4
	End Enum

	Public Enum eInstitutionContactsFields
		InstitutionID = 0
		UserID = 1
	End Enum

	Public Enum eAccounts2RolesFields
		AccountID = 0
		RoleID = 1
	End Enum

	Public Enum eArticleClientTypeFields
		ID = 0
		ArticleRootTypeID = 1
		Title = 2
		Ordinal = 3
		ClientID = 4
		Browsable = 5
		CategoryDisplayName = 6
		JournalID = 7
		ParentClientTypeID = 8
        ClientTypeDesplayName = 9
        SuppressJumpLinks = 10

	End Enum

	Public Structure eArticleClientTypesFreeViewFields
		Public Const JournalID As String = "journalID"
		Public Const ArticleClientTypeID As String = "articleClientTypeID"
		Public Const StartDate As String = "startDate"
		Public Const EndDate As String = "endDate"
	End Structure

	Public Enum eSiteMenus
		MenuID = 0
		SiteID = 1
		Title = 2
		URI = 3
		ParentID = 4
		Ordinal = 5
        SiteMenuTypeID = 6
        LanguageID = 7
        LinkDecoration = 8
	End Enum

	Public Enum eSiteMasterUsers
		UserID = 0
		UserName = 1
		LastName = 2
		FirstName = 3
		UserFullName = 4
		Email = 5
		RoleID = 6
		RoleName = 7
	End Enum

	''' <summary>
	''' Provides enumerated access to the fields returned in a datarow 
	''' by a simple access to the Authors table.
	''' </summary>
	''' <remarks>Provides enumerated access to the fields returned in a datarow 
	''' by a simple access to the Authors table.</remarks>
	Public Enum eAuthorsFields As Integer
		ID = 0
		Ordinal = 1
		fullName = 2
		FirstName = 3
		LastName = 4
		Credentials = 5
		affiliation = 6
		prefix = 7
		suffix = 8
		role = 9
		location = 10
		authorTypeId = 11
		authorParentId = 12
		orcidID = 13
        isCorresponding = 14
        email = 15
	End Enum

	''' <summary>
	''' Provides enumerated access to the fields returned in a datarow
	''' by a simple access to the AuthorNotes table.
	'''</summary>
	''' <remarks>
	''' Provides enumerated access to the fields returned in a datarow
	''' by a simple access to the AuthorNotes table.
	''' </remarks>
	Public Enum eAuthorNotesFields As Integer
		authorID = 0
		authorNotesTypeID = 1
		note = 2
	End Enum

	''' <summary>
	''' Provides enumerated access to the fields returned in a datarow 
	''' by a simple access to the MultimediabyCategory stored procedure.
	''' </summary>
	''' <remarks>Provides enumerated access to the fields returned in a datarow 
	''' by a simple access to the MultimediabyCategory stored procedure.</remarks>
	Public Enum eMultimediasByCatogoryView As Integer
		MultimediaID = 0
		MultimediaTypeID = 1
		URL = 2
		Height = 3
		Width = 4
		FileName = 5
		FileSize = 6
		ClientID = 7
		CategoryID = 8
	End Enum

	Public Enum eDrugMonographFields As Integer
		id = 0
		Title = 1
		AID = 2
	End Enum

	Public Structure CategoryFields
		Public Const ID As String = "ID"
		Public Const SiteID As String = "siteID"
		Public Const LegacyCategoryID As String = "legacyCategoryID"
		Public Const CategoryTypeID As String = "categoryTypeID"
		Public Const Name As String = "name"
		Public Const ParentCategoryID As String = "parentCategoryID"
		Public Const Ordinal As String = "ordinal"
		Public Const IsCorridor As String = "isCorridor"
		Public Const Relevancy As String = "relevancy"
		Public Const LanguageID As String = "languageID"
	End Structure

	Public Enum eIssueFields As Integer
		Id = 0
		JournalID = 1
		LegacyIssueID = 2
		PublicationDate = 3
		Title = 4
		Volume = 5
		IssueNo = 6
		Pages = 7
		ActiveDate = 8
		IssueExtraText = 9
		DateXml = 10
		DtdId = 11
		startPage = 12
		endPage = 13
		OpenStatus = 14
		StatusUpdatedByUserId = 15
		StatusUpdatedOn = 16
		ClientID = 17
		startPageCalc = 18
		endPageCalc = 19
        issueTocTypeID = 20
        issueTypeID = 21
    End Enum

	Public Enum eGuidelineFields As Integer
		Id = 0
		Title = 1
		PublishedDate = 2
		TotalScore = 4
		OrganizationName = 3
	End Enum

	Public Enum eIssues2MultimediasFields As Integer

		IssueID = 0
		MultimediaID = 0

	End Enum
	Public Enum eSiteFields As Integer
		ID = 0
		name = 1
		clientID = 2
		hostName = 3
		ImageTemplateURL = 4
		AthensDSPID = 5
		AthensSiteID = 6
		ParentID = 7
		SiteType = 8
		LanguageID = 9
        Ordinal = 10
        RouteName = 11
        SiteReleaseStageId = 12
        SiteStateId = 13
	End Enum

	Public Enum eSiteResourceFields As Integer
		ResourceID = 0
		SiteID = 1
		ResourceTypeID = 2
		Show = 3
	End Enum

	Public Enum eJournalFields As Integer
		id = 0
		LegacyJournalID = 1
		Title = 2
		ShortName = 3
		DisplayName = 4
		CiteName = 5
		Ordinal = 6
		ClientID = 7
		IsShared = 8
		FreeView = 9
		SiteID = 10
		ISSN = 11
		EISSN = 12
		Publisher = 13
		Searchable = 14
		AID = 15
		PublishingModel = 16
        Description = 17
	End Enum

	Public Enum ePubmedArtciles As Integer
		ID = 0
		TermID = 1
		QueryKey = 2
		LastRetrived = 3
		ArticleTitle = 4
		JournalTitle = 5
		PublishedDate = 6
		PMID = 7
		Term = 8
		DOI = 9
		JournalCiteName = 10
		PublicationStatus = 11
		Volume = 12
		Issue = 13
		Pages = 14
		PublicationDateDay = 15
		PublicationDateMonth = 16
		PublicationDateYear = 17
	End Enum

	Public Enum eSectionFields As Integer
		ID = 0
		parentSectionID = 1
		AID = 2
		Ordinal = 3
		SectionTypeID = 4
		legacySectionID = 5
		Title = 6
		SectionXML = 7
		HeadLevel = 8
		MultimediaID = 9
		ResourceTypeID = 10
		ChapNum = 11
		DOI = 12
		sectionDTDID = 13
		classType = 14
		Freeview = 15
		BookID = 16
		ArticleID = 17 'The stored procedure PROC_SectionGetByArticle returns articleid at 15th position, and we don't know where bookid is being used, so to make things work we are making bookid and articleid the same position.
		quizID = 18	 'The stored procedure PROC_SectionGetByQuiz returns quizid at 15th position
		PartID = 19
        UpdateDate = 20
	End Enum

	Public Enum ePartFields As Integer
		ID = 0
		PartLabel = 1
		PartTitle = 2
		IntroAID = 3
		BookID = 4

	End Enum

	Public Enum eAdsFields
		ID = 0
		FileName = 1
		AdTypeID = 2
		ClientID = 3
		AddTypeName = 4
	End Enum

	Public Enum eBooksFields
		ID = 0
		Title = 1
		ShortName = 2
		DisplayName = 3
		CiteName = 4
		Ordinal = 5
		PubYear = 6
		LegacyBookID = 7
		ClientID = 8
		IsShared = 9
		DOI = 10
		FreeView = 11
		CurrentVersionBookID = 12
		ActiveDate = 13
		ISBN = 14
		ISSN = 15
		Publisher = 16
		Searchable = 17
		ISBN10 = 18
		EISBN = 19
		DepositBookTypeID = 20
		PageCount = 21
		AID = 22
		BookTocTypeID = 23
		softExpireDate = 24
		hardExpireDate = 25
		edition = 26
		editionXML = 27
        PublicationDate = 28
        LanguageID = 29
        dateXML = 30
        volumeNumber = 31
    End Enum

	Public Enum eArticleTypeFields
		ID = 0
		Name = 1
		Ordinal = 2
	End Enum

	Public Enum eArticleFields
		ID = 0
		AID = 1
		IssueID = 2
		DOI = 3
		LegacyArticleID = 4
		ArticleTypeID = 5
		ParentArticleID = 6
		PDFLink = 7
		Pages = 8
		Title = 9
		ArticleDate = 10
		CorrectionID = 11
		ArticleTypeName = 12
		JournalID = 13
		Volume = 14
		IssueNo = 15
		LegacyJournalID = 16
		ArticleClientTypeID = 17
		ArticleRootTypeID = 18
		ArticleClientType = 19
		ArticleClientTypeOrdinal = 20
		ArticleClientTypeBrowsable = 21
		FreeView = 22
		siteID = 23
		activeDate = 24
		dateXML = 25
		IsPAP = 26
		PrintDate = 27
		ConferenceSessionID = 28
		startPage = 29
		endPage = 30
		ResourceAccessType = 31
		clientID = 32
		relevancy = 33 '' only used in the context of categories. so always keep this at the bottom

	End Enum

	Public Enum eArticleSubjectFields
		ID = 0
		ArticleID = 1
		SubjectXml = 2
	End Enum

	Public Enum eArticlesIssueFields
		Volume = 14
		PublicationDate = 15
		IssueNo = 16
		IssuePages = 17
	End Enum

	Public Enum eAlertFields
		ID = 0
		AlertTypeID = 1
		SiteID = 2
		DataQuery = 3
		SubjectTemplate = 4
		BodyTemplate = 5
		DigestTemplate = 6
		FromEmailAddress = 7
		RunInterval = 8
		LastRunDate = 9
		NextRunDate = 10
		ProcessingStartDate = 11
		ProcessingMachineName = 12
		ProcessingEndDate = 13
		ResourceID = 14
		ResourceTypeID = 15
		RecipientEmail = 16
		UrlTemplate = 17
	End Enum

	Public Enum eAlertTriggerFields
		ID = 0
		AlertID = 1
		ResourceID = 2
		CreationDate = 3
		UpdateDate = 4
	End Enum

	Public Enum eMultiMediaFields
		ID = 0
		MultiMediaTypeID = 1
		URL = 2
		Height = 3
		Width = 4
		Filename = 5
		FileSize = 6
		ClientID = 7
		FreeView = 8
		PublicationDate = 9
		ActivateDate = 10
		IsDisclosure = 11
		IsDataSupplement = 12
		Title = 13
		ThumbnailMultimediaId = 14
		Duration = 15

		ArticleID = 16
		BookID = 17
		CategoryId = 18
		SectionID = 19

		DOI = 20
		AID = 21
		LegacyID = 22
		IsShared = 23
		ShortDescriptionXML = 24
		Ordinal = 25
		LanguageID = 29
	End Enum

	Public Enum eMultimediaThirdPartyFields
		ID = 0
		MultimediaId = 1
		VideoId = 2
		PlayerId = 3
		PlayerKey = 4
	End Enum

	Public Enum eCmeSpecialtyFields
		ID = 0
		SiteID = 1
		LegacySpecialtyID = 2
		Name = 3
		Ordinal = 4
	End Enum

	Public Enum eQuizzesFields
		ID = 0
		LegacyQuizID = 1
		Name = 2
		QuizTypeID = 3
		AID = 4
		Title = 5
		PubDate = 6
		ExpireDate = 7
		Credits = 8
		ClientID = 9
		PassingScore = 10
		CmeSpecialtyID = 11
		ActiveDate = 12
		FreeView = 13
		ResourceID = 14
		ResourceTypeID = 15
		EvalQuizId = 16
		SectionXML = 17
		MasterPartID = 18
		MasterSectionID = 19
		QuizInfoID = 20
		TerminationDate = 21
	End Enum

	Public Enum eQuizAnswerFields
		ID = 0
		QuizQuestionID = 1
		Ordinal = 2
		AnswerKey = 3
		SectionID = 4
		IsCorrectAnswer = 5
		SectionXML = 6

	End Enum

	Public Enum eQuizQuestionFields

		ID = 0
		SectionID = 1
		QuizQuestionTypeID = 2
		Ordinal = 3
		SectionXML = 4
		RefArticleID = 5
		RefSectionXML = 6
		IsOptional = 7

	End Enum

	Public Enum eUserQuizFields
		ID = 0
		UserID = 1
		QuizID = 2
		StartDate = 3
		EndDate = 4
		UserQuizStageID = 5
		Score = 6
		Title = 7
		UserQuizStage = 8
		ClientData = 9
		UpdateDate = 10
	End Enum

	Public Enum eUserQuizQuestionAnswerFields
		UserQuizID = 0
		QuestionID = 1
		AnswerID = 2
		AnswerExtra = 3
	End Enum

	Public Enum eUserCMEFields
		UserCMEID = 0
		UserID = 1
		QuizID = 2
		CreditClaimed = 3
		CmeCreditTypeID = 4
		ClaimDate = 5

	End Enum

	Public Enum eUserFields
		ID = 0
		Username = 1
		Password = 2
		PasswordHint = 3
		PasswordSalt = 4
		AccountID = 5
		CreationDate = 6
		UpdateDate = 7
		PasswordResetGUID = 8
		PasswordResetCreationDate = 9
		ClientID = 10
		InferredInstitutionID = 11
		LegacyUserName = 12
	End Enum
	Public Enum eUserProfileFields
		UserID = 0
		FirstName = 1
		MiddleName = 2
		LastName = 3
		Email = 4
		Title = 5
		Organization = 6
		Phone = 7
		WorkPhone = 8
		MobilePhone = 9
		Pager = 10
		Fax = 11
		Url = 12
		ProfessionID = 13
		SpecialtyID = 14
		ReceivesMarketingEmailAlerts = 15
		CreationDate = 16
		UpdateDate = 17
		WebsiteReferralID = 18
		VendorID = 19
		Suffix = 20
		MemberNumber = 21
	End Enum

	Public Structure TermsFields
		Public Const ID As String = "ID"
		Public Const Term As String = "term"
		Public Const DisplayTerm As String = "displayTerm"
		Public Const Score As String = "score"
	End Structure

	Public Enum eGroupsFields
		ID = 0
		Name = 1
		GroupTypeId = 2
		SiteId = 3
        LanguageId = 4
        Ordinal = 5
	End Enum

	Public Enum eCitationFields
		ID = 0
		citedescription = 1
		citedateupdated = 2
		pubmedid = 3
		articleid = 4
		wosid = 5
		timesCited = 6
		citingArticlesURL = 7
		relatedRecordsURL = 8
		sourceURL = 9
	End Enum

	Public Enum eJobFields
		ID = 0
		Title = 1
		City = 2
		Statename = 3
		Countryname = 4
		Company = 5
		DateUpdated = 6
		JobDescription = 7
		Specialty = 8
		ClientID = 9
		SpecialtyID = 10
		CategoryID = 11
		RSSsource = 12
		RSSFeedID = 13

	End Enum

	Public Enum eErrataFields
		id = 0
		AID = 1
		Title = 3
	End Enum

	Public Enum eSubscriptionFields
		id = 0
		accountid = 1
		isactive = 2
		creationdate = 3
		startdate = 4
		enddate = 5
		subscriptiontypeid = 6
		price = 7
		discount = 8
		finalRate = 9
		seatsPurchased = 10
		graceEndDate = 11
		sponsorshipID = 12
		productName = 13
		internalOrderId = 14
		externalOrderId = 15
		advagreementtype = 16
		advorderbycustomernumber = 17
		advbillingstatustypeid = 18
		advsubscriptionstatustypeid = 19
		advagreementstatustypeid = 20
		perpetualStartDate = 21
		perpetualEndDate = 22
		legacySubscriptionID = 23
	End Enum

	Public Enum eSponsorshipFields
		id = 0
		name = 1
		vendorID = 2
		clientID = 3
	End Enum

	Public Enum eClientFields
		ID = 0
		Name = 1
		HashProviderTypeID = 2
		ShortName = 3
	End Enum

	Public Enum eClientApiInformationFields
		ClientID = 0
		SharedKey = 1
		ThrottlingMaxRequestsPerPeriod = 2
		ThrottlingNodeCount = 3
		ThrottlingNodePeriodMinutes = 4
		SearchTaxonomyId = 5
	End Enum

	Public Enum eAffiliations
		Name = 0
		LastActivity = 1
		InstitutionId = 2
		IsMobileUser = 3
		Email = 4
		FirstName = 5
		LastName = 6
		CreationDate = 7
		UserId = 8
	End Enum

	Public Enum eSites
		ID = 0
		Name = 1
		ClientID = 2
		HostName = 3
	End Enum

	Public Enum eAccountFields
		id = 0
		isactive = 1
		creationdate = 2
		updatedate = 3
		clientid = 4
	End Enum

	Public Enum eProductFields
		id = 0
		name = 1
		price = 2
		siteid = 3
		productTerms = 4
		productTermsType = 5
		gracePeriodDays = 6
		productType = 7
		seatsPurchased = 8
		vendorProductDetails = 9
		vendorProductCode = 10
	End Enum

	Public Enum eRoleFields
		id = 0
		roleName = 1
		clientID = 2
		siteMaster = 3
		isSOL = 4
	End Enum

	Public Enum ePermissionFields
		id = 0
		permissionName = 1
	End Enum

	Public Enum eInstitutionFields
		id = 0
		name = 1
		institutiontypeid = 2
		creationdate = 3
		updatedate = 4
		url = 5
		address1 = 6
		address2 = 7
		city = 8
		stateid = 9
		countryid = 10
		postalcode = 11
		accountID = 12
		athensID = 13
		isSpecialAccessIps = 14
		vendorID = 15
		phone = 16
		fax = 17
		RequestedConcurrency = 18
		FTENumberRangeID = 19
		ConsortiaMasterInstitutionId = 20
		AvailableForConsortiaMaster = 21
		ShibbolethID = 22
		CountryWideAccessCountryID = 23
		region = 24
		ClientId = 25
		IsSOLActive = 26
	End Enum

	Public Enum eInstitutionIPAddressFields
		id = 0
		institutionid = 1
		ipPart1 = 2
		ipPart2 = 3
		ipPart3 = 4
		ipPart4 = 5
		creationDate = 6
		isProxy = 7

	End Enum
	Public Enum ePrivateIPAddressFields
		ID = 0
		IPStartPart1 = 1
		IPStartPart2 = 2
		IPStartPart3 = 3
		IPStartPart4 = 4
		IPEndPart1 = 5
		IPEndPart2 = 6
		IPEndPart3 = 7
		IPEndPart4 = 8
	End Enum
	Public Enum eUrlReferrelFields
		URLReferrerID = 0
		Institutionid = 1
		URL = 2
		creationDate = 3
	End Enum

	Public Enum eUserCommentsFields
		ID = 0
		author = 1
		affiliation = 2
		title = 3
		comment = 4
		disclosure = 5
		commentStatusID = 6
		datePublished = 7
		publishingUserID = 8
		articleID = 9
		dateSubmitted = 10
		siteid = 11
		status = 12
		ArticleTitle = 13
	End Enum

	Public Enum eLinks
		LinkID = 0
		SourceID = 1
		DestinationID = 2
		SourceType = 3
		DestinationType = 4
		LinkTypeID = 5
		CreationDate = 6
		UpdateDate = 7
		ClientID = 8
		UpdaterID = 9
		SiteID = 10
		Ordinal = 11
	End Enum

	Public Enum eUrlRedirects
		UrlRedirectID = 0
		SourceUrl = 1
		DestinationUrl = 2
		ClientID = 3
	End Enum

	Public Enum eExceptionLogFields
		ID = 0
		MachineName = 1
		Source = 2
		ProcedureName = 3
		DateCreated = 4
		ExceptionString = 5

	End Enum
	Public Enum eUserAlertFields
		ID = 0
		UserID = 1
		SiteID = 2
		AlertTypeID = 3
		ResourceID = 4
		SignUpDate = 5
		AlertSentDate = 6
		SearchTerm = 7
		SerializedAlertMetadata = 8		 'Serialized Object representing SearchParametes Object
		ResourceTypeID = 16

		JournalName = 9					'Derived Column:Column doesn't belong to UserAlerts table.
		ArticleTitle = 10				'Derived Column:Column doesn't belong to UserAlerts table.
		BookTitle = 11					'Derived Column:Column doesn't belong to UserAlerts table.
		ChapterTitle = 12				'Derived Column:Column doesn't belong to UserAlerts table.
		CollectionName = 13				'Derived Column:Column doesn't belong to UserAlerts table.
		ParentResourceID = 14			' Derived Column: JournalID for Article Alerts
		HostName = 15					' HostName - Site Domain Name
        scheduleID= 17
	End Enum

	Public Enum eUserAlertFilterFields
		ID = 0
		AlertID = 1
		FilterTypeID = 2
		FilterValue = 3
	End Enum
	Public Enum eUserSessionFields
		ID = 0
		UserID = 1
		SiteID = 2
		SessionID = 3
		CreationDate = 4
		LastActivityDate = 5
	End Enum
	Public Enum eUserProfileAddressesFields
		ID = 0
		AddressTypeID = 1
		UserID = 2
		Address1 = 3
		Address2 = 4
		City = 5
		StateID = 6
		CountryID = 7
		PostalCode = 8
		updateDate = 9
		Address3 = 10
		Region = 11
		FirstName = 12
		LastName = 13
		CompanyName = 14
	End Enum

	Public Enum eClientCommentFields
		ID = 0
		UserID = 1
		AuthorID = 2
		Comment = 3
		DateCreated = 4
		ClientID = 5
		InstitutionID = 6
	End Enum


	Public Enum eEmailFields
		emailID = 0
		emailTypeID = 1
		emailStatusCodeID = 2
		userAlertID = 3
		fromAddress = 4
		toAddress = 5
		subject = 6
		body = 7
		cc = 8
		bcc = 9
		sourceIP = 10
		resultCode = 11
	End Enum

	Public Enum eSearchDropDownFields
		ID = 0
		GroupName = 1
		Name = 2
		ContentID = 3
		DistinctGroupName = 4
        Ordinal = 5
	End Enum
	Public Enum eHashProviderTypeFields
		ID = 0
		Name = 1
		PasswordSaltSize = 2
	End Enum
	Public Enum eUserSectionStuff
		UserID = 0
		SectionID = 1
	End Enum
	Public Enum eResourceFields
		ResourceID = 0
		ResourceTypeID = 1
		CME = 2
		PublicationStartDate = 3
		PublicationEndDate = 4
		ProductID = 5
		SubscriptionID = 6
		SubscriptionTypeID = 7
		SiteID = 8
	End Enum

	Public Enum eTimedAccessLinkFields
		ID = 0
		AccessKey = 1
		StartDate = 2
		EndDate = 3
		MaxUsages = 4
		CreatedByAccountID = 5
		ResourceID = 6
		ResourceTypeID = 7
		SectionID = 8
		ReferralUrl = 9
		Notes = 10
		ClientID = 11
	End Enum

	Public Enum eTimedAccessLinkUsageFields
		ID = 0
		TimedAccessLinkID = 1
		AccessTime = 2
	End Enum

	Public Enum eInstitutionOpenUrlFields
		id = 0
		institutionId = 1
		resolverBaseUrl = 2
		linkText = 3
		linkImage = 4
	End Enum
	Public Enum eAdInventoryFields
		ID = 0
		adGroupID = 1
		UniqueAds = 2
		TotalAdstoCheck = 3
		pageDescription = 4
		pageURL = 5
		adTags = 6
		ClientID = 7
	End Enum

	Public Enum eAdTargetingFields
		ID = 0
		adTargetingID = 1
		adTargetingTypeID = 2
		advertisingCode = 3
	End Enum

	Public Enum eClientFieldDefinitionWithHtmlAttributesFields
		Id = 0
		FieldLabel = 1
		FieldName = 2
		FieldType = 3
		IsRequired = 4
		LookupListMethod = 5
		DefaultValue = 6
		DisplayOrder = 7
		IsInstitutionLevelDefinition = 8
		AttributeName = 9
		AttributeValue = 10
		SpecifiedFieldValue = 11
		DependsOnClientFieldDefinitionID = 12
		IsReadOnly = 13
	End Enum

	Public Enum eClientFieldDefinitionOptionFields
		Id = 0
		ClientFieldDefinitionId = 1
		DisplayOrder = 2
		DisplayName = 3
		Value = 4
	End Enum

	Public Enum eResourceActionPermissionFields
		Id = 0
		ResourceTypeId = 1
		ResourceId = 2
		ResourceActionTypeId = 3
		IsEnabled = 4
		StartDate = 5
		EndDate = 6
		Duration = 7
	End Enum

	Public Enum eAuthorArticleAccessFields
		ID = 0
		AbstractRequests = 1
		ArticleID = 2
		AuthorID = 3
		FullReadRequests = 4
		PDFDownloadRequests = 5
		Month = 6
		Year = 7
	End Enum

	Public Enum eAuthorArticleCitationFields
		ID = 0
		ArticleID = 1
		AuthorID = 2
		CitingArticleTitle = 3
		CitingArticleAuthors = 4
		Cite = 5
	End Enum

	Public Enum eOrderFields
		orderID = 0
		accountID = 1
		creationUtcDate = 2
		price = 3
		discount = 4
		tax = 5
		payment = 6
		sourceID = 7
		vendorOrderId = 8
		shippingFirstName = 9
		shippingMiddlename = 10
		shippingLastName = 11
		shippingAddress1 = 12
		shippingAddress2 = 13
		shippingCity = 14
		shippingStateID = 15
		shippingCountryID = 16
		shippingPostalCode = 17
		shippingAddress3 = 18
		currencyCode = 19
		authorizationCode = 20
	End Enum

	Public Enum eOrderLineItemFields
		ID = 0
		orderID = 1
		ordinal = 2
		productID = 3
		productName = 4
		productDescription = 5
		price = 6
		discount = 7
		tax = 8
		finalPrice = 9
		currencyCode = 10
		quantity = 11
		promotionCode = 12
	End Enum

	Public Enum eOrderDiscountFields
		ID = 0
		orderID = 1
		orderLineItemID = 2
		discountCodeEntered = 3
		discountID = 4
	End Enum

	Public Enum ePaymentFields
		[ID] = 0
		[paymentDate] = 1
		[price] = 2
		[specialOfferCodeID] = 3
		[billingAddress1] = 4
		[billingAddress2] = 5
		[billingCity] = 6
		[billingStateID] = 7
		[billingCountryID] = 8
		[billingPostalCode] = 9
		[accountID] = 10
		[userID] = 11
		[orderID] = 12
		[transactionID] = 13
		[billingAddress3] = 14
		[currencyCode] = 15
		[last4DigitsOfPaymentMethod] = 16
		[paymentMethodID] = 17
	End Enum

	Public Enum eClientAPIKeysFields
		clientID = 0
		APITypeID = 1
		APIKey = 2
	End Enum

	Public Enum eAlertTypeFields
		[ID] = 0
		[name] = 1
		[dataQuery] = 2
	End Enum

	Public Enum eAPSAlertTypeFields
		[ID] = 0
		[name] = 1
		[allowLookAheads] = 2
	End Enum

	Public Enum eAlertTypes2ResourceTypesFields
		[alertTypeID] = 0
		[resourceTypeID] = 1
	End Enum

	Public Enum eAPSAlertsFields
		[ID] = 0
		[masterCampaignID] = 1
		[alertTypeID] = 2
		[isActive] = 3
		[siteID] = 4
		[resourceID] = 5
		[resourceTypeID] = 6
		[createDate] = 7
		[updateDate] = 8
		[contactologyCampaignFunction] = 9
		[campaignSendDelay] = 10
		[topSiteID] = 11
		[lastRunDate] = 12
		[nextRunDate] = 13
		[testMasterCampaignID] = 14
        [scheduleID]=15
	End Enum

	Public Enum eAPSAlertLookAheadsFields
		[ID] = 0
		[alertID] = 1
		[daysAhead] = 2
	End Enum

	Public Enum eAPSAlertTriggersFields
		[ID] = 0
		[alertID] = 1
		[campaignID] = 2
		[statusID] = 3
		[createDate] = 4
		[updateDate] = 5
		[dataFromDate] = 6
		[dataToDate] = 7
		[isTest] = 8
		[listId] = 9
	End Enum
	Public Enum eScheduleFields
		[ID] = 0
		[displayName] = 1
		[scheduleTypeID] = 2
		[cron] = 3
		[ordinal] = 4
	End Enum
	Public Enum eClientUsageViolations
		UsageViolationID = 0
		ClientID = 1
		UserID = 2
		InstitutionID = 3
		IPNumber = 4
		UsageViolationDate = 5
		ReinstatementRequestedBy = 6
		ReinstatementRequestedDate = 7
		ReinstatementRequestComment = 8
		ReinstatedBy = 9
		ReinstatedDate = 10
	End Enum
	Public Enum eClientUsageExemptIPAddresses
		ClientUsageExemptIPAddressID = 0
		ClientID = 1
		IPNumberStart = 2
		IPNumberEnd = 3
		Comment = 4
		DateCreated = 5
	End Enum

	Public Enum eUmlsTermFields
		ID = 0
		CUI = 1
		SourceTermId = 2
		Term = 3
		SourceId = 4
		SourceName = 5
	End Enum

	''' <summary>
	''' Funder who provides a FundRef award.
	''' See TA-5582 and ARB-133
	''' </summary>
	''' <remarks></remarks>
	Public Enum eFundRefFunderFields
		ID = 0
		FunderIdentifier = 1
		FunderName = 2
        EmbargoPeriod = 3
        EmbargoPeriodDateUnitID = 4
        EmbargoName = 5
	End Enum

	''' <summary>
	''' FundRef Award provided by a funder.
	''' See TA-5582 and ARB-133
	''' </summary>
	''' <remarks></remarks>
	Public Enum eFundRefAwardFields
		ID = 0
		VendorAwardID = 1
		FunderID = 2
		AwardType = 3
	End Enum

    Public Structure SectionAttributeFields
        Public Const SectionID = "SectionID"
        Public Const PageCount = "PageCount"
        Public Const Label = "Label"
        Public Const AltTitlesXML = "altTitlesXML"
        Public Const ActiveDate = "activeDate"
        Public Const SoftExpireDate = "softExpireDate"
        Public Const HardExpireDate = "hardExpireDate"
        Public Const StartPage = "startPage"
        Public Const EndPage = "endPage"
        Public Const SeekTime = "SeekTime"
    End Structure

    Public Structure eOutboundContentPackagesGeneratedFields
        Public Const ID = "Id"
        Public Const ClientID = "clientId"
        Public Const OutboundContentPackageSetID = "outboundContentPackageSetId"
        Public Const OutboundContentPackageSetScheduleConfigID = "outboundContentPackageSetScheduleConfigId"
        Public Const DisplayName = "displayName"
        Public Const RootDisplayName = "rootDisplayName"
        Public Const FilePath = "filePath"
        Public Const FileName = "fileName"
        Public Const FileSizeInBytesCompressed = "fileSizeInBytesCompressed"
        Public Const FileSizeInBytesUncompressed = "fileSizeInBytesUncompressed"
        Public Const ContentStartDate = "contentStartDate"
        Public Const ContentEndDate = "contentEndDate"
        Public Const ContentLastUpdateDate = "contentLastUpdateDate"
		Public Const IsActive = "isActive"
		Public Const FileDeletionDate = "fileDeletionDate"
        Public Const AccessCheckResourceID = "accessCheckResourceId"
        Public Const AccessCheckResourceTypeID = "accessCheckResourceTypeId"
        Public Const AccessCheckSiteID = "accessCheckSiteId"
    End Structure

#Region "Conference"
    'Public Enum eConferenceFields
    '    ConferenceID = 0
    '    ClientID = 1
    '    Name = 2
    '    ShortName = 3
    '    Location = 4
    '    Theme = 5
    '    LegacyConferenceID = 6
    '    StartDate = 7
    '    EndDate = 8
    '    DateXML = 9
    '    ParentConferenceID = 10
    '    Searchable = 11
    '    SiteID = 12
    '    ActiveDate = 13
    'End Enum
    Public Enum eConferenceVolumeFields
        VolumeID = 0
        VolumeNumber = 1
        Name = 2
        PublicationDate = 3
        OpenStatus = 4
        StatusUpdatedByUserId = 5
        StatusUpdatedOn = 6
        ActiveDate = 7
    End Enum
    Public Enum eConferenceSessionFields
        SessionID = 0
        VolumeID = 1
        ConferenceID = 2
        SessionName = 3
        ActiveDate = 4
    End Enum
#End Region

#Region "Self Serve"

    Public Enum eSelfServeContentFields
        Id = 0
        ClientId = 1
        SiteId = 2
        CreatedByAccountId = 3
        CreatedDate = 4
        UpdatedByAccountId = 5
        UpdatedDate = 6
        SiteMasterName = 7
        DisplayOrder = 8
        ParentSelfServeContentId = 9
        SelfServeContentType = 10
        Url = 11
        IsPermanent = 12
        Deleted = 13
        TopParentSelfServeContentId = 14
    End Enum

    Public Enum eSelfServeContentVersionFields
        Id = 0
        SelfServeContentId = 1
        ClientId = 2
        SiteId = 3
        CreatedByAccountId = 4
        CreatedDate = 5
        UpdatedByAccountId = 6
        UpdatedDate = 7
        ActiveDate = 8
        Content = 9
        Title = 10
        ShortName = 11
        TemplateID = 12
        IncludeInNavigation = 13
        HeadContent = 14
    End Enum

    Public Enum eSelfServeTemplateFields
        Id = 0
        ClientId = 1
        SiteId = 2
        Name = 3
        Active = 4
    End Enum
#End Region

#End Region

#Region "Object Type Enums"
    'Public Enum eCategoryTypeID As Integer
    '    JAMATopicCollection = 1
    'End Enum

    Public Enum eJournalRequestorType As Integer
        Client = 0
    End Enum

    Public Enum eUserRequesterType As Integer
        User
        Institution
    End Enum

    Public Enum eBooksRequesterType As Integer
        Group
        Client
    End Enum

    Public Enum eChapterRequesterType As Integer
        Book = 0
    End Enum

    Public Enum eGroupLevelRequester As Integer
        ChildGroup
        ParentGroup
    End Enum

    Public Enum eSectionRequesterType As Integer
        Article = 1
        FrontNote = 2
        Categories = 3
        Authors = 4
        Abstract = 5
        Paragraph = 6
        Table = 8
        Figure = 9
        ArticleInfo = 10
        Note = 11
        List = 12
        References = 13
        Acknowledgements = 14
        Quiz = 15
        DrugMonograph = 16
        Erratum = 17
        Book = 18
        Chapter = 19
        Multimedia = 20
        Gbos = 21
    End Enum

    Public Enum eTermsRequesterType As Integer
        Article
        ParentTerm
        ChildTerm
    End Enum

    Public Enum eCategoriesRequesterType As Integer
        Article
        ParentCategory
        ChildCategory
        Ad
        Term
        Multimedia
        News
        Section
        Quiz
        Gbos
        Group
        User
    End Enum

    Public Enum eMultimediasRequesterType As Integer
        Group
        Article
        Category
        Section
        Issue
        Book
        GBOS
        GBOSContainer
    End Enum

    Public Enum eSubscriptionsRequesterType As Integer
        Product
    End Enum

    Public Enum eSitesRequesterType As Integer
        Book = 0
        Journal = 1
    End Enum

    Public Enum eStateFields
        ID = 0
        CountryID = 1
        Code = 2
        Name = 3
    End Enum

    Public Enum eAgreementStatusTypeFields
        ID = 0
        AgreementStatus = 1
        AgreementStatusCode = 2
    End Enum

    Public Enum eSubscriptionStatusTypeFields
        ID = 0
        SubscriptionStatus = 1
        SubscriptionStatusCode = 2
    End Enum

    Public Enum eBillingStatusTypeFields
        ID = 0
        BillingStatus = 1
        BillingStatusCode = 2
    End Enum

    Public Enum eCountryFields
        ID = 0
        Code = 1
        Country = 2
        LongCode = 3
    End Enum

    Public Enum eProfessionFields
        ID = 0
        Code = 1
        Name = 2
        Ordinal = 3
        ClientID = 4
    End Enum

    Public Enum eSpecialities
        ID = 0
        Code = 1
        Name = 2
        ClientID = 3
    End Enum

    Public Enum eWebsiteReferralFields
        ID = 0
        Description = 1
        SortOrder = 2
    End Enum

    Public Enum eAuditType
        Insert
        Delete
        Update
    End Enum

    Public Enum eInstitutionTypeFields As Integer
        ID = 0
        Code = 1
        Name = 2
        Ordinal = 3
    End Enum

    Public Enum eEmailType As Integer
        EmailToAFriend = 1
        ForgotPassword = 2
        Alert = 3
        Request = 4
        UploadContent = 5
    End Enum

    Public Enum eEmailStatusCode As Integer
        Unsent = 1
        SendAttempted = 2
        Sent = 3
        FailedDelivery = 4
    End Enum

    Public Enum eAdditionalIssueContentType

        TableOfContents = 0
        Editorial = 1
        FrontMatter = 2
        BackMatter = 3
        Cover = 4

    End Enum

    Public Enum eInstitutionSSOAttributes
        AttributeId = 0
        AttributeName = 1
        InstitutionId = 2
    End Enum

    Public Enum eInstitutionFederationTypeFields
        ID = 0
        FederationType = 1
    End Enum

    Public Enum eInstitutionFederation2InstitutionFields
        ID = 0
        FederationID = 1
        InstitutionID = 2
    End Enum

    Public Enum eTokenConfigurationFields
        ID = 0
        ClientID = 1
        TokenConfigurationTypeID = 2
        TokenTypeID = 3
        ResourceTypeID = 4
        DurationTypeID = 5
        TokenConfiguredValue = 6
    End Enum

    Public Enum eTokenUsageFields
        ID = 0
        TokenBucketID = 1
        AccountID = 2
        UsageDate = 3
        Amount = 4
        ResourceID = 5
        ResourceTypeID = 6
    End Enum

    Public Enum eTokenBucketFields
        ID = 0
        TokenTypeID = 1
        AccountID = 2
        ProductID = 3
        Quantity = 4
        FillDate = 5
        StartDate = 6
        ExpiresDate = 7
        QuantityUsed = 8
        ProductName = 9
    End Enum

    Public Enum eUserSearchesFields

        ID = 0
        UserID = 1
        SiteID = 2
        SearchTerm = 3
        SearchDescription = 4
        CreateDate = 5
        LastSaveDate = 6
        SerializedSearchParameters = 7

	End Enum

	Public Enum eUserCommentAdministratorsFields

		Id = 0
		UserId = 1
		ClientId = 2
		SiteId = 3
		ResourceId = 4
		ResourceTypeId = 5

	End Enum

#End Region

#Region "Generics"
    Public Enum eforDataTable
        eArticleFields = 0
        eArticleTypeFields = 1
    End Enum
#End Region

#Region "Misc Enums"

    Public Enum eExtendedLogFields

        IndividualID = 0
        InstitutionID = 1
        UserCanView = 2
        InstitutionCanView = 3
        Occupation = 4
        Specialty = 5
        VenderID = 6
        IndividualVendorID = 7
        InstitutionalVendorID = 8

    End Enum

    Public Enum eReInstatementStatus
        Reinstated
        Suspended
        Pending
    End Enum

    Public Enum eArticleMetadataType
        KeyWord = 1
        Topic = 2
        Taxonomy = 3
        TocSection = 4
    End Enum

    Public Enum eMetadataType
        Title = 1
        Description = 2
        CanonicalUrl = 3
        NoFollowNoIndex = 4
    End Enum

#End Region

#Region "PDF RequestTypes"

    Public Enum ePDFRequestType

        ArticleTab
        Bookofthemonth
        BrowseByArticleType
        Browsebytagscollection
        CMEQUIZ
        Collectionpage
        ContentPage
        ContentToolBox
        DownloadCurrentIssue
        DownloadIssuecontents
        DsmPreviousEdition
        DSMPreviousEditions
        Guidelinespage
        IssuePage
        IssuesPage
        patientpage
        PDFCitationSearchResults
        PDFonlyarticle
        PDFOnlyArticles
        PDFSearchResults
        PSInAdvance
        ToolBox
        DataSuppliment
        GoogleMetaTags
        DirectPdfAccess
    End Enum


#End Region

#Region "Configuration"

    Public Enum eConfigSettingsFields
        [ID] = 0
        [UniqueName] = 1
        [Description] = 2
        [DefaultValue] = 3
        [ValueTypeID] = 4
        [ConfigSettingTypeID] = 5
        [ConfigurationLevelResourceTypeID] = 6
    End Enum

    Public Enum eConfigClientSettings
        [ID] = 0
        [ClientID] = 1
        [ConfigSettingID] = 2
        [Value] = 3
        [ResourceID] = 4
    End Enum

    Public Enum eConfigClientUserControlPages
        [ID] = 0
        [ConfigUserControlID] = 1
        [ConfigPageID] = 2
        [ClientID] = 3
        [ControlID] = 4
        [SiteID] = 5
    End Enum

    Public Enum eConfigClientUserControlSettings
        [ID] = 0
        [ConfigClientUserControlPageID] = 1
        [ConfigUserControlPageSettingsID] = 2
        [Value] = 3
    End Enum

    Public Enum eConfigUserControlPageSettings
        [ID] = 0
        ConfigUserControlID = 1
        UniqueName = 2
        Description = 3
        DefaultValue = 4
        ValueTypeID = 5
    End Enum

    Public Enum eCitationReplacementVariableFields
        [ID] = 0
        Name = 1
        Description = 2
    End Enum

    Public Structure eCacheKeyTemplateInfoFields
        Public Const [ID] = "ID"
        Public Const ClientID = "ClientID"
        Public Const CacheKeyTemplate = "CacheKeyTemplate"
        Public Const TimeoutMinutes = "TimeoutMinutes"
        Public Const UseLocalCache = "UseLocalCache"
        Public Const EmergencyBypassLocal = "EmergencyBypassLocal"
        Public Const SerializeLocalCache = "SerializeLocalCache"
        Public Const SerializeServerCache = "SerializeServerCache"
    End Structure
#End Region

#Region "Version Control"
    Public Enum eRepositoryControlStatus
        Success = 0
        Failure = 1
        AuthenticationFailed = 2
        Unknown = 3
    End Enum

    Public Enum eVersionControlMergeOption
        ''' <summary>
        ''' Use the default implementation
        ''' </summary>
        [Default] = 0

        ''' <summary>
        ''' Uses the local 'p1()' version of files as the merged version
        ''' </summary>
        UseLocalFiles = 1 

                ''' <summary>
        ''' Uses the other 'p2()' version of files as the merged version.
        ''' </summary>
        UseOtherFiles = 2

        ''' <summary>
        ''' Resolve all conflicts non-interactively in favor of the local 'p1()' changes.
        ''' </summary>
        MergeResolveLocal = 3

        ''' <summary>
        ''' resolve all conflicts non-interactively in favor of the other 'p2()' changes.
        ''' </summary>
        MergeResolveOther = 4
        
    End Enum

    Public Enum eVersionControlMergeResult
        Unknown = 0
        Success = 1
        Failure = 2
        NotApplicable = 3
    End Enum


#End Region
End Namespace
