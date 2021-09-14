
/*
  Math.Floor() function returns the largest integer less than or equal to a given number. 
  Math.Random() function returns a floating-point, pseudo-random number in the range 0 to less than 1 
  (inclusive of 0, but not 1) with approximately uniform distribution over that range — which you can then scale to your desired range.
*/
let y = Math.floor(Math.random() * 100 + 1);

let guess = 1;

document.getElementById("submitguess").onclick = function () {
  let x = document.getElementById("guess-field").value;

  if (x == y) {
    console.log("User guessed correctly");
    alert(`Congratualtions! Your guess ${guess} is correct.`);
  }
  else if (x > y) {
    console.log("User guess is wrong")
    guess++;
    alert("OOPS SORRY!! TRY A SMALLER NUMBER");
  }
  else {
    console.log("User guess is wrong")
    guess++;
    alert("OOPS SORRY!! TRY A GREATER NUMBER")
  }
}