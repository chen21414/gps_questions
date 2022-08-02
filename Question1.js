//question#1

function filterNumbersFromArray(arr) {
  // Write the code that goes here

  for (let i = 0; i < arr.length; i++) {
    if (typeof arr[i] != "number") {
      arr.splice(i, 1); //remove 1 element at index i
      //i = 1
      --i; //Splice removed an element from the array you’re iterating over. So you need to adjust your position.
      //i = 0
    }
  }
} //can't use forEach here, because forEach is not looping

var arr = [1, "a", "b", 2];
filterNumbersFromArray(arr);
// At this point, arr should have been modified in place
// and contain only 1 and 2.
for (var i = 0; i < arr.length; i++) console.log(arr[i]);
