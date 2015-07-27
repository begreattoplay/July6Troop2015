'use strict';

var firstNumber = 12;
var secondNumber = 3;

var result = addNumbers(firstNumber, secondNumber);
console.assert(result == 15, "Result is not 15");

//cl+tab+tab to write console.log()

function addNumbers(val1, val2) {
    var oops = val1 + val2;
    return oops;
}

console.log(parseInt("20.33")); // writes 20
console.log(parseFloat('20.33')); // writes 20.33
console.log(parseFloat('20.33 is too much!')); // writes 20.33

console.log(+'20'); //writes 20
console.log(+'20.33'); // writes 20.33
console.log(+'20.33 is too much!'); // writes NaN


//var input = prompt();
//var value = parseFloat(input);

//if (!isNaN(value)) {
//    alert(value * 100);
//}
//else {
//    alert("Invalid Input");
//}


function calculateTax(price, taxRate) {
    var rate = taxRate || .08;
    (taxRate == 0) ? rate = 0 : rate = rate;
    var myTax = price * rate;
    return (price + myTax);
}


function addIntegers(val1, val2){
    var result;

    if (typeof val1 != "number" || typeof val2 != "number")
        throw new Error("given a non-number");
    else if (parseInt(val1) != val1 || parseInt(val2) != val2)
        throw new Error("float value given, expected integer");
    result = val1 + val2;

    return result;
}

//addIntegers("1", 2);
//addIntegers("apple");
addIntegers(3.4, 1);

