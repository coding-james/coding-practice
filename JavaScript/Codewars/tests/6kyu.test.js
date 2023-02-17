const { assert, expect } = require("chai");
const solution = require("../6 kyu/multi_of_3_or_5");
const alphabetPosition = require("../6 kyu/replace_with_alphabet_position");
const RomanNumerals = require("../6 kyu/roman_no_enconder");
const isPangram = require("../6 kyu/detect_pangram");
const uniqueInOrder = require("../6 kyu/unique_in_order");

// CODEWARS: Detect Pangram
describe("Detect Pangram", () => {
    const tests = [
        { arg: "The quick brown fox jumps over the lazy dog.", expected: true },
        { arg: "This is not a pangram.", expected: false },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            expect(isPangram(arg)).to.equal(expected);
        });
    });
});

// CODEWARS: Multiples of 3 or 5
describe("Multiples of 3 or 5", () => {
    const tests = [
        { arg: 10, expected: 23 },
        { arg: 3, expected: 0 },
        { arg: 0, expected: 0 },
        { arg: -3, expected: 0 },
        { arg: 9, expected: 14 },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.strictEqual(solution(arg), expected);
        });
    });
});

// CODEWARS: Replace with alphabet position
describe("Replace with alphabet position", () => {
    const tests = [
        { arg: "The sunset sets at twelve o' clock.", expected: "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" },
        { arg: "The narwhal bacons at midnight.", expected: "20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            expect(alphabetPosition(arg)).to.equal(expected);
        });
    });
});

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

// CODEWARS: Unique in order
describe("Unique in order", () => {
    const tests = [
        { arg: 'AAAABBBCCDAABBB', expected: ['A', 'B', 'C', 'D', 'A', 'B'] },
        { arg: 'ABBCcAD', expected: ['A', 'B', 'C', 'c', 'A', 'D'] },
        { arg: [1,2,2,3,3], expected: [1,2,3] },
        { arg: [], expected: [] },
        { arg: [""], expected: [''] },
        { arg: [''], expected: [''] },
        { arg: ['A'], expected: ['A'] },
        { arg: ['a'], expected: ['a'] },
        { arg: [' '], expected: [''] },
        { arg: "A", expected: ['A'] },
        { arg: [ '' ], expected: [''] },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(uniqueInOrder(arg), expected);
        });
    });
});