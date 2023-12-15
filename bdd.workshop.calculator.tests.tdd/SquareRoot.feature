Feature: SquareRoot
	As Alice (the customer)
	I want to get the square root from a number
	So I can solve the Pythagorean theorem

Scenario: Take a square root from a number
	Given the number is 16
	When the square root from the number is taken
	Then the square root of the number should be 4
