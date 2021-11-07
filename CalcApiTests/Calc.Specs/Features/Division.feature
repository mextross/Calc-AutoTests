Feature: Division

  @dividingIntegers
  Scenario Outline: Dividing 2 positive integers with no remainder
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 4          | 2           | 2      |
    | 9          | 3           | 3      |
    | 10         | 5           | 2      |
    | 100        | 20          | 5      |
    | 99         | 11          | 9      |
    | 8          | 8           | 1      |
    | 999        | 999         | 1      |

  @dividingIntegers
  Scenario Outline: Dividing 2 negative integers with no remainder
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -4         | -2          | 2      |
    | -9         | -3          | 3      |
    | -10        | -5          | 2      |
    | -100       | -20         | 5      |
    | -99        | -11         | 9      |
    | -8         | -8          | 1      |
    | -999       | -999        | 1      |

  @dividingIntegers
  Scenario Outline: Dividing 1 positive and 1 negative integer with no remainder
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -4         | 2           | -2     |
    | 9          | -3          | -3     |
    | -10        | 5           | -2     |
    | 100        | -20         | -5     |
    | -99        | 11          | -9     |
    | 8          | -8          | - 1    |
    | -999       | 999         | -1     |

  @dividingIntegers
  Scenario Outline: Dividing a dividend lesser than a divisor
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 6          | 5           | 1.2    |


  @dividingIntegers
  Scenario Outline: Dividing 0 by an integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 0          | 1           | 0      |
    | 0          | -2          | 0      |

  @dividingIntegers
  Scenario Outline: Dividing an integer by 0
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result    |
    | 1          | 0           | undefined |   

  @dividingIntegers
  Scenario Outline: Dividing 2 large integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 440664384  | 35664       | 12356  |  

  @dividingDecimals
  Scenario Outline: Dividing 2 positive decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | 1.5        | 0.5         | 3      |  

  @dividingDecimals
  Scenario Outline: Dividing 2 negative decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -1.5       | -0.5        | 3      |  

  @dividingDecimals
  Scenario Outline: Dividing 1 positive and 1 negative decimal
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are divided
  Then I should have the following <result>

  Examples:
    | leftNumber | rightNumber | result |
    | -1.5       | 0.5         | -3     | 