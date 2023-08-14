const { assert } = require("chai");
const findMissingLetter = require("../../../Codewars/6 kyu/find_the_missing_letter");

// CODEWARS: Find the missing letter
describe("Find the missing letter", () => {
    it(`DATATYPE: It should return a String`, () => {
        assert.isString(findMissingLetter(['a', 'b', 'c', 'd', 'f']));
    });
    
    const tests = [
        { arg: ['a', 'b', 'c', 'd', 'f'], expected: 'e' },
        { arg: ['O', 'Q', 'R', 'S'], expected: 'P' },
        { arg: ['a', 'c'], expected: 'b' },
        { arg: ['A', 'C'], expected: 'B' },
        { arg: ['a', 'b', 'd', 'e', 'f'], expected: 'c' },

    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(findMissingLetter(arg), expected);
        });
    });
});