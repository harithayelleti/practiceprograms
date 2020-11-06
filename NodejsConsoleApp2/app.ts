
//Generics
function echo<T>(arg: T): T { //To tell to typescript that argument and returning value 
    //of  a function should be as same, T is a placeholder                                                            
    return arg;
}
//var myStr : string = echo(1) // ==> It will bring an error becoz DT are not same
var myStr = echo(1);

class SalesMgr {
    fname: string;
    lname: string;
    constructor(fname: string, lname: string) { //constructor
        this.fname = fname;
        this.lname = lname;
    }
    public getFullName() { //Declaration of Methods
        return this.fname + " " + this.lname;

    }
}
class Admin extends SalesMgr { }
class HRMgr extends SalesMgr { }

let admin = new Admin('a', 'a');

function Echo<T extends SalesMgr>(SalesMgr: T): T { //
    return SalesMgr;
}

var foo = Echo(admin);


//Typescript Map and Set


let map = new Map(); //map have values and keys 
map.set(123, 'bunny')
map.set(345, 'ramya');
map.set(true, false);
console.log(map);   //Can contain duplicate values  but keys should be unique

let names = ['sruthi', 'pabba', 'aditya', 'mahi', 'pv','leela','chandini','ammu','satya']
names.push('sruthi');

let set = new Set(names);//Set have only values
console.log(names);
console.log(set); //Cannot contain duplicate values 


console.log('Hello world');