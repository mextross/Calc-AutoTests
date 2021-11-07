Feature: Subtraction

  @subtractingIntegers
  Scenario Outline: Subtracting 2 positive integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | 1          | 2           | -1     |
    | 3          | 4           | -1     |
    | 6          | 5           | 1      |
    | 8          | 7           | 1      |
    | 1          | 9           | -8     |
    | 34         | 58          | -24    |
    | 99         | 1           | 98     |
    | 1          | 999         | -998   |

  @subtractingIntegers
  Scenario Outline: Subtracting 2 negative integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | -99        | -99         | 0      |
    | -0         | -0          | 0      |
    | -1         | -2          | 1      |
    | -3         | -4          | 1      |
    | -5         | -6          | 1      |
    | -8         | -7          | -1     |
    | -9         | -1          | -8     |
    | -34        | -58         | 24     |
    | -99        | -1          | -98    |
    | -1         | -99         | 98     |

  @subtractingIntegers
  Scenario Outline: Subtracting 1 positive and 1 negative integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | 1          | -2          | 3      |
    | -3         | 4           | -7     |
    | 5          | -6          | 11     |
    | -7         | 8           | -15    |
    | 9          | -1          | 10     |
    | -34        | 58          | -92    |
    | 99         | -1          | 100    |
    | -1         | 999         | -1000  |
    | -99        | 99          | -198   |
   
  @subtractingIntegers
  Scenario Outline: Subtracting 0 and an integer
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | -1         | 0           | -1     |
    | 0          | 2           | -2     |
    | 3          | 0           | 3      |
    | 0          | -4          | 4      |
    | 5          | 0           | 5      |
    | 0          | 6           | -6     |
    | 7          | 0           | 7      |
    | 0          | 8           | -8     |
    | 9          | 0           | 9      |
    | 0          | 100         | -100   |
    | -999       | 0           | -999   |
    | 0          | -0          | 0      |

  @subtractingIntegers
  Scenario Outline: Subtracting 2 large integers
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result     |
    | -8643684   | -789648353  | 781004669  |
    | 8643684    | -789648353  | 798292037  |
    | 165466894  | 330635640   | -165168746 |

  @subtractingDecimals
  Scenario Outline: Subtracting 2 positive decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | 4.6        | 8.2         | -3.6   |

  @subtractingDecimals
  Scenario Outline: Subtracting 2 negative decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | -1.2       | -8.5        | 7.3    |

  @subtractingDecimals
  Scenario Outline: Subtracting 1 positive and 1 negative decimal
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result |
    | 8.1       | -4.6        | 12.7    |

    
  @subtractingdecimals
  Scenario Outline: Subtracting 2 small decimals
  Given I have a first number <leftNumber> 
  And I have a second number <rightNumber> 
  When both numbers are subtracted
  Then I should have the following <result>

 Examples:
    | leftNumber | rightNumber | result  |
    | 0.0008     | 0.002       | -0.0012 |