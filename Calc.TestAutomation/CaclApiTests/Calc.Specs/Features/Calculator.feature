Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Calc.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


	@add-api
Scenario: Adding 2 positive numbers
	Given I have the first number
	| Number1 |
	| 1       |
	| 3       |
	| 5       |
	| 7       |
	| 1       |
	| 34      |
	| 99      |
	| 1       |
	| 999     |
	| 0       |
	| 0       |
	And the second number 
	| Number2 |
	| 2       |
	| 4       |
	| 6       |
	| 8       |
	| 9       |
	| 58      |
	| 1       |
	| 999     |
	| 999     |
	| 1       |
	| 0       |    
	When both numbers are added
	Then the answer should be the following
	| Result |
	| 3      |
	| 7      |
	| 11     |
	| 15     |
	| 10     |
	| 92     |
	| 100    |
	| 1000   |
	| 1998   |
	| 1      |
	| 0      |

	
	@add-api
Scenario: Adding 2 negative numbers
	Given I have the first number
	| Number1 |
	| -1      |
	| -3      |
	| -5      |
	| -7      |
	| -1      |
	| -34     |
	| -99     |
	| -1      |
	| -999    |
	| -0      |
	| -0      |
	And the second number 
	| Number2 |
	| -2      |
	| -4      |
	| -6      |
	| -8      |
	| -9      |
	| -58     |
	| -1      |
	| -999    |
	| -999    |
	| -1      |
	| -0      |   
	When both numbers are added
	Then the answer should be the following
	| Result |
	| -3     |
	| -7     |
	| -11    |
	| -15    |
	| -10    |
	| -92    |
	| -100   |
	| -1000  |
	| -1998  |
	| -1     |
	| 0      |

		@add-api
Scenario: Adding 1 positive and 1 negative number
	Given I have the first number
	| Number1 |
	| 1       |
	| -3      |
	| 5       |
	| -7      |
	| 1       |
	| -34     |
	| 99      |
	| -1      |
	| 999     |
	| -0      |
	| 0       |
	And the second number 
	| Number2 |
	| -2      |
	| 4       |
	| -6      |
	| 8       |
	| -9      |
	| 58      |
	| -1      |
	| 999     |
	| -999    |
	| 1       |
	| -0      |   
	When both numbers are added
	Then the answer should be the following
	| Result |
	| -1     |
	| 1      |
	| -1     |
	| 1      |
	| -8     |
	| 24     |
	| 98     |
	| 998    |
	| 0      |
	| 1      |
	| 0      |

			@add-api
Scenario: Adding 0 and a negative number
	Given I have the first number
	| Number1 |
	| 1       |
	| 0       |
	| 3       |
	| 0       |
	| 5       |
	| 0       |
	| 7       |
	| 0       |
	| 9       |
	| 0       |
	| 999     |
	And the second number 
	| Number2 |
	| 0       |
	| 2       |
	| 0       |
	| 4       |
	| 0       |
	| 6       |
	| 0       |
	| 8       |
	| 0       |
	| 100     |
	| 0       |   
	When both numbers are added
	Then the answer should be the following
	| Result |
	| 1      |
	| 2      |
	| 3      |
	| 4      |
	| 5      |
	| 6      |
	| 7      |
	| 8      |
	| 9      |
	| 100    |
	| 999    |




@subtract
Scenario: Subtracting 2 numbers
	Given I have the first number
	| Number1 | 
	|        1|         
	|       -1|          
	|    10000|      
	|        0|      
	And the second number
	|Number2 |
	|        2|
	|       -2|
	|      999|
	|        1|
	When both numbers are subtracted
	Then the answer should be the following
	| Result  | 
	|       -1|        
	|        1|         
	|     9001|      
	|       -1|     


@subtract
Scenario: Multiplying 2 numbers
	Given I have the first number
	| Number1 | 
	|        1|         
	|       -1|            
	And the second number
	|Number2 |
	|        2|
	|       -2|
	When both numbers are multiplied
	Then the answer should be the following
	| Result  | 
	|        2|        
	|        2|         

	
@subtract
Scenario: Dividing 2 numbers
	Given I have the first number
	| Number1 | 
	|        2|         
	|       -9|            
	And the second number
	|Number2 |
	|        2|
	|       -3|
	When both numbers are divided
	Then the answer should be the following
	| Result  | 
	|        1|        
	|        3|       
	

