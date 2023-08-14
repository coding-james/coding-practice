"use strict";
const { assert } = require("chai");
const { found, findWally, findOptions, wildcardFind, similarWords, matchSpecified, matchExclude } = require("../../../freeCodeCamp/JavaScriptAlgorithmsAndDataStructures/regular-expressions");
const { multiCharacters, charZeroOrMore, alphanumeric, nonAlphanumeric, usernameCheck, changeOrder, trimPhrase } = require("../../../freeCodeCamp/JavaScriptAlgorithmsAndDataStructures/regular-expressions");

describe("Hello Included", () => {
    it("Should return True", () => {
        assert.isTrue(found("Hello, World!"));
    });

    it("Should return False", () => {
        assert.isFalse(found("Greetings, World!"));
    });
});


describe("Find Waldo", () => {
    it("Should return True", () => {
        assert.isTrue(findWally("Somewhere Waldo is hiding in this text."));
    });

    it("Should return False", () => {
        assert.isFalse(findWally("Somewhere Odlaw is hiding in this text."));
    });
});


describe("Find the pets", () => {
    const tests = [
        { arg: "James has a pet cat.", animal: "cat" },
        { arg: "Alex has a pet dog", animal: "dog" },
        { arg: "Ralph has a bird", animal: "bird" },
        { arg: "Ellie's pet is a fish", animal: "fish" }
    ];

    tests.forEach(({ arg, animal }) => {
        it(`${animal} should return True`, () => {
            assert.isTrue(findOptions(arg));
        });
    });

    const testsFalse = [
        { arg: "James has a pet elephant.", animal: "elephant" },
        { arg: "Alex has a pet whale", animal: "whale" },
        { arg: "Ralph has a lion", animal: "lion" },
        { arg: "Ellie's pet is a banana", animal: "banana" }
    ];

    testsFalse.forEach(({ arg, animal }) => {
        it(`${animal} should return False`, () => {
            assert.isFalse(findOptions(arg));
        });
    });
});


describe("Find the _un words", () => {
    const tests = [
        { arg: "Let's have fun with regular expressions!", expected: "fun" },
        { arg: "let the Sun shine", expected: "Sun" },
        { arg: "Is it Sunny", expected: "Sunny" },
        { arg: "do you want to go for a run", expected: "run" },
        { arg: "What a tasty Bun", expected: "Bun" }
    ];

    tests.forEach(({ arg, expected }) => {
        it(`${expected} should return True`, () => {
            assert.isTrue(wildcardFind(arg));
        });
    });

    const testsFalse = [
        { arg: "Can I borrow the Fan", expected: "Fan" },
        { arg: "Hi Stan", expected: "Stan" },
        { arg: "She ran the whole way", expected: "ran" },
        { arg: "Hello Ben", expected: "Ben" }
    ];

    testsFalse.forEach(({ arg, expected }) => {
        it(`${expected} should return False`, () => {
            assert.isFalse(wildcardFind(arg));
        });
    });
});


describe("Find the b_g words (bag, big, bug", () => {
    const tests = [
        { arg: "What's in the bag?", expected: "bag" },
        { arg: "That's the biggest mountain", expected: "big" },
        { arg: "What a rare bug", expected: "bug" },
        { arg: "The ogre lives in the bog", expected: null },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(similarWords(arg), expected);
        });
    });
});


describe("Match specified Numbers and Letters of the Alphabet", () => {
    it("Should return 17", () => {
        assert.equal(matchSpecified("Blueberry 3.141592653s are delicious.").length, 17);
    });
});


describe("Exclude from match", () => {
    let expected = [' ', 'b', 'l', 'n', 'd', ' ', 'm', 'c', '.'];
    it(`Should return ${expected}`, () => {
        assert.deepEqual(matchExclude("3 blind mice."), expected);
    });

    it("Should return 9 items", () => {
        assert.equal(matchExclude("3 blind mice.").length, 9);
    });
});


describe("Find multiple instances of a character", () => {
    it("Should return ssss", () => {
        assert.deepEqual(multiCharacters("Mississippi"), ["ss", "ss"]);
    });
});


describe("Match Characters that Occur Zero or More Times", () => {
    it("Should return Aaaaaaaaaaaaaaaa", () => {
        assert.deepEqual(charZeroOrMore("Aaaaaaaaaaaaaaaarrrgh!"), ["Aaaaaaaaaaaaaaaa"]);
    });
});


describe("Alphanumeric Characters", () => {
    const tests = [
        { arg: "The five boxing wizards jump quickly.", expected: 31 },
        { arg: "Pack my box with five dozen liquor jugs.", expected: 32 },
        { arg: "How vexingly quick daft zebras jump!", expected: 30 },
        { arg: "123 456 7890 ABC def GHI jkl MNO pqr STU vwx YZ.", expected: 36 },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(alphanumeric(arg), expected);
        });
    });
});


describe("Non alphanumeric Characters", () => {
    const tests = [
        { arg: "The five boxing wizards jump quickly.", expected: 6 },
        { arg: "Pack my box with five dozen liquor jugs.", expected: 8 },
        { arg: "How vexingly quick daft zebras jump!", expected: 6 },
        { arg: "123 456 7890 ABC def GHI jkl MNO pqr STU vwx YZ.", expected: 12 },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(nonAlphanumeric(arg), expected);
        });
    });
});


describe("Username Check", () => {
    const tests = [
        { arg: "JackOfAllTrades", expected: true },
        { arg: "Aa", expected: true },
        { arg: "Aa007", expected: true },
        { arg: "A", expected: false },
        { arg: "A0", expected: false },
        { arg: "007", expected: false },
        { arg: "Aa!007", expected: false },
        { arg: "Aa_007", expected: false },
        { arg: "Aa 007", expected: false },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`${arg} should return ${expected}`, () => {
            assert.equal(usernameCheck(arg), expected);
        });
    });
});


describe("Change Order", () => {
    const tests = [
        { arg: "one two three", expected: "three two one" },
        { arg: "reverse this order", expected: "order this reverse" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(changeOrder(arg), expected);
        });
    });
});


describe("Trim the phrase", () => {
    it("Should return Hello, World!", () => {
        assert.deepEqual(trimPhrase("   Hello, World!  "), "Hello, World!");
    });
});