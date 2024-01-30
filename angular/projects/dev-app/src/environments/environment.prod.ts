import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'GePessoaFisica',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44397/',
    redirectUri: baseUrl,
    clientId: 'GePessoaFisica_App',
    responseType: 'code',
    scope: 'offline_access GePessoaFisica',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44397',
      rootNamespace: 'NecnatAbp.Br.GePessoaFisica',
    },
    GePessoaFisica: {
      url: 'https://localhost:44307',
      rootNamespace: 'NecnatAbp.Br.GePessoaFisica',
    },
  },
} as Environment;
