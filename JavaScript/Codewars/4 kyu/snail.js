// CODEWARS: Snail Sort

var snail = function (array) {

    let digitCount = array.flat().length;
    let result = [];

    while (result.length < digitCount) {
        // first array cycle through
        for (i = 0; i < array[0].length; i++) {
            result.push(array[0][i]); // In order, pushes digits from First nested array
        }
        array.shift(); // removes first nested array

        // then last digit of middle arrays
        if (array.length > 1) {
            for (m = 0; m < array.length - 1; m++) {
                result.push(array[m][array[m].length - 1]); // pushes last digit of the current (m) array
                array[m].pop(); // removes the last digit from current array
            }
        }

        // then last array, end to start
        if (array.length > 0) {
            for (e = array[array.length - 1].length - 1; e >= 0; e--) {
                result.push(array[array.length - 1][e]); // end to start pushes digits from last nested array 
            }
            array.pop(); // removes last nested array
        }

        // then first digit of middle arrays
        if (array.length > 1) {
            for (m = array.length - 1; m > 0; m--) {
                result.push(array[m][0]); // returns first digit of the current (m) array
                array[m].shift(); // removes the first digit from current array
            }    
        }
    }
    return result;
}

module.exports = snail;