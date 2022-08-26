var myObject = {
    foo: "bar",
    func: function() {
        var self = this;
        console.log(this.foo); //bar
        console.log(self.foo); //bar
        (function() {
            console.log(this.foo); //undefined
            console.log(self.foo); //bar
        }());
    }
};
myObject.func();

//This would output the followiing:
//
//bar 
//bar
//undefined
//bar
