# Cucumber / Gherkin - JavaScript

## Overview
Cucumber is a tool that supports Behaviour-Driven Development(BDD). Cucumber reads and runs plain text tests written in the Gherkin syntax.

### Setup
- Prerequisites
- Install
- Debug
- Config

### Key Files
- Feature Files
- Step Definitions

### Gherkin Keywords
- Feature
- Rule
- Example (or Scenario)
- Given, When, Then, And, But
- Background
- Scenario Outline (or Scenario Template)
- Examples (or Scenarios)

### Secondary Keywords
- `""` (Doc Strings)
- `|` (Data Tables)
- `@` (Tags)
- `#` (Comments)

## Setup

### Prerequisites

Install Node.js   

Initialise project   
`npm init -y`

Install Cucumber   
`npm install --save-dev @cucumber/cucumber`

### Debug
Update `launch.json`
````
{
    "name": "<insert Name>",
    "type": "node",
    "request": "launch",
    "console": "integratedTerminal",
    "program": "${workspaceRoot}/<insert path>/node_modules/@cucumber/cucumber/bin/cucumber-js",
    "args": [
        "${workspaceRoot}/<insert path>/features/*.feature",
        "-r",
        "${workspaceRoot}/<insert path>/features/step_definitions/*.js",
        "--tags",
        "@debug"
    ]
},
````

### Config
Update Workspace settings for VS Code Cucumber Extension to include relevant `.feature` file locations.

Update `cucumber.glue` within `settings.json` to include any directory for step definitions (if outside of normal file structure).

## Key Files

### Feature File

Gherkin documents are stored in `.feature` text files and are typically versioned in source control alongside the software. These feature files are written in plain text in a style which should be understood by business stakeholders.

Example:
```` 
Feature: Calculator

  Scenario: Add two numbers
    Given I enter the numbers 2 and 5
    When I select the "add" operator
    Then the result should be 7
````

### Step Definitions

Step definitions connect Gherkin steps to the actual programming code. These are stored in the relevant language filetype e.g. `*.js`

Example:
````
const { Given, When, Then } = require('@cucumber/cucumber')
const assert = require('assert')
const calc = require('../calc')

Given('I enter the numbers {int} and {int}', function (int, int2) {
    this.number1 = int;
    this.number2 = int2;
    assert.deepEqual(int,2);
    assert.deepEqual(int2,5);
});

When('I select the {string} operator', function (string) {
    this.operator = string;
    assert.deepEqual(string, "add");
});

Then('the result should be {int}', function (expected) {
    assert.deepEqual(calc(this.number1, this.number2, this.operator), expected);
});
````
## Gherkin Keywords

<!-- https://cucumber.io/docs/gherkin/reference/ -->

### Feature
High level description of the feature or group of scenarios

### Rule
Represents one business rule    
Introduced in v6

### Example (or Scenario)
Subdivision of a Feature, contains a sequence of steps
Written like Friends (TV Show) titles, e.g. The One With Ross' New Girlfriend

### Given, When, Then, And, But
- Given: Describes the initial state before the start of a test. Pre-Condition
- When: Describes the user actions during the test
- Then: Describes the results from When actions. Outcome / Validation after action.

Occasionally, you might want to write a combination of Given-When-Then. You can use the following conjunctions keywords:
- And: Logical AND
- But: Negative form of AND

### Background
### Scenario Outline (or Scenario Template)
### Examples (or Scenarios)

## Secondary Keywords
- `""` (Doc Strings)
- `|` (Data Tables)
- `@` (Tags)
- `#` (Comments)