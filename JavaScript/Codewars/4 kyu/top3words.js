// CODEWARS: Most frequently used words in a text
function topThreeWords(text) {
    // trim and split by " " - DONE
    // remove non A-Z and ' - DONE
    // group words and count - TODO
    // sort list, return top 3 (or 2, 1 if less) - TODO
    // or return blank array []

    let cleanText = text.toLowerCase().replace(/[^a-z' ]/g, '');
    let words = cleanText.trim().split(" ");
    let group = {};

    for (i = 0; i < words.length; i++) {
        if (!group.contains({word: words[i]})) {
            group.push({word: words[i], count: 1});
        } else {
            console.log(`Another instance of ${word}`);
        }
    }
}
module.exports = topThreeWords;