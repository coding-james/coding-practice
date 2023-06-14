"use strict";

// Sum All Numbers in a Range
function sumAll(arr) {
    let result = 0;

    // sort the arr
    let sortedArray = [].concat(arr).sort(function (a, b) { // concat original array onto a blank array
        return a === b ? 0 : a < b ? -1 : 1;;
    });

    // for loop start at first number, ending with second number
    for (let number = sortedArray[0]; number <= sortedArray[1]; number++) {
        result += number;
    }

    return result;
}

// Diff Two Arrays - Compare two arrays, return unique elements
function diffArray(arr1, arr2) {
    function arrayCompare(array1, array2) {
        let compareArr = [];
        for (let index = 0; index < array1.length; index++) {
            if (array2.indexOf(array1[index]) < 0) {
                compareArr.push(array1[index]);
            }
        }
        return compareArr;
    };

    let arr1Unique = arrayCompare(arr1, arr2);
    let arr2Unique = arrayCompare(arr2, arr1);
    let newArr = arr1Unique.concat(arr2Unique);

    return newArr.sort(function (a, b) {
        return a === b ? 0 : a < b ? -1 : 1;;
    });

    // more succient would be:
    // function diffArray(arr1, arr2) {
    //     return arr1
    //       .concat(arr2)
    //       .filter(item => !arr1.includes(item) || !arr2.includes(item));
    // };
};

// Seek and Destroy
function destroyer(arr) {
    for (let index = 1; index < arguments.length; index++) {
        while (arr.indexOf(arguments[index]) >= 0) {
            arr.splice(arr.indexOf(arguments[index]), 1);
        }
    }
    return arr;
};

// Wherefore art thou - filter an array of objects by second object values
function whatIsInAName(collection, source) {
    const sourceKeys = Object.keys(source);

    return collection.filter(obj => {
        for (let index = 0; index < sourceKeys.length; index++) {
            if (obj[sourceKeys[index]] !== source[sourceKeys[index]]) {
                return false;
            }
        }
        return true;
    });
};


// Spinal Tap Case
function spinalCase(str) {
    return str
        .replace(/([a-z])([A-Z])/g, "$1 $2") // replace Uppercase following lowercase with lowercase space Uppercase
        .split(/[^a-z]/i) // split by non alphabetic chars
        .join("-") //join with -
        .toLowerCase(); //change all to lowercase
};

module.exports = { sumAll, diffArray, destroyer, whatIsInAName, spinalCase };