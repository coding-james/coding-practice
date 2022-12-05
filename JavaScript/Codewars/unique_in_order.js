// CODEWARS.COM - Unique in order
var uniqueInOrder = function (iterable) {
    let unique = [];
    if (iterable.length == 1 && iterable.includes('') && iterable.constructor === Array) {
        // console.log("I'm an emptry string in an array");
        unique = [''];
        return unique;
    } else if (iterable.length == 1 && iterable.includes(' ') && iterable.constructor === Array) {
        // console.log("I'm an emptry string in an array");
        unique = [''];
        return unique;
    } else if (iterable.constructor === String) {
        unique = [iterable.charAt(0)];
        for (let char = 0; char < iterable.length; char++) {
            if (iterable.charAt(char) != unique[unique.length - 1]) {
                unique.push(iterable.charAt(char));
            }
        }
        return unique;
    } else if (iterable.constructor === Array && iterable.length > 0) {
        unique = [iterable[0]];
        for (let char = 0; char < iterable.length; char++) {
            if (iterable[char] != unique[unique.length - 1]) {
                unique.push(iterable[char]);
            }
        }
        return unique;
    } else {
        unique = [''];
        return unique;
    }
}

console.log(uniqueInOrder('AAAABBBCCDAABBB'));
console.log(uniqueInOrder('ABBCcAD'));
console.log(uniqueInOrder([1, 2, 2, 3, 3]));
console.log(uniqueInOrder([]));
console.log(uniqueInOrder([""]));
console.log(uniqueInOrder(['']));
console.log(uniqueInOrder(['A']));
console.log(uniqueInOrder(['a']));
console.log(uniqueInOrder([' ']));
console.log(uniqueInOrder("A"));
console.log(uniqueInOrder([ '' ]));