const { assert } = require("chai");
const toJadenCase = require("../../../Codewars/7 kyu/jaden_casing_strings");

// CODEWARS: Jaden Casing Strings
describe("Jaden Casing Strings", () => {
    const tests = [
        {arg: "How can mirrors be real if our eyes aren't real", expected: "How Can Mirrors Be Real If Our Eyes Aren't Real"},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(arg.toJadenCase(), expected);
        });
    });
});