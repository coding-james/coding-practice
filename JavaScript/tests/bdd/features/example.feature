Feature: Example BDD test

Scenario: When more than three words are listed, only the top three are returned
  Given A user has a list of words "a a a  b  c c  d d d d  e e e e e"
  When this list is submitted
  Then only 3 word(s) returned

Scenario: When less than three words are listed, only that number are returned
  Given A user has a list of words "  , e   .. "
  When this list is submitted
  Then only 1 word(s) returned

