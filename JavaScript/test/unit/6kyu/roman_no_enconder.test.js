const { expect } = require("chai");
const RomanNumerals = require("../../../Codewars/6 kyu/roman_no_enconder");

// CODEWARS: Roman Numerals Encoder
describe("Roman Numerals Encoder", () => {
    const tests = [
        { arg: 1, expected: "I" },
        { arg: 2, expected: "II" },
        { arg: 3, expected: "III" },
        { arg: 4, expected: "IV" },
        { arg: 5, expected: "V" },
        { arg: 9, expected: "IX" },
        { arg: 10, expected: "X" },
        { arg: 11, expected: "XI" },
        { arg: 19, expected: "XIX" },
        { arg: 22, expected: "XXII" },
        { arg: 15, expected: "XV" },
        { arg: 1000, expected: "M" },
        { arg: 1001, expected: "MI" },
        { arg: 1990, expected: "MCMXC" },
        { arg: 2007, expected: "MMVII" },
        { arg: 2008, expected: "MMVIII" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            expect(RomanNumerals(arg)).to.equal(expected);
        });
    });
});