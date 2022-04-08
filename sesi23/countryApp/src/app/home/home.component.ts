import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Country } from '../models/country';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  @Input() countriesByGdp:Country[] = []
  @Input() countriesByArea:Country[] = []
  @Input() countriesByPopulation:Country [] = []
  @Output() clickEvent = new EventEmitter<string>()

  constructor() { }

  ngOnInit(): void {
  }

  emitEvent(countryName:string){
    this.clickEvent.emit(countryName)
  }

}
