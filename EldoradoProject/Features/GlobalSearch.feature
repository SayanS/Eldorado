Feature: Global Search functionality
	
Background: SetUp
	Given Homepage is opened
	Given Close Select your city dialog


Scenario Outline: Check Autosuggest list of Global Search field	
	And Enter "<search text>" into Global Search field	
	Then Global Search Autosuggest list should be displayed
	Then All products name in Autosuggest list should contains "<search text>"
	When Click on item "Магазины" of Header navigation menu 
	Then Shops page should be opened with title "Магазины Eldorado"
	Examples: 
	| search text |
	| телевизор   |
	| холодильник |
	| пылесос     |
	| несуществующий     |

	