'use strict';

var teams = [
    'Astros',
    'Dynamo',
    'Texans',
    'Rockets'
];

teams.forEach(function (team) {
    console.log(team);
});

var products = new Array();

products.push({ name: 'Cheese', price: 7.00 });
products.push({ name: 'Milk', price: 3.00 });
products.push({ name: 'Wine', price: 97.30 });
products.push({ name: 'Grapes', price: 4.00 });

//Filter
var filteredProducts = products.filter(function (product) {
    return product.price > 5.00;
});

filteredProducts.forEach(function (product) {
    //console.log(product);
});

//Reduce
var done = products.reduce(function (previous, current, index, arr) {
    return { price: previous.price + current.price };
});

//console.log(done.price);


//unique word count
var obj = {
    countUnique: function (sentence) {
        var wordArray = sentence.toLowerCase().split(' ');
        var wordSet = new Set(wordArray);
        return wordSet.size;
    }
};

var sentence = "the cat and the cat ate the rat";
console.log(obj.countUnique(sentence));