import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  n1: number = 10;    
    n2: number = 20;  
    

    
  
  student: s[] = [{name: 'Haritha', id: 101,City:'Vizag'}, {name: 'Sruthi', id: 102,City:'Vizag'}, {name: 'Bunny', id: 103,City:'Vizag'},{name: 'Vamsi', id: 104,City:'Vizag'}, {name: 'Kavya', id: 105,City:'AKP'}, {name: 'Priscilla', id: 106,City:'Visakhapatnam'}];  
  selectedValue: string= 'Haritha'; 
  title = 'AngularDirectives';
  subtitle = 'Employee Data';
  Employee : any[]=[
    {ID:'101',Name:'Yamini',Designation:'Technical', City:'SKM'},
    {ID:'102',Name:'Haritha',Designation:'s/w engineer', City:'Vizag'},
    {ID:'103',Name:'Sruthi',Designation:'Admin', City:'Vizag'},
    {ID:'104',Name:'Kavya',Designation:'Data Admin', City:'AKP'},
    {ID:'105',Name:'Rohitha',Designation:'Hr', City:'ananthapur'},
    {ID:'106',Name:'Sowji',Designation:'Technical', City:'kakinada'},
]
titlee : any ="Top  Movies/WebSeries Recently" ;  
    movies: Movie[] =[  
        {title:'KGF',director:'Prasanth Neel',cast:'Yash,srinidhisheety',releaseDate:'2018'},  
        {title:'Bahubali',director:'ss.Rajamouli',cast:'Prabhas,Anushka,Rana',releaseDate:'2016'},  
        {title:'Dil Bechara',director:'Mukesh chabra',cast:'Sushanth singh Rajput,Sanjana sanghi',releaseDate:'2020'},  
        {title:'Money-Heist',director:'Alex Rodrigo',cast:'Alvaro Morte,Ursula Corbero,Alba Flores',releaseDate:'2020'},  
    ]  

}

class s {  
  name: string;  
  id: number; 
  City:any; 
} 
 
class Employee
{
  ID:any;
  Name:string;
  Designation:string;
  City:any;
}



class Movie {  
    title : string;  
    director : string;  
    cast : string;  
    releaseDate : string;  
}  
  

  
