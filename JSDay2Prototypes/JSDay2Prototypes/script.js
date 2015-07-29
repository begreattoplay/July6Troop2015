'use strict';

//Constructor way to do prototypes
//function Product(name, price) {
//    this.name = name;
//    this.price = price;
//}

//Product.prototype = {
//    calculateTax: function () {
//        return this.price * 0.08;
//    }
//}

//var product1 = new Product('Milk', 2.33);
//var product2 = new Product('Cheese', 4.33);

//console.log(product1.calculateTax());

//Class way to do prototypes

class Product {
    constructor(name, price) {
        this._name = name;
        this._price = price;
    }

    calculateTax() {
        return this._price * 0.08;
    }
};

var product1 = new Product('Milk', 2.33);
var product2 = new Product('Cookies', 4.33);

class Car extends Product {
    constructor(name, price, model) {
        super(name, price);
        this._model = model;
    }

    static listModels() {
        return new Set(['Mini S', 'Tesla S', 'BMW 328i']);
    }
}
var car1 = new Car('Mini Cooper', 12000.00, 'Mini S');

var models = Car.listModels();