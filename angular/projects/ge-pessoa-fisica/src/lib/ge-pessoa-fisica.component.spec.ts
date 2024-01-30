import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { GePessoaFisicaComponent } from './components/ge-pessoa-fisica.component';
import { GePessoaFisicaService } from '@necnat-abp.Br/ge-pessoa-fisica';
import { of } from 'rxjs';

describe('GePessoaFisicaComponent', () => {
  let component: GePessoaFisicaComponent;
  let fixture: ComponentFixture<GePessoaFisicaComponent>;
  const mockGePessoaFisicaService = jasmine.createSpyObj('GePessoaFisicaService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [GePessoaFisicaComponent],
      providers: [
        {
          provide: GePessoaFisicaService,
          useValue: mockGePessoaFisicaService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GePessoaFisicaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
