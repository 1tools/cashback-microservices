import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:5000';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ProductService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:8001',
    redirectUri: baseUrl,
    clientId: 'PublicWebsiteClient',
    responseType: 'code',
    scope: 'offline_access ProductService',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:6001',// Gateway
      rootNamespace: 'ProductService',
    },
  },
} as Environment;
