/**Multiplication UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/
Cypress.config('defaultCommandTimeout', 8000);

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('Multiplication UI tests', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Multiply 2 positive integers', () => {
        calcHomePg.Calculate("1", "*", "2", "2");
    })

    it('Multiply 2 negative integers', () => {
        calcHomePg.Calculate("-34", "*", "-58", "1972");
    })

    it('EF: Multiply 1 positive and 1 negative integer', () => {
        calcHomePg.Calculate("99", "*", "-1", "-99");
    })

    it('Multiply 1 positive integer and 0', () => {
        calcHomePg.Calculate("0", "*", "123", "0");
    })

    it('Multiply 1 negative integer and 0', () => {
        calcHomePg.Calculate("0", "*", "-89", "0");
    })

    it('EF: Multiply 2 fractions', () => {
        calcHomePg.Calculate("3/4", "*", "1/2", "3/8");
    })

    it('EF: Multiply 2 decimals', () => {
        calcHomePg.Calculate("1.52", "*", "3.67", "5.5784");
    })

    it('EF: Multiply integers each 3 digits long(max input)', () => {
        calcHomePg.Calculate("999", "*", "999", "998001");
    })

    it('EF: Multiply 2 exponents', () => {
        calcHomePg.Calculate("2^3", "*", "2^4", "128");
    })

    it('EF: Multiply 2 complex numbers', () => {
        calcHomePg.Calculate("3i", "*", "7", "21i");
    })

    it('EF: Multiply 2 irrational numbers', () => {
        calcHomePg.Calculate("e", "*", "π", "8.53973422267");
    })

    it('EF: Multiply 2 algebraic expressions', () => {
        calcHomePg.Calculate("x", "*", "x", "x^2");
    })
})
