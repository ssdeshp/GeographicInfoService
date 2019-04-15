import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
//import { ZipInfo } from '../ZipInfo';
import { ZipFacts } from '../ZipFacts';
import { ZipgeoService } from '../zipgeo.service';
import '@angular/common';


@Component({
  selector: 'app-zipgeodata',
  templateUrl: './zipgeodata.component.html',
  styleUrls: ['./zipgeodata.component.css']
})
export class ZipgeodataComponent implements OnInit {

  zipFacts: ZipFacts = {
    zipcode: '95747',
    city: "",
    temperature: "",
    timeZoneName: "",
    elevation: "",
    message: "",
  };
  errorMsg: string;

  constructor(private zipgeoService: ZipgeoService) { }

  ngOnInit() {
    this.getZipGeo();
  }

  getZipGeo(): void {
    this.errorMsg = "";

    if (this.zipFacts.zipcode) {
      this.zipgeoService.getZipGeo(this.zipFacts.zipcode)
        .subscribe(zipFacts => this.zipFacts = zipFacts,
        error => this.errorMsg = error);
    }
  }
}
