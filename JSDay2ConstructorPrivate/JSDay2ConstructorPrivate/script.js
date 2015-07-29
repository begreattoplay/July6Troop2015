function Product(name, price) {
    this.name = name;
    this.price = price;
    var that = this;

    function _calculateTax() {
        return that.price * 0.08;
    }

    this.calculateTotalPrice = function () {
        return this.price + _calculateTax();
    }
}

//Product.prototype = (function () {
//    function _calculateTax(price) {
//        return price * 0.08;
//    }

//    function _calculateTotalPrice() {
//        return this.price + _calculateTax(this.price);
//    }

//    return {
//        calculateTotalPrice: _calculateTotalPrice
//    };
//})();

var product1 = new Product('Cookies', 2.99);
product1.calculateTotalPrice();