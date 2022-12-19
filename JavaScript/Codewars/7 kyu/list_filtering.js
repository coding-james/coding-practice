// Codewars: List Filtering
function filter_list(l) {
    // Return a new array with the strings filtered out
    let filtered = [];
    for (let i = 0; i <= l.length; i++) {
        if (typeof l[i] === "number") {
            filtered.push(l[i]);
        }
    }
    return filtered;
  }

console.log(filter_list([1,2,'a','b']));
console.log(filter_list([1,'a','b',0,15]));
console.log(filter_list([1,2,'aasf','1','123',123]));