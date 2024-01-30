import { Component, OnInit } from '@angular/core';
import { GePessoaFisicaService } from '../services/ge-pessoa-fisica.service';

@Component({
  selector: 'lib-ge-pessoa-fisica',
  template: ` <p>ge-pessoa-fisica works!</p> `,
  styles: [],
})
export class GePessoaFisicaComponent implements OnInit {
  constructor(private service: GePessoaFisicaService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
