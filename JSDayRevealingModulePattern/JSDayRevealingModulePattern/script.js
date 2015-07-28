"use strict";

var module = (function () {

    //private methods
    function _calculatePrice(price) {
        return price + _calculateTax(price);
    }
    
    function _calculateTax(price) {
        return price * .08;
    }

    return {
        calculatePrice: _calculatePrice
    };
})();

module.calculatePrice(10);