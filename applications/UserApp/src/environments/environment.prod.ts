import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ProductService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44386',
    redirectUri: baseUrl,
    clientId: 'ProductService_App',
    responseType: 'code',
    scope: 'offline_access ProductService',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44306',
      rootNamespace: 'ProductService',
    },
  },
} as Environment;
