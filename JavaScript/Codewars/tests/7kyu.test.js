const {expect, assert} = require("chai");
const domainName = require("../7 kyu/disemvowel_trolls");
const highAndLow = require("../7 kyu/highest_and_lowest");
const filter_list = require("../7 kyu/list_filtering");
const getCount = require("../7 kyu/vowel_count");

// CODEWARS: Disemvowel Trolls
describe("Disemvowel Trolls Tests", () => {
    const tests = [
        {arg: "This website is for losers LOL!", expected: "Ths wbst s fr lsrs LL!"},
        {arg: "No offense but,\nYour writing is among the worst I've ever read", expected: "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"},
        {arg: "What are you, a communist?", expected: "Wht r y,  cmmnst?"},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            expect(domainName(arg)).to.equal(expected);
        });
    });
});

// CODEWARS: Highest and Lowest
describe("Highest and Lowest Tests", () => {
    const tests = [
        {arg: "1 2 3 4 5", expected: "5 1"},
        {arg: "1 2 -3 4 5", expected: "5 -3"},
        {arg: "1 9 3 4 -5", expected: "9 -5"},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            expect(highAndLow(arg)).to.equal(expected);
        });
    });
});

// CODEWARS: Jaden Casing Strings
// TODO: Figure out how to export and import

// CODEWARS: List Filtering
describe("List Filtering Tests", () => {
    const tests = [
        {arg: [1,2,'a','b'], expected: [1,2]},
        {arg: [1,'a','b',0,15], expected: [1,0,15]},
        {arg: [1,2,'aasf','1','123',123], expected: [1,2,123]},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(filter_list(arg), expected);
        });
    });
});

// CODEWARS: Vowel Count
describe("Vowel Count Tests", () => {
    const tests = [
        {arg: "abracadabra", expected: 5},
        {arg: "bbb", expected: 0},
        {arg: "AaA", expected: 3},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            expect(getCount(arg)).to.equal(expected);
        });
    });
});