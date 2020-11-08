import { Component, OnInit } from '@angular/core';

@Component({
  selector:'app-lappy', 
  template: `  
    <button (click)="show = !show">{{show ? 'hide' : 'show'}}</button>  
    show = {{show}}  
    <br>  
    <div *ngIf="show">Text to show</div> 

    <button (click)="click = !click">{{click ? 'hide' : 'click'}}</button>  
    click = {{click}}  
    <br>  
    <div *ngIf="click; else elseBlock">Text to show</div>  
    <ng-template #elseBlock>Alternate text while primary text is hidden</ng-template>`
  

})
export class LappyComponent implements OnInit {
  show: boolean = true;  
  click: boolean = true;  

  constructor() { }

  ngOnInit(): void {
  }

}
