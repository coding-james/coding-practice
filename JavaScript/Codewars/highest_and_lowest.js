// CODEWARS.COM - Highest and Lowest

function highAndLow(numbers){
    const numArray = numbers.split(" ");
    for(let i = 0; i < numArray.length; i++) {
        numArray.splice(i, 1, parseInt(numArray[i]));
    }
    return `${Math.max(...numArray)} ${Math.min(...numArray)}`;
  }

console.log(highAndLow("1 2 3 4 5"));
console.log(highAndLow("1 2 -3 4 5"));
console.log(highAndLow("1 9 3 4 -5"));