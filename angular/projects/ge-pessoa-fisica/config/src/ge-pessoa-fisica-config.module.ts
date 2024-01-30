import { ModuleWithProviders, NgModule } from '@angular/core';
import { GE_PESSOA_FISICA_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class GePessoaFisicaConfigModule {
  static forRoot(): ModuleWithProviders<GePessoaFisicaConfigModule> {
    return {
      ngModule: GePessoaFisicaConfigModule,
      providers: [GE_PESSOA_FISICA_ROUTE_PROVIDERS],
    };
  }
}
