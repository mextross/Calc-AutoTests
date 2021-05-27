Feature: Multiplication

  @multiplyingIntegers
  Scenario Outline: Mutiplying 2 positive integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 0          | 0           | 0      |
    | 1          | 2           | 2      |
    | 2          | 1           | 2      |
    | 3          | 4           | 12     |
    | 6          | 5           | 30     |
    | 8          | 7           | 56     |
    | 1          | 9           | 9      |
    | 1          | 999         | 999    |
    | 99         | 10          | 990    |
    | 34         | 58          | 1972   |
    | 99         | 1           | 99     |
    | 999        | 999         | 998001 |
    | 998        | 998         | 996004 |

  @multiplyingIntegers
  Scenario Outline: Mutiplying 2 negative integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -99        | -99         | 9801   |
    | -1         | -2          | 2      |
    | -3         | -4          | 12     |
    | -5         | -6          | 30     |
    | -7         | -8          | 56     |
    | -9         | -1          | 9      |
    | -34        | -58         | 1972   |
    | -99        | -1          | 99     |
    | -999       | -999        | 998001 |

   @multiplyingIntegers
  Scenario Outline: Mutiplying 1 positive and 1 negative integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result  |
    | 1          | -2          | -2      |
    | -3         | 4           | -12     |
    | 5          | -6          | -30     |
    | -7         | 8           | -56     |
    | 9          | -1          | -9      |
    | -34        | 58          | -1972   |
    | 99         | -1          | -99     |
    | -1         | 999         | -999    |
    | -999       | 999         | -998001 |
 

  @multiplyingIntegers
  Scenario Outline: Mutiplying 0 and an integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -1         | 0           | 0      |
    | 0          | 2           | 0      |
    | 3          | 0           | 0      |
    | 0          | -4          | 0      |
    | 5          | 0           | 0      |
    | 0          | 6           | 0      |
    | 7          | 0           | 0      |
    | 0          | 8           | 0      |
    | 9          | 0           | 0      |
    | 0          | 100         | 0      |
    | -999       | 0           | 0      |
    | 0          | -0          | 0      |


  @multiplyingIntegers
  Scenario Outline: Mutiplying 2 large integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result      |
    | 86436      | 7896        | 682498656   |
    | 864360     | 78960       | 68249865600 |


  @multiplyingDecimals
  Scenario Outline: Mutiplying 2 positive decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 1.52       | 3.67        | 5.5784 |


  @multiplyingDecimals
  Scenario Outline: Mutiplying 2 negative decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -0.7       | -2.8        | 1.96   |


  @multiplyingDecimals
  Scenario Outline: Mutiplying 1 positive and 1 negative decimal
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are multiplied
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -9.5       | 3.2         | -30.4  |


