"use strict";
// Test method, returns True or False
function found(myString) {
    let myRegex = /Hello/;
    return myRegex.test(myString);
};

// Match Literal String (Exact word)
function findWally(waldoIsHiding) {
    let waldoRegex = /Waldo/;
    return waldoRegex.test(waldoIsHiding);
}

// Match a Literal String with different possibilities
function findOptions(petString) {
    let petRegex = /dog|cat|bird|fish/;
    return petRegex.test(petString);
}

// Find matches using wildcard run, sun, fun, etc..
function wildcardFind(exampleStr) {
    let unRegex = /.un/;
    return unRegex.test(exampleStr);
}

// Match Single Character with Multiple Possibilities e.g. bag, beg, big, etc...
function similarWords(exampleStr) {
    let unRegex = /b[aiu]g/;
    return exampleStr.match(unRegex);;
}

// Match specified Numbers and Letters of the Alphabet. i = ignore case, g = global so will find every match not just the first.
function matchSpecified(quoteSample) {
    let myRegex = /[h-s2-6]/ig;
    return quoteSample.match(myRegex);
};


// Use the caret character (^) in order to exclude characters you don't want to match
function matchExclude(quoteSample) {
    let myRegex = /[^aeiou0-9]/gi;
    return quoteSample.match(myRegex);
};

// Return characters which appear multiple times
function multiCharacters(difficultSpelling) {
    let myRegex = /s+/g;
    return difficultSpelling.match(myRegex);
}

// Match Characters that Occur Zero or More Times
function charZeroOrMore(chewieQuote) {
    let chewieRegex = /Aa*/;
    return chewieQuote.match(chewieRegex);
}

// Alphanumeric Characters \w is shortcut for [A-Za-z0-9_] _ = underscore
function alphanumeric(quoteSample) {
    let alphabetRegexV2 = /\w/g; // Change this line
    return quoteSample.match(alphabetRegexV2).length;
}

// Non Alphanumeric Characters \W is shortcut for [^A-Za-z0-9_]
function nonAlphanumeric(quoteSample) {
    let alphabetRegexV2 = /\W/g; // Change this line
    return quoteSample.match(alphabetRegexV2).length;
}

// Username check - Alpha-numeric characters only. Numbers optional but can only appear at the end. Any case. At least two alphabet letters.
function usernameCheck(username) {
    let userCheck = /^[a-z][a-z]+\d*$|^[a-z]\d\d+$/i;
    return userCheck.test(username);
}

// Reverse the order
function changeOrder(str) {
    let fixRegex = /(\w+)\s(\w+)\s(\w+)/;
    let replaceText = "$3 $2 $1";
    return str.replace(fixRegex, replaceText);
}

// Trim without using String.prototype.trim()
function trimPhrase(hello) {
    let wsRegex = /^\s+|\s+$/g;
    return hello.replace(wsRegex, "");
}

module.exports = { found, findWally, findOptions, wildcardFind, similarWords, matchSpecified, matchExclude, multiCharacters, charZeroOrMore, alphanumeric, nonAlphanumeric, usernameCheck, changeOrder, trimPhrase };