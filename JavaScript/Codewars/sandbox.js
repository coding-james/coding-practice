let array = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];

function ArrayLength(array) {
    console.log("Array Length = " + array.length);
}

function Array0Length(array) {
    console.log("Array[0] Length = " + array[0].length);
}

function Array2Digit0(array) {
    console.log("Array[1][0] = " + array[1][0]);
}

function Array2LastDigit(array) {
    console.log("Array[1][-1] = " + array[1][array[1].length - 1]);
}

function LastDigitLastArray(array) {
    console.log("Last digit of last array = " + array[array.length - 1][array[array.length - 1].length - 1]);
}

ArrayLength(array);
Array0Length(array);
Array2Digit0(array);
Array2LastDigit(array);
LastDigitLastArray(array);