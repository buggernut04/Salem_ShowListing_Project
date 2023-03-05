The following program is a show Listing application used to rate different kind of shows based on the  users perspective towards the show. It will serve as the world’s most trusted recommendation resources for quality entertainment. 
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
* isValidEmail
* isValidPassword
* MaskedPassword


Class Name: Audience extends User
Attributes:
* Same as the User
Methods:

Class Name: Administrator extends User 
Attributes:
* Administrator Key
* Admin Position(Top, Middle, Low) - enum; each position has a corresponding percentage when they will going to rank a specific show:
	Top - 20%
	Middle - 15%
	Low - 10%
Methods:



Class Name: Show
Attributes:
* Title
* Director
* Main Cast
* Show Type (Movie, Theatre, TV Series, Reality Show) - enum
* Show Genre - enum
* Show Rating (G, PG, R, NP) - enum
Methods:


Class Name: RateShow
Attributes:
* Show
* Audience
* Administrator
Methods:




