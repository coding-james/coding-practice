"use strict";
const { assert } = require("chai");
const { sumAll, diffArray, destroyer, whatIsInAName, spinalCase, translatePigLatin, myReplace, pairElement, fearNotLetter } = require("../../../freeCodeCamp/JavaScriptAlgorithmsAndDataStructures/intermediate-algorithm-scripting");
const { nonMutatingSort } = require("../../../freeCodeCamp/JavaScriptAlgorithmsAndDataStructures/functional-programming");

// Sum All Numbers in a Range
describe("Sum All Numbers in a Range", () => {

    it("DATATYPE: It should return a Number", () => {
        assert.isNumber(sumAll([1, 4]));
    });

    const tests = [
        { inputString: [1, 4], expected: 10 },
        { inputString: [4, 1], expected: 10 },
        { inputString: [5, 10], expected: 45 },
        { inputString: [10, 5], expected: 45 },
    ];

    tests.forEach(({ inputString, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.equal(sumAll(inputString), expected);
        });
    });
});

// Diff Two Arrays
describe("Compare two arrays, return unique elements", () => {

    it("DATATYPE: It should return an Array", () => {
        assert.isArray(diffArray([1, 2, 3, 5], [1, 2, 3, 4, 5]));
    });

    const tests = [
        { inputArray1: ["diorite", "andesite", "grass", "dirt", "pink wool", "dead shrub"], inputArray2: ["diorite", "andesite", "grass", "dirt", "dead shrub"], expected: ["pink wool"] },
        { inputArray1: ["andesite", "grass", "dirt", "pink wool", "dead shrub"], inputArray2: ["diorite", "andesite", "grass", "dirt", "dead shrub"], expected: ["diorite", "pink wool"] },
        { inputArray1: ["andesite", "grass", "dirt", "dead shrub"], inputArray2: ["andesite", "grass", "dirt", "dead shrub"], expected: [] },
        { inputArray1: [1, 2, 3, 5], inputArray2: [1, 2, 3, 4, 5], expected: [4] },
        { inputArray1: [1, "calf", 3, "piglet"], inputArray2: [1, "calf", 3, 4], expected: ["piglet", 4] },
        { inputArray1: [], inputArray2: ["snuffleupagus", "cookie monster", "elmo"], expected: ["snuffleupagus", "cookie monster", "elmo"] },
        { inputArray1: [1, "calf", 3, "piglet"], inputArray2: [7, "filly"], expected: [1, "calf", 3, "piglet", 7, "filly"] },
    ];

    tests.forEach(({ inputArray1, inputArray2, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.deepEqual(diffArray(inputArray1, inputArray2), nonMutatingSort(expected));
        });
    });
});

// Seek and Destroy
describe("Seek and Destroy", () => {

    it("DATATYPE: It should return an Array", () => {
        assert.isArray(destroyer([1, 2, 3, 1, 2, 3], 2, 3));
    });

    const tests = [
        { input1: destroyer([1, 2, 3, 1, 2, 3], 2, 3), expected: [1, 1] },
        { input1: destroyer([1, 2, 3, 5, 1, 2, 3], 2, 3), expected: [1, 5, 1] },
        { input1: destroyer([3, 5, 1, 2, 2], 2, 3, 5), expected: [1] },
        { input1: destroyer([2, 3, 2, 3], 2, 3), expected: [] },
        { input1: destroyer(["tree", "hamburger", 53], "tree", 53), expected: ["hamburger"] },
        { input1: destroyer(["possum", "trollo", 12, "safari", "hotdog", 92, 65, "grandma", "bugati", "trojan", "yacht"], "yacht", "possum", "trollo", "safari", "hotdog", "grandma", "bugati", "trojan"), expected: [12, 92, 65] },
    ];

    tests.forEach(({ input1, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.deepEqual(input1, expected);
        });
    });
});

// Wherefore art thou - filter an array of objects by second object values
describe("Wherefore art thou", () => {

    it("DATATYPE: It should return an Array", () => {
        assert.isArray(whatIsInAName([{ first: "Romeo", last: "Montague" }, { first: "Mercutio", last: null }, { first: "Tybalt", last: "Capulet" }], { last: "Capulet" }));
    });

    const tests = [
        { inputArray: [{ first: "Romeo", last: "Montague" }, { first: "Mercutio", last: null }, { first: "Tybalt", last: "Capulet" }], inputFilter: { last: "Capulet" }, expected: [{ first: "Tybalt", last: "Capulet" }] },
        { inputArray: [{ "apple": 1 }, { "apple": 1 }, { "apple": 1, "bat": 2 }], inputFilter: { "apple": 1 }, expected: [{ "apple": 1 }, { "apple": 1 }, { "apple": 1, "bat": 2 }] },
        { inputArray: [{ "apple": 1, "bat": 2 }, { "bat": 2 }, { "apple": 1, "bat": 2, "cookie": 2 }], inputFilter: { "apple": 1, "bat": 2 }, expected: [{ "apple": 1, "bat": 2 }, { "apple": 1, "bat": 2, "cookie": 2 }] },
        { inputArray: [{ "apple": 1, "bat": 2 }, { "apple": 1 }, { "apple": 1, "bat": 2, "cookie": 2 }], inputFilter: { "apple": 1, "cookie": 2 }, expected: [{ "apple": 1, "bat": 2, "cookie": 2 }] },
        { inputArray: [{ "apple": 1, "bat": 2 }, { "apple": 1 }, { "apple": 1, "bat": 2, "cookie": 2 }, { "bat": 2 }], inputFilter: { "apple": 1, "bat": 2 }, expected: [{ "apple": 1, "bat": 2 }, { "apple": 1, "bat": 2, "cookie": 2 }] },
        { inputArray: [{ "a": 1, "b": 2, "c": 3 }], inputFilter: { "a": 1, "b": 9999, "c": 3 }, expected: [] },
        { inputArray: [{ "a": 1, "b": 2, "c": 3, "d": 9999 }], inputFilter: { "a": 1, "b": 9999, "c": 3 }, expected: [] },
    ];

    tests.forEach(({ inputArray, inputFilter, expected }) => {
        it(`${JSON.stringify(inputFilter)} should return ${JSON.stringify(expected)}`, () => {
            assert.deepEqual(whatIsInAName(inputArray, inputFilter), expected);
        });
    });
});

// Spinal Tap Case
describe("Spinal Tap Case", () => {

    it("DATATYPE: It should return an Array", () => {
        assert.isString(spinalCase("This Is Spinal Tap"));
    });

    const tests = [
        { inputString: "This Is Spinal Tap", expected: "this-is-spinal-tap" },
        { inputString: "thisIsSpinalTap", expected: "this-is-spinal-tap" },
        { inputString: "The_Andy_Griffith_Show", expected: "the-andy-griffith-show" },
        { inputString: "Teletubbies say Eh-oh", expected: "teletubbies-say-eh-oh" },
        { inputString: "AllThe-small Things", expected: "all-the-small-things" },
        { inputString: "all the small things", expected: "all-the-small-things" },
        { inputString: "all_the_small_things", expected: "all-the-small-things" },

    ];

    tests.forEach(({ inputString, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.equal(spinalCase(inputString), expected);
        });
    });
});

// Pig Latin
describe("Pig Latin", () => {

    it("DATATYPE: It should return a String", () => {
        assert.isString(translatePigLatin("california"));
    })

    const tests = [
        { inputString: "california", expected: "aliforniacay" },
        { inputString: "paragraphs", expected: "aragraphspay" },
        { inputString: "glove", expected: "oveglay" },
        { inputString: "algorithm", expected: "algorithmway" },
        { inputString: "eight", expected: "eightway" },
        { inputString: "schwartz", expected: "artzschway" },
        { inputString: "rhythm", expected: "rhythmay" },
    ];

    tests.forEach(({ inputString, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.equal(translatePigLatin(inputString), expected);
        });
    });
});

// Search and Replace
describe("Search and Replace", () => {

    it("DATATYPE: It should return a String", () => {
        assert.isString(myReplace("Let us go to the store", "store", "mall"));
    })

    const tests = [
        { inputString: "Let us go to the store", findWord: "store", replaceWith: "mall", expected: "Let us go to the mall" },
        { inputString: "He is Sleeping on the couch", findWord: "Sleeping", replaceWith: "sitting", expected: "He is Sitting on the couch" },
        { inputString: "I think we should look up there", findWord: "up", replaceWith: "Down", expected: "I think we should look down there" },
        { inputString: "This has a spellngi error", findWord: "spellngi", replaceWith: "spelling", expected: "This has a spelling error" },
        { inputString: "His name is Tom", findWord: "Tom", replaceWith: "john", expected: "His name is John" },
        { inputString: "Let us get back to more Coding", findWord: "Coding", replaceWith: "algorithms", expected: "Let us get back to more Algorithms" },
    ];

    tests.forEach(({ inputString, findWord, replaceWith, expected }) => {
        it(`it should find ${findWord} and replace with ${replaceWith}`, () => {
            assert.equal(myReplace(inputString, findWord, replaceWith), expected);
        });
    });
});

// DNA Pairing
describe("DNA Pairing", () => {

    it("DATATYPE: It should return an Array", () => {
        assert.isArray(pairElement("ATCGA"));
    })

    const tests = [
        { inputString: "ATCGA", expected: [["A", "T"], ["T", "A"], ["C", "G"], ["G", "C"], ["A", "T"]] },
        { inputString: "TTGAG", expected: [["T", "A"], ["T", "A"], ["G", "C"], ["A", "T"], ["G", "C"]] },
        { inputString: "CTCTA", expected: [["C", "G"], ["T", "A"], ["C", "G"], ["T", "A"], ["A", "T"]] },
    ];

    tests.forEach(({ inputString, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.deepEqual(pairElement(inputString), expected);
        });
    });
});

// Missing letters
describe("Missing letters", () => {

    it("DATATYPE: It should return a String", () => {
        assert.isString(fearNotLetter("abce"));
    })

    const tests = [
        { inputString: "abce", expected: "d" },
        { inputString: "abcdefghjklmno", expected: "i" },
        { inputString: "stvwx", expected: "u" },
        { inputString: "bcdf", expected: "e" },
        { inputString: "abcdefghijklmnopqrstuvwxyz", expected: undefined },
    ];

    tests.forEach(({ inputString, expected }) => {
        it(`it should return ${expected}`, () => {
            assert.equal(fearNotLetter(inputString), expected);
        });
    });
});