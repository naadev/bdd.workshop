Feature: SquareRoot
	As Martha (the customer)
	I want to execute binary operations
	So I can save my time


Scenario: Square Root of 0
	Given the number 0
	When get the square root
	Then the result should be 0.0

Scenario: Square Root of 4
	Given the number 4
	When get the square root
	Then the result should be 2.0

Scenario: Square Root of 9
	Given the number 9
	When get the square root
	Then the result should be 3.0

Scenario: Square Root of 16
	Given the number 16
	When get the square root
	Then the result should be 4.0
