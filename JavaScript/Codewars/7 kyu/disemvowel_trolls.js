// CODEWARS.COM - Disemvowel Trolls

function disemvowel(str) {
    if (str.length > 0){
      return str = str.replace(/a|e|i|o|u/gi,"");
    }  
  }
  
  console.log(disemvowel("This website is for losers LOL!"));
  console.log(disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
  console.log(disemvowel("What are you, a communist?"));