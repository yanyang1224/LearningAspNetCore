export const environment = {
  production: true,
  application: {
    name: 'MIS',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44304',
    clientId: 'MIS_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'MIS',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44304'
    }
  },
  localization: {
    defaultResourceName: 'MIS'
  }
};
