Feature: PlanAJourneyWidget
	

@mytag
Scenario Outline: Verify Plan a journey widget
	Given the "tfl homepage" is loaded 
	And the "plan a journey" tab clicked
	When the user inputs "<From>" and "<To>"
	And the "plan my journey" button clicked
	Then the journey details should be displayed

	Examples:
	| From        | To       |
	|  Watford    | Euston   |

Scenario Outline: Verify Plan a journey widget with Invalid inputs
	Given the "tfl homepage" is loaded
	And  the "plan a journey" tab clicked
	When the user inputs "<From>" and "<To>"
	And the "plan my journey" button clicked
	Then the user should get the message for invalid inputs in journey result

	Examples:
	| From  | To    |
	| xxxxx | yyyyy |

Scenario Outline: Verify Plan a journey widget without location inputs
	Given the "tfl homepage" is loaded
	And the "plan a journey" tab clicked
	When the user clicks on the "plan my journey" button
	Then the user should get the validation message
	
Scenario Outline: Verify the edit journey option in journey result page
	Given the "tfl homepage" is loaded with existing journey 
	When the user clicks on "edit journey" link 
	Then the user should be able to update "<From>" and "<To>"
	
	Examples:
	| From        | To       |
	|  Wembley    | Euston   |

Scenario Outline: Verify the recent journey list
	Given the "tfl homepage" is loaded with recent history list
	When the user clicked on "Recents" tab
	Then the user should be able to view the recent journey details
	