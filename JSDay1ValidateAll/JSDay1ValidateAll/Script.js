var customer = {
    required_firstName: '',
    required_lastName: '',
    favoriteColor: ''
};

function addRequiredValidation(obj) {
    var newObj = {};
    for (var index in obj) {
        if (index.indexOf('required_') != -1) {
            (function (index) {
                var fieldName = "_" + index.substring(9);
                newObj[fieldName] = '';
                Object.defineProperty(newObj, index.substring(9), {
                    get: function() {
                        return this[fieldName];
                    },
                    set: function (value) {
                        if (!value)
                            throw new Error(fieldName.substring(1) + " is required");
                        this[fieldName] = value;
                    }
                })
            })(index);
        }        
    }

    return newObj;
}

var newCustomer = addRequiredValidation(customer);
newCustomer.firstName = "Nick";