const { assert } = require("chai");
const { VigenèreCipher } = require("../../../Codewars/4 kyu/vigenere_cipher_helper");

// CODEWARS: Vigenère Cipher Helper
describe("Vigenère Cipher Helper: Encode", () => {
    var abc, key;
    abc = "abcdefghijklmnopqrstuvwxyz";
    key = "password"
    c = new VigenèreCipher(key, abc);

    const tests = [
        { arg: "codewars", expected: "rovwsoiv" },
        { arg: "waffles", expected: "laxxhsj" },
        { arg: "CODEWARS", expected: "CODEWARS" },
        { arg: "codewarswaffles", expected: "rovwsoivlaxxhsj" },
        { arg: "it's a shift cipher!", expected: "xt\'k o vwixl qzswej!" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(c.encode(arg), expected);
        });
    });
});

describe("Vigenère Cipher Helper: Decode", () => {
    var abc, key;
    abc = "abcdefghijklmnopqrstuvwxyz";
    key = "password"
    d = new VigenèreCipher(key, abc);

    const tests = [
        { arg: "rovwsoiv", expected: "codewars" },
        { arg: "laxxhsj", expected: "waffles" },
        { arg: "CODEWARS", expected: "CODEWARS" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(d.decode(arg), expected);
        });
    });
});

describe("Vigenère Cipher Helper: Encode pizza", () => {
    var abc, key;
    abc = "abcdefghijklmnopqrstuvwxyz";
    key = "pizza"
    h = new VigenèreCipher(key, abc);

    const tests = [
        { arg: "asodavwt", expected: "pancakes" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(h.encode(arg), expected);
        });
    });
});

describe("Vigenère Cipher Helper: Encode katakana alphabet", () => {
    var abc, key;
    abc = "アイウエオァィゥェォカキクケコサシスセソタチツッテトナニヌネノハヒフヘホマミムメモヤャユュヨョラリルレロワヲンー";
    key = "カタカナ"
    f = new VigenèreCipher(key, abc);

    const tests = [
        { arg: "カタカナ", expected: "タモタワ" },
        { arg: "javascript", expected: "javascript" },
        { arg: "ドモアリガトゴザイマス", expected: "ドオカセガヨゴザキアニ" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(f.encode(arg), expected);
        });
    });
});

describe("Vigenère Cipher Helper: Decode katakana alphabet", () => {
    var abc, key;
    abc = "アイウエオァィゥェォカキクケコサシスセソタチツッテトナニヌネノハヒフヘホマミムメモヤャユュヨョラリルレロワヲンー";
    key = "カタカナ"
    g = new VigenèreCipher(key, abc);

    const tests = [
        { arg: "タモタワ", expected: "カタカナ" },
        { arg: "javascript", expected: "javascript" },
        { arg: "ドオカセガヨゴザキアニ", expected: "ドモアリガトゴザイマス" },
    ];

    tests.forEach(({ arg, expected }) => {
        it(`should return ${expected}`, () => {
            assert.equal(g.decode(arg), expected);
        });
    });
});