const { expect } = require("chai");
const generateHashtag = require("../../../5 kyu/hashtag_generator");

// CODEWARS: The Hashtag Generator
describe("The Hashtag Generator", () => {
    const tests = [
        { arg: "", expected: false },
        { arg: " Hello there thanks for trying my Kata", expected: "#HelloThereThanksForTryingMyKata" },
        { arg: "    Hello     World   ", expected: "#HelloWorld" },
        { arg: " ".repeat(200), expected: false },
        { arg: "Do We have A Hashtag", expected: "#DoWeHaveAHashtag" },
        { arg: "Codewars", expected: "#Codewars" },
        { arg: "Codewars is nice", expected: "#CodewarsIsNice" },
        { arg: "Codewars Is Nice", expected: "#CodewarsIsNice" },
        { arg: "code" + " ".repeat(140) + "wars", expected: "#CodeWars" },
        { arg: "Looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong Cat", expected: false },
        { arg: "a".repeat(139), expected: "#A" + "a".repeat(138) },
        { arg: "a".repeat(140), expected: false },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            expect(generateHashtag(arg)).to.equal(expected);
        });
    });
});