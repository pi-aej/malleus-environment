Feature: Running a test
  As an iOS developer
  I want to have a sample feature file
  So I can begin testing quickly

Scenario: Example steps
  Given I am on the Main Screen
  Then I swipe left
  And I wait until I don't see "Please swipe left"
  And take picture

Scenario: Button Test
  Given I am on the Main Screen
  Then I press Main_Button
  Then Main_Button Title will be “1 clicks!”