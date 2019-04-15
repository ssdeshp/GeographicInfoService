import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ZipgeodataComponent } from './zipgeodata.component';

describe('ZipgeodataComponent', () => {
  let component: ZipgeodataComponent;
  let fixture: ComponentFixture<ZipgeodataComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ZipgeodataComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ZipgeodataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
