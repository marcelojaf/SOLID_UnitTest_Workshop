const Adition = require ('./Calculator');

test('Calculator_Addition_MustReturnCorrectResult', () => {
    expect(Adition(1,2)).toBe(3);
});