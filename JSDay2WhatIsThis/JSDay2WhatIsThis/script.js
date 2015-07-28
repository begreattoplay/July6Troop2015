
//Function invocation pattern
function addCount() {
    this._count++;
    console.log(this, this._count);
}

addCount(); //THIS refers to the global window object

//Method Invocation Pattern
var counter = {
    _count: 0,
    addCount: addCount
};

counter.addCount() //THIS refers to the counter object when invoked;

//Apply/Call invocation pattern
var somethingElse = {
    _count: 9
}

addCount.call(somethingElse); //THIS refers to the somethingElse object

//Array, Object, Function, Date

function AddCount2(count) {
    this.count = count;
}

var someObj = new AddCount2(4);
var someObj2 = new AddCount2(5);
var someObj3 = AddCount2(6);

console.log(someObj.count);
console.log(someObj2.count);
someObj.count++;

console.log(someObj.count);
console.log(someObj2.count);