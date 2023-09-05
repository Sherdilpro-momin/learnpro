import { learnproTemplatePage } from './app.po';

describe('learnpro App', function() {
  let page: learnproTemplatePage;

  beforeEach(() => {
    page = new learnproTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
