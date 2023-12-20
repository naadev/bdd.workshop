Feature: SquareRoot
	As Martha (the customer)
	I want to execute binary operations
	So I can save my time


Scenario: Square Root of 0
	Given the number 0
	When get the square root
	Then the result must be 0
	And displayed number is 0
	And displayed result is 0

Scenario: Square Root of 4
	Given the number 4
	When get the square root
	Then the result must be 2
	And displayed number is 4
	And displayed result is 2

Scenario: Square Root of 9
	Given the number 9
	When get the square root
	Then the result must be 3
	And displayed number is 9
	And displayed result is 3

Scenario: Square Root of 16
	Given the number 16
	When get the square root
	Then the result must be 4
	And displayed number is 16
	And displayed result is 4
