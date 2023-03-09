const { assert } = require("chai");
const topThreeWords = require("../4 kyu/top3words");
const snail = require("../4 kyu/snail");

// CODEWARS: Most frequently used words in a text
describe("Most frequently used words in a text", () => {
    const tests = [
        { arg: "a a a  b  c c  d d d d  e e e e e", expected: ['e', 'd', 'a'] },
        { arg: "a a c b b", expected: ['a', 'b', 'c'] },
        { arg: "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e", expected: ['e', 'ddd', 'aa'] },
        { arg: "  //wont won't won't ", expected: ["won't", "wont"] },
        { arg: "  , e   .. ", expected: ["e"] },
        { arg: "  ...  ", expected: [] },
        { arg: "  '  ", expected: [] },
        {
            arg: `In a village of La Mancha, the name of which I have no desire to call to mind, there lived not long since one of those gentlemen that keep a lance in the lance-rack, an old buckler, a lean hack, and a greyhound for coursing. An olla of rather more beef than mutton, a salad on most
        nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra on Sundays, made away with three-quarters of his income.`, expected: ['a', 'of', 'on']
        },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(topThreeWords(arg), expected);
        });
    });
});

// CODEWARS: Snail Sort
describe("Snail Sort", () => {
    const tests = [
        { arg: [[]], expected: [] },
        { arg: [[1]], expected: [1] },
        { arg: [[1, 2, 3], [4, 5, 6], [7, 8, 9]], expected: [1, 2, 3, 6, 9, 8, 7, 4, 5] },
        { arg: [[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15], [16, 17, 18, 19, 20], [21, 22, 23, 24, 25]], expected: [1, 2, 3, 4, 5, 10, 15, 20, 25, 24, 23, 22, 21, 16, 11, 6, 7, 8, 9, 14, 19, 18, 17, 12, 13] },
        { arg: [[1, 2, 3, 4, 5, 6], [20, 21, 22, 23, 24, 7], [19, 32, 33, 34, 25, 8], [18, 31, 36, 35, 26, 9], [17, 30, 29, 28, 27, 10], [16, 15, 14, 13, 12, 11]], expected: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36] },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.deepEqual(snail(arg), expected);
        });
    });
});