Feature: Global Search functionality
	
Background: SetUp
	Given Homepage is opened
	Given Close Select your city dialog


Scenario Outline: Add two numbers	
	And Enter "<search text>" into Global Search field	
	Then Global Search Autosuggest list should be displayed
	Then All products name in Autosuggest list should contains "<search text>"
	Examples: 
	|search text|
	|телевизор|