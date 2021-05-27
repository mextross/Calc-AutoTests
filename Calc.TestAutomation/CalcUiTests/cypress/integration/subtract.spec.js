/**Subtraction UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/
Cypress.config('defaultCommandTimeout', 8000);

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('Subtraction', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Subtract 2 positive integers', () => {
        calcHomePg.Calculate("1", "-", "2", "-1");
    })

    it('EF: Subtract 2 negative integers', () => {
        calcHomePg.Calculate("-34", "-", "-58", "24");
    })

    it('EF: Subtract 1 positive and 1 negative integer', () => {
        calcHomePg.Calculate("99", "-", "-1", "100");
    })

    it('Subtract 1 positive integer and 0', () => {
        calcHomePg.Calculate("0", "-", "123", "-123");
    })

    it('EF: Subtract 1 negative integer and 0', () => {
        calcHomePg.Calculate("0", "-", "-89", "89");
    })

    it('EF: Subtract 2 fractions', () => {
        calcHomePg.Calculate("3/4", "-", "1/2", "1/4");
    })

    it('EF: Subtract 2 decimals', () => {
        calcHomePg.Calculate("0.5", "-", "1.3", "-0.8");
    })

    it('Subtract integers each 3 digits long(max input)', () => {
        calcHomePg.Calculate("999", "-", "999", "0");
    })

    it('EF: Subtract 2 exponents', () => {
        calcHomePg.Calculate("2^3", "-", "2^4", "-8");
    })

    it('EF: Subtract 2 complex numbers', () => {
        calcHomePg.Calculate("3i", "-", "7", "3i - 7");
    })

    it('EF: Subtract 2 irrational numbers', () => {
        calcHomePg.Calculate("e", "-", "π", "-0.42331082513");
    })

    it('EF: Subtract 2 algebraic expressions', () => {
        calcHomePg.Calculate("2x", "-", "x", "x");
    })
})
