Feature: Calculator

Background: 
	Given The calculator application is started

Scenario Outline: TestCalculator
	When I select <specificView> calculator view
	    And I input 12 into calculator
		And I add 999 to current result
	Then 1011 is displayed as result

	When I store the displayed result to calculator memory
		And I input 19 into calculator
		And <Step_Definition>
	Then <result> is displayed as result

	Examples: 
	| result | specificView | Step_Definition                         |
	| 1030   | Standard     | I add the number from calculator memory |
	| 361    | Scientific   | I square the result                     |
