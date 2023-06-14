const { Given, When, Then, Before } = require('@cucumber/cucumber')
const assert = require('assert')
const topThreeWords = require('../../../../Codewars/4 kyu/top3words')

Given('A user has a list of words {string}', function (list) {
    this.wordList = list;
    assert.notEqual(list,"");
});

When('this list is submitted', function () {
    this.output = topThreeWords(this.wordList)
});

Then('only {int} word\\(s) returned', function (number) {
    assert.deepEqual(this.output.length, number);
});