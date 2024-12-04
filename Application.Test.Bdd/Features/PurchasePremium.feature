Feature: Purchase Premium Duo
  Verify that a user can purchase Premium Duo

  @Smoke
  @Priority-P1
  Scenario: User logs in and purchases Premium Duo
    Given I open the home page
    And I click the Login button
    Then I should be on the login page
    And I should see the login options
    When I log in with valid credentials
    Then I should be successfully logged in

    When I navigate to the Premium page
    Then I should see the Premium plans
    When I click the Get Premium Duo button
    Then I should be redirected to the checkout page
    When I enter valid payment details
    Then I should not see any error messages