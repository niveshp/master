﻿Feature: Calculate
	In order to perform basic calculations
	As a Warewolf user
	I want a tool that I can input a formula and will calculate and retun a result

Scenario: Calculate using a given formula
	Given I have the formula "mod(sqrt(49), 7)"	
	When the calculate tool is executed
	Then the calculate result should be "0"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =             |
	| mod(sqrt(49), 7) |	
	And the debug output as 
	|                 |
	| [[result]] = 0 |

Scenario: Calculate using multiple scalars and recordset inputs
	Given I have a calculate variable "[[var]]" equal to "1"
	And I have a calculate variable "[[var2]]" equal to "20"
	And I have the formula "((([[var]]+[[var]])/[[var2]])+[[var2]]*[[var]])"
	When the calculate tool is executed
	Then the calculate result should be "20.1"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =                                                                 |
	| ((([[var]]+[[var]])/[[var2]])+[[var2]]*[[var]]) = (((1+1)/20)+20*1) |	
	And the debug output as 
	|                   |
	| [[result]] = 20.1 |

Scenario: Calculate with new lines should concatenate values
	Given I have a calculate variable "[[var]]" equal to "1"
	And I have a calculate variable "[[var2]]" equal to "20"
	And I have the formula "[[var]]\r\n[[var2]]"
	When the calculate tool is executed
	Then the calculate result should be "120"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =            |
	| String = String |	
	And the debug output as 
	|                  |
	| [[result]] = 120 |

Scenario: Calculate using Recordset (*) input in an agregate function like SUM
	Given I have a calculate variable "[[var(*).int]]" equal to 
	| var().int	|
	| 1			|
	| 2			|
	| 3			|
	And I have the formula "SUM([[var(*).int]])"
	When the calculate tool is executed
	Then the calculate result should be "6"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =                             |
	| SUM([[var(*).int]]) = SUM(1,2,3) |	
	And the debug output as 
	|                 |
	| [[result]] = 6 |

Scenario: Calculate using incorrect formula
	Given I have the formula "asdf"
	When the calculate tool is executed
	Then the calculate result should be ""
	And the execution has "AN" error
	And the debug inputs as  
	| fx = |
	| asdf |	
	And the debug output as 
	|               |
	| [[result]] = |

Scenario: Calculate using variable as full calculation
	Given I have a calculate variable "[[var]]" equal to "SUM(1,2,3)-5"
	And I have the formula "[[var]]"
	When the calculate tool is executed
	Then the calculate result should be "1"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =                    |
	| [[var]] =  SUM(1,2,3)-5 |	
	And the debug output as 
	|                 |
	| [[result]] = 1 |

Scenario: Calculate using a negative index recordset value
	Given I have the formula "[[my(-1).formula]]"
	When the calculate tool is executed
	Then the execution has "AN" error
	And the debug inputs as  
	| fx =                                    |
	| [[my(-1).formula]] = [[my(-1).formula]] |	
	And the debug output as 
	|               |
	| [[result]] = |

Scenario: Calculate using isnumber and blank
    Given I have the formula "if(isnumber(""),"Is number","Not number")"
	When the calculate tool is executed
	Then the calculate result should be "Not number"
	And the debug inputs as  
	| fx =                                    |
	| "if(isnumber(""),"Is number","Not number")" |	
	And the execution has "NO" error

#This scenario should pass after the bug 11871 is fixed
Scenario: Calculate Assign by evaluating a variable inside a variable
	Given I have a calculate variable "[[a]]" equal to "b"
	And I have a calculate variable "[[b]]" equal to "20"
	And I have the formula "[[[[a]]]]+1"
	When the calculate tool is executed
	Then the calculate result should be "21"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =               |
	| [[[[a]]]]+1 = 20+1 |	
	And the debug output as 
	|                 |
	| [[result]] = 21 |

Scenario: Calculate Assign by evaluating a variable inside a variable with function
	Given I have a calculate variable "[[a]]" equal to "b"
	And I have a calculate variable "[[b]]" equal to "20"
	And I have the formula "SUM([[[[a]]]],[[b]])"
	When the calculate tool is executed
	Then the calculate result should be "40"
	And the execution has "NO" error
	And the debug inputs as  
	| fx =                              |
	| SUM([[[[a]]]],[[b]]) = SUM(20,20) |
	And the debug output as 
	|                 |
	| [[result]] = 40 |



















