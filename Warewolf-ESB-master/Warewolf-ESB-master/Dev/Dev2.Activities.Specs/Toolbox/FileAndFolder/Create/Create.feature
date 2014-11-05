﻿@fileFeature
Feature: Create
	In order to be able to create files
	as a Warewolf user
	I want a tool that creates a file at a given location


Scenario Outline: Create file at location
	Given I have a destination path '<destination>' with value '<destinationLocation>'
	And overwrite is '<selected>'
	And destination credentials as '<username>' and '<password>'
	And result as '<resultVar>'
	When the create file tool is executed
	Then the result variable '<resultVar>' will be '<result>'
	And the execution has "<errorOccured>" error
	And the debug inputs as
         | File or Folder                        | Overwrite  | Username   | Password |
         | <destination> = <destinationLocation> | <selected> | <username> | String   |
	And the debug output as
		|                        |
		| <resultVar> = <result> |
	Examples: 
		| No | Name       | destination | destinationLocation                                            | selected | username                     | password               | resultVar  | result  | errorOccured |
		| 1  | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | ""                     | [[result]] | Success | NO           |
		| 2  | UNC        | [[path]]    | \\\\RSAKLFSVRSBSPDC\FileSystemShareTestingSite\test.txt        | True     | ""                           | ""                     | [[result]] | Success | NO           |
		| 3  | UNC Secure | [[path]]    | \\\\RSAKLFSVRSBSPDC\FileSystemShareTestingSite\Secure\test.txt | True     | dev2.local\IntegrationTester | I73573r0               | [[result]] | Success | NO           |
		| 4  | FTP        | [[path]]    | ftp://rsaklfsvrsbspdc:1001/FORTESTING/test.txt                 | True     | ""                           | ""                     | [[result]] | Success | NO           |
		| 5  | FTPS       | [[path]]    | ftp://rsaklfsvrsbspdc:1002/FORTESTING/test.txt                 | True     | IntegrationTester            | I73573r0               | [[result]] | Success | NO           |
		| 6  | SFTP       | [[path]]    | sftp://localhost/test.txt                                      | True     | dev2                         | Q/ulw&]                | [[result]] | Success | NO           |
#Bug12180#| 7  | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[result]][[a]]        | [[result]] | Failure | NO           |
		#| 8  | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[a]]*]]               | [[result]] | Failure | NO           |
		#| 9  | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[var@]]               | [[result]] | Failure | NO           |
		#| 10 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[var]]00]]            | [[result]] | Failure | NO           |
		#| 11 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[(1var)]]             | [[result]] | Failure | NO           |
		#| 12 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[var[[a]]]]           | [[result]] | Failure | NO           |
		#| 13 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[var.a]]              | [[result]] | Failure | NO           |
		#| 14 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[@var]]               | [[result]] | Failure | NO           |
		#| 15 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[var 1]]              | [[result]] | Failure | NO           |
		#| 16 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[rec(1).[[rec().1]]]] | [[result]] | Failure | NO           |
		#| 17 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[rec(@).a]]           | [[result]] | Failure | NO           |
		#| 18 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[rec"()".a]]          | [[result]] | Failure | NO           |
		#| 19 | Local      | [[path]]    | c:\myfile.txt                                                  | True     | ""                           | [[rec([[[[b]]]]).a]]   | [[result]] | Failure | NO           |
































