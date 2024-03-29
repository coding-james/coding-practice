"use strict";
const { assert } = require("chai");
const { checkCashRegister } = require("../../../freeCodeCamp/JavaScriptAlgorithmsAndDataStructures/cash-register");

// describe("Cash Register", () => {
//     const tests = [
//         { inputPrice: 19.5, inputCash: 20, inputCid: [["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]], expected: {status: "OPEN", change: [["QUARTER", 0.5]]} },
//         { inputPrice: 3.26, inputCash: 100, inputCid: [["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]], expected: {status: "OPEN", change: [["TWENTY", 60], ["TEN", 20], ["FIVE", 15], ["ONE", 1], ["QUARTER", 0.5], ["DIME", 0.2], ["PENNY", 0.04]]} },
//         { inputPrice: 19.5, inputCash: 20, inputCid: [["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]], expected: {status: "OPEN", change: [["TWENTY", 60], ["TEN", 20], ["FIVE", 15], ["ONE", 1], ["QUARTER", 0.5], ["DIME", 0.2], ["PENNY", 0.04]]} },
//         { inputPrice: 19.5, inputCash: 20, inputCid: [["PENNY", 0.01], ["NICKEL", 0], ["DIME", 0], ["QUARTER", 0], ["ONE", 0], ["FIVE", 0], ["TEN", 0], ["TWENTY", 0], ["ONE HUNDRED", 0]], expected: {status: "INSUFFICIENT_FUNDS", change: []} },
//         { inputPrice: 19.5, inputCash: 20, inputCid: [["PENNY", 0.01], ["NICKEL", 0], ["DIME", 0], ["QUARTER", 0], ["ONE", 1], ["FIVE", 0], ["TEN", 0], ["TWENTY", 0], ["ONE HUNDRED", 0]], expected: {status: "INSUFFICIENT_FUNDS", change: []} },
//         { inputPrice: 19.5, inputCash: 20, inputCid: [["PENNY", 0.5], ["NICKEL", 0], ["DIME", 0], ["QUARTER", 0], ["ONE", 0], ["FIVE", 0], ["TEN", 0], ["TWENTY", 0], ["ONE HUNDRED", 0]], expected: {status: "CLOSED", change: [["PENNY", 0.5], ["NICKEL", 0], ["DIME", 0], ["QUARTER", 0], ["ONE", 0], ["FIVE", 0], ["TEN", 0], ["TWENTY", 0], ["ONE HUNDRED", 0]]} },
//     ];

//     tests.forEach(({ inputPrice, inputCash, inputCid, expected }) => {
//         it(`${inputPrice} should return ${expected}`, () => {
//             assert.deepEqual(checkCashRegister(inputPrice, inputCash, inputCid,), expected);
//         });
//     });
// });