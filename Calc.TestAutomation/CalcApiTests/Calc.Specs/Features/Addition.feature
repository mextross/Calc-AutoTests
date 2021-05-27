Feature: Addtion

  @addingIntegers
  Scenario Outline: Adding 2 positive integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 1          | 2           | 3      |
    | 3          | 4           | 7      |
    | 5          | 6           | 11     |
    | 7          | 8           | 15     |
    | 1          | 9           | 10     |
    | 34         | 58          | 92     |
    | 99         | 1           | 100    |
    | 1          | 999         | 1000   |
    | 999        | 999         | 1998   |


   @addingIntegers
  Scenario Outline: Adding 2 negative integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -1         | -2          | -3     |
    | -3         | -4          | -7     |
    | -5         | -6          | -11    |
    | -7         | -8          | -15    |
    | -1         | -9          | -10    |
    | -34        | -58         | -92    |
    | -99        | -1          | -100   |
    | -1         | -999        | -1000  |
    | -999       | -999        | -1998  |


   @addingIntegers
  Scenario Outline: Adding 1 positive and 1 negative integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 1          | -2          | -1     |
    | -3         | 4           | 1      |
    | 5          | -6          | -1     |
    | -7         | 8           | 1      |
    | 1          | -9          | -8     |
    | -34        | 58          | 24     |
    | 99         | -1          | 98     |
    | -1         | 999         | 998    |
    | 999        | -999        | 0      |

  @addingIntegers
  Scenario Outline: Adding 0 and an integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -1         | 0           | -1     |
    | 0          | 2           | 2      |
    | 3          | 0           | 3      |
    | 0          | -4          | -4     |
    | 5          | 0           | 5      |
    | 0          | 6           | 6      |
    | 7          | 0           | 7      |
    | 0          | 8           | 8      |
    | 9          | 0           | 9      |
    | 0          | 100         | 100    |
    | -999       | 0           | -999   |

  @addingIntegers
  Scenario Outline: Adding 2 large numbers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result     |
    | 165168746  | 165466894   | 330635640  |
    | -165168746 | -165466894  | -330635640 |
    | -8643684   | 789648353   | 781004669  |
 


   @addingdecimals
  Scenario Outline: Adding 2 positive decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 1.5        | 3.6         | 5.1    |


  @addingdecimals
  Scenario Outline: Adding 2 negative decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -0.7       | -2.8        | -3.5   |

   @addingdecimals
  Scenario Outline: Adding 1 positive and 1 negative decimal
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -9.5       | 3.2         | -6.3   |


  @addingdecimals
  Scenario Outline: Adding 2 small decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are added
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result   |
    | 0.000006   | 0.0023      | 0.002306 |


