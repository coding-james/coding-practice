// CODEWARS.COM - Multiples of 3 or 5
function solution(number) {
    let result = 0;
    for (let num = (number - 1); num > 0; num--) {
        if (num % 3 == 0 || num % 5 == 0) {
            result += num;
        }
    }
    return result;
    // console.log(result);
}

solution(10);
solution(3);
solution(0);
solution(-3);
solution(9);