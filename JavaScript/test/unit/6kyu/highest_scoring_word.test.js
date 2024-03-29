const { assert } = require("chai");
const high = require("../../../Codewars/6 kyu/highest_scoring_word");

// CODEWARS: Highest Scoring Word
describe("Highest Scoring Word", () => {
    it(`DATATYPE: It should return a String`, () => {
        assert.isString(high('man i need a taxi up to ubud'));
    });
    
    const tests = [
        { input: 'man i need a taxi up to ubud', expected: 'taxi' },
        { input: 'what time are we climbing up the volcano', expected: 'volcano' },
        { input: 'take me to semynak', expected: 'semynak' },
        { input: 'aa b', expected: 'aa' },
        { input: 'b aa', expected: 'b' },
        { input: 'bb d', expected: 'bb' },
        { input: 'd bb', expected: 'd' },
        { input: 'aaa b', expected: 'aaa' }
    ];

    tests.forEach(({ input, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(high(input), expected);
        });
    });
});