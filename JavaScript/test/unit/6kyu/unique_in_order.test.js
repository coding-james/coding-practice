const { assert } = require("chai");
const uniqueInOrder = require("../../../Codewars/6 kyu/unique_in_order");

// CODEWARS: Unique in order
describe("Unique in order", () => {
    const tests = [
        { arg: 'AAAABBBCCDAABBB', expected: ['A', 'B', 'C', 'D', 'A', 'B'] },
        { arg: 'ABBCcAD', expected: ['A', 'B', 'C', 'c', 'A', 'D'] },
        { arg: [1, 2, 2, 3, 3], expected: [1, 2, 3] },
        { arg: [], expected: [] },
        { arg: [""], expected: [''] },
        { arg: [''], expected: [''] },
        { arg: ['A'], expected: ['A'] },
        { arg: ['a'], expected: ['a'] },
        { arg: [' '], expected: [''] },
        { arg: "A", expected: ['A'] },
        { arg: [''], expected: [''] },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(uniqueInOrder(arg), expected);
        });
    });
});