const { assert } = require("chai");
const towerBuilder = require("../../../Codewars/6 kyu/build_tower");

// CODEWARS: Build Tower
describe("Build Tower", () => {
    const tests = [
        { input: 1, expected: ["*"] },
        { input: 2, expected: [" * ", "***"] },
        { input: 3, expected: ["  *  ", " *** ", "*****"] }
    ];

    tests.forEach(({ input, expected }) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(towerBuilder(input), expected);
        });
    });
});