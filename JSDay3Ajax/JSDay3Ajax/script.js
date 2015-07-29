var xhr = new XMLHttpRequest();

xhr.addEventListener('load', function (e) {
    var data = JSON.parse(xhr.responseText);
    console.dir(data);
});

xhr.addEventListener('progress', function (e) {
    if (e.lengthComputable) {
        var percentComplete = Math.round(e.loaded / e.total * 100);
        console.info(percentComplete + '% loaded');
    }
    else {
        console.info('loading...');
    }
});

//xhr.onload = function () {
//    var data = JSON.parse(this.response);
//    console.dir(data);
//}

xhr.open('GET', '/products.json');
xhr.send();

console.log('Hello there!');