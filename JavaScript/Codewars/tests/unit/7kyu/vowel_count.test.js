const { expect } = require("chai");
const getCount = require("../../../7 kyu/vowel_count");

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