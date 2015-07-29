'use strict';

class Ajax {
    constructor(method, url, data) {
        this.method = method;
        this.url = url;
        this.data = data;
    }

    //success method - two arguments are the complete callback and the progress callback functions
    success(completedCallback, progressCallback) {       
        this._doRequest(completedCallback, progressCallback);
    }

    //Make the actual AJAX request method.  This method is designated as 'private'
    _doRequest(completedCallback, progressCallback) {
        //var that = this;
        var req = new XMLHttpRequest();

        req.open(this.method, this.url);
        req.onload = function () {
            var data = JSON.parse(this.response);
            if (typeof(completedCallback) === "function") {
                completedCallback(data);
            }
        }

        req.addEventListener('progress', function (e) {
            if (typeof(progressCallback) === "function") {
                progressCallback(e);
            }
        });

        if (this.method === 'GET')
            req.send();
        else
            req.send(JSON.stringify(this.data));
    }

    // Get method - static version of a GET request
    static get(url, callback) {
        var req = new XMLHttpRequest();
        req.open('GET', url);
        req.onload = function() {
            var data = JSON.parse(this.response);
            if (typeof(callback) === "function") {
                callback(data);
            }
        };
    }
}

var myReq = new Ajax('GET', 'http://api.openweathermap.org/data/2.5/find?q=Pearland,tx&units=imperial');
myReq.success(function (data) {
    console.dir(data);
});

//Ajax.get('http://api.openweathermap.org/data/2.5/find?q=Pearland,tx&units=imperial', function (data) {
//    console.dir(data);
//});