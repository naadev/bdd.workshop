Feature: SquareRoot
	As Alice (the customer)
	I want to get the square root from a number
	So I can draw spheres in 3D space and solve quadratic equations

Scenario: Take a square root from a number
	Given the number is 16
	When the square root from the number is taken
	Then the result of square root operation should be 4

Scenario Outline: Taking several square roots
	When the square root of a number <number> is taken
	Then the result of square root operation should be <result>
	Examples:
	| number                   | result                  |
	| -1                       | NaN                     |
	| 0                        | 0                       |
	| 1                        | 1                       |
	| 2                        | 1.4142135623730951      |
	| 3                        | 1.7320508075688772      |
	| 25                       | 5                       |
	| 10000                    | 100                     |
	| 10000.1                  | 100.00049999875         |
	| 1.7976931348623157E+308  | 1.3407807929942596e+154 |
	| -1.7976931348623157E+308 | NaN                     |
	| ∞                        | ∞                       |
	| -∞                       | NaN                     |
