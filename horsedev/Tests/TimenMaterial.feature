Feature: TimenMaterial
	Create , edit, delete then validate the time n material object

@mytag
Scenario: Add time n material object and validate
	Given I am already logged in to the Horse env
	And I clicked admin n time and material
	When I click on create new button and I entered valid data
	Then I validated that the record exists

