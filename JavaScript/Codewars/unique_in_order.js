// CODEWARS.COM - Disemvowel Trolls
var uniqueInOrder=function(iterable) {
    if(iterable.constructor === String){
        let unique = iterable.charAt(0);
        for(let char=0; char < iterable.length; char++){
            if(iterable.charAt(char) != unique.charAt(unique.length - 1)){
                unique = unique + iterable.charAt(char);
            }
        }
        console.log(unique);
    } else if(iterable.constructor === Array){
        // TODO: Finsih off this section & convert unique to arrays instead.
        let unique = iterable[0];
        // console.log("I'm an array");
        console.log(iterable[0]);
        for(let char=0; char < iterable.length; char++){
            if(iterable[char] != unique.charAt(unique.length - 1)){
                unique = unique + iterable[char];
            }
        }
    }
  }


console.log(uniqueInOrder('AAAABBBCCDAABBB'));
// console.log("Expected: ['A', 'B', 'C', 'D', 'A', 'B']")
  
console.log(uniqueInOrder('ABBCcAD'));
// console.log("Expected: ['A', 'B', 'C', 'c', 'A', 'D']")
  
console.log(uniqueInOrder([1,2,2,3,3]));
// console.log("Expected: [1,2,3]")
