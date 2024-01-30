import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { GePessoaFisicaComponent } from './components/ge-pessoa-fisica.component';
import { GePessoaFisicaRoutingModule } from './ge-pessoa-fisica-routing.module';

@NgModule({
  declarations: [GePessoaFisicaComponent],
  imports: [CoreModule, ThemeSharedModule, GePessoaFisicaRoutingModule],
  exports: [GePessoaFisicaComponent],
})
export class GePessoaFisicaModule {
  static forChild(): ModuleWithProviders<GePessoaFisicaModule> {
    return {
      ngModule: GePessoaFisicaModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<GePessoaFisicaModule> {
    return new LazyModuleFactory(GePessoaFisicaModule.forChild());
  }
}
