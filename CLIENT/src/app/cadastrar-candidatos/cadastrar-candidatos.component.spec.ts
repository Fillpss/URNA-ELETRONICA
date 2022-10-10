import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarCandidatosComponent } from './cadastrar-candidatos.component';

describe('CadastrarCandidatosComponent', () => {
  let component: CadastrarCandidatosComponent;
  let fixture: ComponentFixture<CadastrarCandidatosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastrarCandidatosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastrarCandidatosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
