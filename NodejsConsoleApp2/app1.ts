//functions
function add(x, y) {
    return x + y;
}

var sum = function (x, y) {
    return x + y;

};
var result = add(2, 3);
console.log(result);

//default Parameters
function Mul(x: number, y: number, z: number = 0): number {
    return x + y + z;
}
let result1 = Mul(2, 3);
let result2 = Mul(4, 5,10);
let result3 = Mul(6, 9,10);
console.log(result1);
console.log(result2);
console.log(result3);

//without parameters
function divison() {
    let x = 20;
    let y = 40;
    return x / y;
}
var result4 = divison();
console.log(divison);



//public acess modifier
class Employee {
    public empID: number;//Acess specifiers
    empName: string;
}
let emp = new Employee();//instance created
emp.empID = 101;
emp.empName = "Haritha";
console.log(emp.empID + " " + emp.empName); 

class Student {
    public studCode: number;
    studName: string;
    studSection: string;
    studCity: string;

}

let s = new Student();
s.studCode = 1;
s.studName = "Haritha";
s.studSection="B Section";
s.studCity="Vizag";


console.log(s.studCode + " " + s.studName + "" + s.studSection+" "+s.studCity );  

//private access modifier
class employee {
    public empID: number;
    private empName: string; //note:whenevr we use private AM we intend
                             //tocreate the constructor to initialize the vale from the same AM
    constructor(ID: number, Name: string) {
        this.empID = ID;
        this.empName = Name;
    }
    public display() {
       return ("Employee ID:" +this.empID + "Employee Name:" + this.empName);
       
        //return { ' Employee ID: { this.empID }' };
        //return { 'Employee Name: { this.empName }' };


    }
}
//closing block of class -employee
//let's instantiate
let employee1 = new employee(101,"Haritha");//instance created
employee1.empID = 102;

console.log(employee1.display());


class student {
    public studCode: number;
    private studName: string;
    constructor(code: number, name: string) {
        this.studCode = code;
        this.studName = name;
    }
    public display() {
        return (`My unique code: ${this.studCode}, my name: ${this.studName}.`);
    }
}

let student1: student = new student(1, "Haritha");
console.log(student1.display());  

//protected
class employe {
    public empID: number;
    protected empName: string;
    constructor(ID: number, Name: string) {
        this.empID = ID;
        this.empName = Name;
    }
}
class Someone extends employe {
    private City: string;
    constructor(ID: number, Name: string, City: string) {
        //properties of parent class
        super(ID, Name);
        this.City = City;

    }
    public Getsomemethod() {
        return ("Employee ID:" + this.empID + "Employee Name:" + this.empName+"Employee City:"+this.City);
    }
}
let obj1: Someone = new Someone(101, "Haritha", "Vizag");
console.log(obj1.Getsomemethod());  


class Student1 {
    public studCode: number;
    protected studName: string;
    constructor(code: number, name: string) {
        this.studCode = code;
        this.studName = name;
    }
}
class Person extends Student1 {
    private department: string;

    constructor(code: number, name: string, department: string) {
        super(code, name);
        this.department = department;
    }
    public Getresult() {
        return (`My unique code: ${this.studCode}, my name: ${this.studName} and I am in ${this.department} Branch.`);
    }
}
let object: Person = new Person(1, "Haritha", "CSE");
console.log(object.Getresult());  

//readonly modifier
class Company {
    readonly country: string = "India";
    readonly name: string;

    constructor(contName: string) {
        this.name = contName;
    }
    showDetails() {
        console.log(this.name + " : " + this.country);
    }
}

let comp = new Company("Dxc");
comp.showDetails(); // Dxc : India  

//modules
/*FileName : EmployeeInterface.ts   
//export interface Employee {
    //code declarations   
}*/

//import { class/interface name } from 'module_name'; 

import { Addition } from './addition';

let addObject = new Addition(10, 20);

addObject.Sum();  



import { Addition1, Substraction } from './Module';

let AddObject = new Addition(10, 20);
let subObject = new Substraction(20, 10);

AddObject.Sum();
subObject.Substract();  


//Multiple decorator
function f() {
    console.log("f(): evaluated");
    return function (
        target,
        propertyKey: string,
        descriptor: PropertyDescriptor
    ) {
        console.log("f(): called");
    };
}

function g() {
    console.log("g(): evaluated");
    return function (
        target,
        propertyKey: string,
        descriptor: PropertyDescriptor
    ) {
        console.log("g(): called");
    };
}

class C {
    @f()
    @g()
    method() { }
}

//class Decorator
/*@sealed
class Human {
    msg: string;
    constructor(message: string) {
        this.msg = message;
    }
    show() {
        return "Hello, " + this.msg;
    }
}  

class Item {
    itemArr: Array;
    constructor() {
        this.itemArr = [];
    }
    @log
    Add(item: string): void {
        this.itemArr.push(item);
    }
    GetAll(): Array {
        return this.itemArr;
    }
}  */





console.log('Hello world');