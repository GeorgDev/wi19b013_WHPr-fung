Feature: Rechnen
	Um Rechenoperationen 
	als ein laie korrekt durchzuführen
	will ich die Grundrechenarten durchführen

@mytag
Scenario: Addition
	Given the first number is 4
	And the second number is 2
	When the two numbers are added
	Then the result should be 6


Scenario: Subtraktion
	Given the first number is 4
	And the second number is 2
	When the second number is substracted from the first number
	Then the result should be 2

Scenario: Multiplikation
	Given the first number is 4
	And the second number is 2
	When the two numbers are multiplicated
	Then the result should be 8

Scenario: Division
	Given the first number is 4
	And the second number is 2
	When the first number is divided by the second number
	Then the result should be 2