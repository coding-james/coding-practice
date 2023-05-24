const { expect } = require("chai");
const persistence = require("../../../5 kyu/persistent_bugger");

// CODEWARS: Persistent Bugger
describe("Persistent Bugger", () => {
    const tests = [
        { arg: 39, expected: 3 },
        { arg: 4, expected: 0 },
        { arg: 25, expected: 2 },
        { arg: 999, expected: 4 },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            expect(persistence(arg)).to.equal(expected);
        });
    });
});