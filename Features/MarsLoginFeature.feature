Feature: Mars Project Testing 
@smoke
Scenario: Successful Login by User
	Given User press Sign In button and  Navigate to the Login Page
	When User Login with Email 'limpdon@hotmail.com' and Password 'BASANTA'
	Then User can see logout button
	
Scenario Outline: Unsuccessful Login by User
Given User press Sign In button and  Navigate to the Login Page
When User Login with Email '<email>' and Password '<password>'
Then  User can see logout button 

Examples: 
| name             | email               | password | errorMsg                                                             |
| Blank email      |                     | BASANTA  | ERROR: The email field is empty.                                     |
| Blank Password   | limpdon@hotmail.com |          | ERROR: The password field is empty.                                  |
| invalid Password | limpdon@hotmail.com | 1234!@@  | ERROR: The password you entered for the username admin is incorrect. |
| invalid email    | abcdef@gmail.com    | BASANTA  | ERROR: Invalid email Lost your password                              |

#@regression
#Scenario: User can see logout button 
#	Given User click the Share skill button 
#	And User should be able to fill all the details
#	Then  User should be able to save all the details 
#	