Feature: Example BDD test

# Scenario: When more than three words are listed, only the top three are returned
#   Given A user has a list of words "a a a  b  c c  d d d d  e e e e e"
#   When this list is submitted
#   Then only 3 word(s) returned

# Scenario: When less than three words are listed, only that number are returned
#   Given A user has a list of words "  , e   .. "
#   When this list is submitted
#   Then only 1 word(s) returned

  Scenario Outline: when a list of words is submitted, only the top three (or less) are returned
    Given A user has a list of words "<list>"
    When this list is submitted
    Then only <number> word(s) returned

    Examples: 
      | list                              | number |
      | a a a  b  c c  d d d d  e e e e e |      3 |
      | , e   ..                          |      1 |

  Scenario: When the user submits a empty list, no top list is returned
    Given A user has a empty list " "
    When this empty list is submitted
    Then no words are returned