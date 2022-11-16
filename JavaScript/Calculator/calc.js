"use strict"

const calcInput = document.getElementById("calcScreen");

//For Loop to capture numbers - allows for multiple digits
for (let numberButton of document.querySelectorAll("div#calc button.num")) {
    numberButton.addEventListener("click", function (event) {
        calcInput.value += event.target.innerText;
    });
}

let firstNum;
let operator;

//For Loop to capture the operator
for (let operatorButton of document.querySelectorAll("div#calc button.op")) {
    operatorButton.addEventListener("click", function (event) {
        firstNum = calcInput.value;
        operator = event.target.innerText;
        calcInput.value = "";

    });
}


document.getElementById("btnClear").addEventListener("click", function () {
    calcInput.value = "";
});


document.getElementById("btnEqual").addEventListener("click", function () {
    let secondNum = calcInput.value;
    let result;
    switch (operator) {
        case "+":
            result = parseFloat(firstNum) + parseFloat(secondNum);
            break;
        case "-":
            result = firstNum - secondNum;
            break;
        case "*":
            result = firstNum * secondNum;
            break;
        case "/":
            result = firstNum / secondNum;
            break;
    }

    calcInput.value = result;
  });