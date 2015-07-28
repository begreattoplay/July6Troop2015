'use strict';

var buttons = document.getElementsByTagName("button");
addClickHandlers(buttons);

function addClickHandlers(buttons) {
    for (var i = 0; i < buttons.length; i++) {
        addClickHandler(buttons[i], i);
        //buttons[i].addEventListener('click', function () {
        //    alert('You clicked button ' + i);
        //});
    }
}

function addClickHandler(button, index) {
    button.addEventListener('click', function () {
        alert('You clicked button ' + index);
    });
}


(function getFunction() {
    var message = 'Hello World!';

    //inner function
    return function () {
        console.log(message);
    }
})()();


function Product(name, price) {
    this.name = name;
    this.price = price;
}

Product.prototype = {
    calculateTax: function () {
        return this.price * 0.08;
    }
}

var product1 = new Product('Milk', 2.33);
var product2 = new Product('Cheese', 4.33);

console.log(product1.calculateTax());