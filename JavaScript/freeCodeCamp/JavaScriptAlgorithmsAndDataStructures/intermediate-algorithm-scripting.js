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

// Pig Latin
function translatePigLatin(str) {
    let vowels = /[aeiou]/i;
    let vowelsArray = ["a", "e", "i", "o", "u"];

    if (vowels.test(str[0])) { // if first letter is vowel, add WAY to end
        return str + "way";
    } else if (!vowels.test(str)) { // if no vowels, add AY to the end of the word
        return str + "ay";
    } else { // if word begins with consonant, take the first consonant or consonant cluster, move it to the end of the word, and add AY to it
        for (let index = 0; index < str.length; index++) {
            if (vowelsArray.indexOf(str[index]) != -1) {
                return str.substr(index) + str.substr(0, index) + "ay"
            }
        }
    };
};

// Search and Replace - replace word and preserve case of the first charatcter of word
function myReplace(str, before, after) {
    let afterFormatted = before[0] == before[0].toUpperCase() ? after[0].toUpperCase() + after.substr(1).toLowerCase() : after[0].toLowerCase() + after.substr(1).toLowerCase();
    return str.replace(before, afterFormatted);
};

// DNA Pairing
function pairElement(str) {
    let DNA = [];
    for (let index = 0; index < str.length; index++) {

        let tempArr = []

        switch (str[index]) {
            case "A":
                tempArr.push("A", "T");
                break;
            case "T":
                tempArr.push("T", "A");
                break;
            case "C":
                tempArr.push("C", "G");
                break;
            case "G":
                tempArr.push("G", "C");
                break;
            default:
                break;
        }

        DNA.push(tempArr);
    }
    return DNA;
};

// Missing letters
function fearNotLetter(str) {
    let letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
    let current = letters.indexOf(str[0]);

    for (let index = 0; index < str.length; index++) {
        if (letters[current] != str[index]) {
            return letters[current];
        } else {
            current++;
        }
    }

    return undefined;
};

// Sorted Union
function uniteUnique(arr) {
    let results = [];
    for (let i = 0; i < arguments.length; i++) {
        for (let j = 0; j < arguments[i].length; j++) {
            if (!results.includes(arguments[i][j])) {
                results.push(arguments[i][j]);
            } else {
                continue;
            }
        };
    }
    return results;
};

// Convert HTML Entities
function convertHTML(str) {

    let htmlEntities = {
        '&': "&amp;",
        '<': "&lt;",
        '>': "&gt;",
        '"': "&quot;",
        "'": "&apos;"
    };

    return str.replace(/([&<>\"'])/g, match => htmlEntities[match]);
};

// Sum All Odd Fibonacci Numbers
function sumFibs(num) {
    let total = 0;
    let previous1 = 0;
    let previous2 = 0;

    for (let current = 1; current <= num; current = previous1 + previous2) {

        if (current % 2 != 0) {
            total += current;
        }
        previous1 = previous2;
        previous2 = current;
    }
    return total;
};

// Sum All Primes
function sumPrimes(num) {
    // Prime Check 
    function isPrime(n) {
        const sqrt = Math.sqrt(n);
        for (let i = 2; i <= sqrt; i++) {
            if (n % i === 0)
                return false;
        }
        return true;
    };

    let total = 0;

    for (let i = 2; i <= num; i++) {
        if (isPrime(i)) {
            total += i;
        }
    }

    return total;
};

// Smallest Common Multiple
function smallestCommons(arr) {
    let result = 0;
    let num = Math.max(arr[0], arr[1]);
    let outcomes = [];

    while (result == 0) {
        for (let numInRange = Math.min(arr[0], arr[1]); numInRange <= Math.max(arr[0], arr[1]); numInRange++) {
            if (num % numInRange != 0) {
                break;
            } else {
                outcomes.push(num);
            };
        }

        if (outcomes.length == (Math.max(arr[0], arr[1]) - Math.min(arr[0], arr[1])) + 1) {
            result = num;
        } else {
            num++;
            outcomes.length = 0; //empty array
        }
    }

    return result;
};

// Drop it
function dropElements(arr, func) {
    for (let index = 0; index < arr.length; index++) {
        if (func(arr[index])) {
            return arr.slice(index);
        };
    }

    return [];
};

module.exports = { sumAll, diffArray, destroyer, whatIsInAName, spinalCase, translatePigLatin, myReplace, pairElement, fearNotLetter, uniteUnique, convertHTML, sumFibs, sumPrimes, smallestCommons, dropElements };