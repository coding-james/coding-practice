const {expect} = require("chai");
const domainName = require("../5 kyu/domain_name");
const persistence = require("../5 kyu/persistent_bugger");
const maxSequence = require("../5 kyu/maximum_sum_subarray");

// CODEWARS: Extract the domain name from a URL
describe("Extract the domain name from a URL Tests", () => {
    const tests = [
        {arg: "http://google.com", expected: "google"},
        {arg: "http://google.co.jp", expected: "google"},
        {arg: "https://youtube.com", expected: "youtube"},
        {arg: "https://github.com/marketplace", expected: "github"},
        {arg: "https://www.techradar.com/news/mobile-computing/laptops/best-laptops-1304361", expected: "techradar"},
        {arg: "https://www.cnet.com", expected: "cnet"},
        {arg: "bbc.co.uk", expected: "bbc"},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            expect(domainName(arg)).to.equal(expected);
        });
    });
});

// CODEWARS: Persistent Bugger
describe("Persistent Bugger", () => {
    const tests = [
        {arg: 39, expected: 3},
        {arg: 4, expected: 0},
        {arg: 25, expected: 2},
        {arg: 999, expected: 4},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            expect(persistence(arg)).to.equal(expected);
        });
    });
});

// CODEWARS: Maximum subarray sum
describe("Maximum subarray sum", () => {
    const tests = [
        {arg: [-2, 1, -3, 4, -1, 2, 1, -5, 4], expected: 6},
        {arg: [-2, -3, -1, -5], expected: 0},
        {arg: [], expected: 0},
        {arg: [-1, 4, 3, 2, 1, -1], expected: 10},
        {arg: [-1, 4, 3, 2, 1, -12, 12], expected: 12},
        {arg: [-1, 4, 3, 2, 1, -1, 12], expected: 21},
    ];

    tests.forEach(({arg, expected}) => {
        it(`should return ${expected}`, () => {
            expect(maxSequence(arg)).to.equal(expected);
        });
    });
});