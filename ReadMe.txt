***** Description in the Main Program and as well as in the classess ****

The following classes will be implemented in order to construct the said application:

Class Name: User (ABSTRACT)
Attributes:
* User ID
* User Name
* Birthdate
* Gender
* Nationality 
* Email
* Password
Methods:
* SetNewPassword
* IsValidEmail
* IsValidPassword
* MaskedPassword


Class Name: Audience extends User
Attributes:
* Same as the User
Methods:


Class Name: Administrator extends User 
Attributes:
* Admin Position(Top, Middle, Low) - enum; each position has a corresponding percentage when they will going to rank a specific show:
	Top - 20%
	Middle - 15%
	Low - 10%
Methods:
* IsAdministratorKey
* CodeVerifier

Class Name: Administrator Rate
Attributes:
* Administrator
* Show
Methods:
* GetAdminRate

Class Name: Audience Rate
Attributes:
* Audience
* Show
Methods:
* GetAudRate


Class Name: Show
Attributes:
* Title
* Director
* Main Cast
* Show Release
* Show Type (Movie, Theatre, TV Series, Reality Show) - enum
* Show Genre - enum
* Show Classification (G, PG, R, NP) - enum
* NumOfPeopleRated - number of people that rated the show
Methods:


Class Name: Show Meter
Attributes:
* List<AudienceRate> NumOfAudience;
* List<AdministratorRate> NumOfAdministrator;     
* AudienceRating
* AdminRating
Methods:
* ComputeAvgAudienceRate
* ComputeAvgAdministratorRate









