Feature: Calculator
Simple calculator for adding **two** numbers


	@add-api
Scenario: Adding 2 positive integers
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



	@add-api
Scenario: Adding 2 negative integers
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


@add-api
Scenario: Adding 1 positive and 1 negative integer
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


@add-api
Scenario: Adding 0 and an integer
	Given I have the first number
	| Number1 |
	|-1       |
	| 0       |
	| 3       |
	| 0       |
	| 5       |
	| 0       |
	| 7       |
	| 0       |
	| 9       |
	| 0       |
	|-999     |
	And the second number 
	| Number2 |
	| 0       |
	| 2       |
	| 0       |
	| -4      |
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
	| -1     |
	| 2      |
	| 3      |
	| -4     |
	| 5      |
	| 6      |
	| 7      |
	| 8      |
	| 9      |
	| 100    |
	|-999    |

@add-api
Scenario: Adding 2 positive decimals
	Given I have the first number
	| Number1 |
	| 1.5     |



	And the second number 
	| Number2 |
	| 3.6     |
  
	When both numbers are added
	Then the answer should be the following
	| Result |
	|5.1     |

@add-api
Scenario: Adding 2 negative decimals
	Given I have the first number
	| Number1 |
	| -0.7    |


	And the second number 
	| Number2 |
	| -2.8    |
  
	When both numbers are added
	Then the answer should be the following
	| Result |
	|-3.5    |

@add-api
Scenario: Adding 1 postive and 1 negative decimal
	Given I have the first number
	| Number1 |
	| -9.5    |


	And the second number 
	| Number2 |
	| 3.2    |
  
	When both numbers are added
	Then the answer should be the following
	| Result |
	|-6.3    |


@add-api
Scenario: Adding 2 large integers
	Given I have the first number
	| Number1 |
	|165168746|
	|-165168746|
	|-8643684|


	And the second number 
	| Number2 |
	|165466894|
	|-165466894|
	|789648353|
  
	When both numbers are added
	Then the answer should be the following
	| Result |
	|330635640|
	|-330635640|
	|781004669|


@add-api
Scenario: Adding 2 small decimals
	Given I have the first number
	| Number1 |
	|0.000006|

	And the second number 
	| Number2 |
	|0.0023|

	When both numbers are added
	Then the answer should be the following
	| Result |
	|0.002306|


@subtract-api
Scenario: Subtracting 2 positive integers
	Given I have the first number
	| Number1 | 
	|        1|         
	|        3|          
	|        6|      
	|        8|
	|        1| 
	|       34|   
	|       99|
	|        1| 
	And the second number
	|Number2 |
	|        2|
	|        4|
	|        5|
	|        7|
	|        9|
	|       58|
	|        1|
	|      999|
	When both numbers are subtracted
	Then the answer should be the following
	| Result  | 
	|       -1|        
	|       -1|         
	|        1|      
	|        1|
	|       -8| 
	|      -24| 
	|       98|
	|     -998| 


@subtract-api
Scenario: Subtracting 2 negative integers
	Given I have the first number
	| Number1 | 
	|      -99|         
	|       -0|          
	|       -1|      
	|       -3|
	|       -5| 
	|       -8|   
	|       -9|
	|      -34| 
    |      -99| 
	|       -1| 
	And the second number
	|Number2 |
	|     -99|
	|      -0|
	|      -2|
	|      -4|
	|      -6|
	|      -7|
	|      -1|
	|     -58|
	|      -1|
	|     -99|
	When both numbers are subtracted
	Then the answer should be the following
	| Result  | 
	|        0|        
	|        0|         
	|        1|      
	|        1|
	|        1| 
	|       -1| 
	|       -8|
	|       24| 
	|      -98|
	|       98|

@subtract-api
Scenario: Subtracting 1 positive and 1 negative integer
	Given I have the first number
	| Number1 | 
	|        1|         
	|       -3|          
	|        5| 
	|       -7| 
	|        9| 
	|      -34| 
	|       99| 
	|       -1| 
	|      -99| 

	And the second number
	|Number2 |
	|      -2|
	|       4|
	|      -6|
	|       8|
	|      -1|
	|      58|
	|      -1| 
	|     999| 
	|      99| 

	When both numbers are subtracted
	Then the answer should be the following
	| Result  | 
	|        3|        
	|       -7|         
	|       11|  
	|      -15|  
	|       10|  
	|      -92| 
	|      100|  
	|    -1000| 
	|     -198| 

@subtract-api
Scenario: Subtracting 0 and an integer
	Given I have the first number
	| Number1 |
	|-1       |
	| 0       |
	| 3       |
	| 0       |
	| 5       |
	| 0       |
	| 7       |
	| 0       |
	| 9       |
	| 0       |
	|-999     |
	|0        |
	And the second number 
	| Number2 |
	| 0       |
	| 2       |
	| 0       |
	| -4      |
	| 0       |
	| 6       |
	| 0       |
	| 8       |
	| 0       |
	| 100     |
	| 0       |   
	| -0      | 
	When both numbers are subtracted
	Then the answer should be the following
	| Result |
	| -1     |
	|-2      |
	| 3      |
	| 4      |
	| 5      |
	|-6      |
	| 7      |
	|-8      |
	| 9      |
	|-100    |
	|-999    |
	|0       |

@add-api
Scenario: Subtracting 2 positive decimals
	Given I have the first number
	| Number1 |
	| 4.6     |

	And the second number 
	| Number2 |
	| 8.2     |
  
	When both numbers are added
	Then the answer should be the following
	| Result |
	|-3.6    |

	
@subtract-api
Scenario: Subtracting 2 negative decimals
	Given I have the first number
	| Number1 |
	|-1.2|

	And the second number 
	| Number2 |
	|-8.5|

	When both numbers are added
	Then the answer should be the following
	| Result |
	|-9.7|

		
@subtract-api
Scenario: Subtracting 2 small decimals
	Given I have the first number
	| Number1 |
	|0.0008|

	And the second number 
	| Number2 |
	|0.002|

	When both numbers are added
	Then the answer should be the following
	| Result |
	|-0.0012|


@subtract-api
Scenario: Subtracting 2 large integers
	Given I have the first number
	| Number1 |
	|-8643684|
	|8643684|
	|165466894|

	And the second number 
	| Number2 |
	|-789648353|
	|-789648353|
	|330635640|

	When both numbers are subtracted
	Then the answer should be the following
	| Result |
	|781004669|
	|-781004669|
	|-781004669|
	|-165168746|
	



@multiply-api
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

	
@divide-api
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
	

