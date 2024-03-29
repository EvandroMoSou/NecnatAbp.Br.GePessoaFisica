import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class GePessoaFisicaService {
  apiName = 'GePessoaFisica';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/GePessoaFisica/sample' },
      { apiName: this.apiName }
    );
  }
}
