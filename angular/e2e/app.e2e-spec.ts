import { TigerTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: TigerTemplatePage;

  beforeEach(() => {
    page = new TigerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
