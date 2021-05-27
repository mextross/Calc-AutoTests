/**Addition UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/
Cypress.config('defaultCommandTimeout', 8000);

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('Addition', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Add 2 positive integers but clicking and choosing the "+" operator dropdown', () => {
        calcHomePg.Calculate("1", "+", "2", "3");
    })

    it('EF: Add 2 positive integers by leaving the default "+" operator dropdown', () => {
        calcHomePg.Calculate("3", "+", "4", "7");
    })

    it('EF: Add 2 negative integers', () => {
        calcHomePg.Calculate("-34", "+", "-58", "-92");
    })

    it('EF: Add 1 positive and 1 negative integer', () => {
        calcHomePg.Calculate("99", "+", "-1", "98");
    })

    it('Add 1 positive integer and 0', () => {
        calcHomePg.Calculate("0", "+", "123", "123");
    })

    it('EF: Add 1 negative integer and 0', () => {
        calcHomePg.Calculate("0", "+", "-89", "-89");
    })

    it('EF: Add 2 fractions', () => {
        calcHomePg.Calculate("1/2", "+", "3/4", "5/4");
    })

    it('EF: Add 2 decimals', () => {
        calcHomePg.Calculate("0.5", "+", "1.3", "1.8");
    })

    it('Add 2 integers each 3 digits long(max input)', () => {
        calcHomePg.Calculate("999", "+", "999", "1998");
    })

    it('EF: Add 2 exponents', () => {
        calcHomePg.Calculate("2^3", "+", "2^4", "24");
    })

    it('EF: Add 2 complex numbers', () => {
        calcHomePg.Calculate("2i", "+", "3", "2i + 3");
    })

    it('EF: Add 2 irrational numbers', () => {
        calcHomePg.Calculate("e", "+", "π", "5.85987448205");
    })

    it('EF: Add 2 algebraic expressions', () => {
        calcHomePg.Calculate("2x", "+", "x", "3x");
    })
})
