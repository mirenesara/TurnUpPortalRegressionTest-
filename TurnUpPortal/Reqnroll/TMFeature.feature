Feature: TMFeature

As a TurnUp Portal Admin user
I would like to create, edit and delet time and material records
So that I can manage employees time and materials successfully

@regression
Scenario: create time record with valid data
	Given I logged into TurnUp Portal successfully
	When I navigate to Time and Material Page
	When I create a time record
	Then the record should be created successfully
