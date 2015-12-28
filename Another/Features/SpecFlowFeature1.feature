Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee
	#Given i should see employee details
	#Then i will fill with a mandatory detail
	When i enter this numbers
	| Name  | Age | Phone   |
	| Erick | 23  | 5445545 |
	| Julian | 50  | 1212221 |

# Same scenario with multiple data 
Scenario Outline: Create a new employee with outlines
	#Given i should see employee details
	#Then i will fill with a mandatory detail
	When i enter this details <Name> and <Age> and <Phone>
	Examples: 
	| Name  | Age | Phone   |
	| Erick | 23  | 5445545 |
	| Julian | 50  | 1212221 |

