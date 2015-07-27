"use script";

//Customer Object

var customer = {
    _firstName: '',
    _lastName: '',
    get firstName() {
        return this._firstName;
    },
    set firstName(first) {
        if (!first)
            throw new Error("FirstName cannot be empty");

        this._firstName = first;
    },
    get lastName() {
        return this._lastName;
    },
    set lastName(last) {
        if (!last)
            throw new Error("LastName cannot be empty");

        this._lastName = last;
    }
};

function dumpAll(obj) {
    var result = '';
    for (var key in obj) {
        result += "name: " + key + ", value: " + obj[key] + "\r\n";
    }
    alert(result);
}

customer.firstName = "Nick";
customer.lastName = "Nick";

dumpAll(customer);