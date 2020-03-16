export const environment = {
  production: false,
  hmr: true,
  application: {
    name: 'ResourceService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44339',
    clientId: 'ResourceService_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'ResourceService',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44339',
    },
  },
  localization: {
    defaultResourceName: 'ResourceService',
  },
};
