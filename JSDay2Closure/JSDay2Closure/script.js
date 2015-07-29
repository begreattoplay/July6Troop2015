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