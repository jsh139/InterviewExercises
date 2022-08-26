var a = {};
var b = null;
var c;

if(a) {  //true
    console.log(1) 
}
if(b) { //false
    console.log(2) 
}
if(b == c){ //true
    console.log(3) 
}
if(b === c){ //false
    console.log(4) 
}
if(typeof b === typeof a){ //true
    console.log(5) 
}

//What would be outputted from running through these if statements? How do they evaluate?
//1 3 5

// Any object evaulates to true, including empty objects and arrays {} or []
// null and undefined evaluate to false
// == converts the values to the same type and evaluates. Null and undefined both evaluate to false, so they are equal
// === evaluates based on if the type and value are equivalent. Null is an object and undefined in undefined so this is false.
// null is an object