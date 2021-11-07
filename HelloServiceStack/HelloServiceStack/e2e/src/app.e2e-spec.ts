import { AppPage } from './app.po';

describe('hello-service-stack App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('HelloServiceStack');
  });
});
