/**Multiplication UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('Division UI tests', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Divide 2 positive integers with no remainder', () => {
        calcHomePg.Calculate("99", "/", "11", "9");
    })

    it('Divide 2 negative integers with no remainder', () => {
        calcHomePg.Calculate("-99", "/", "-11", "9");
    })

    it('EF: Divide 1 positive and 1 negative integer', () => {
        calcHomePg.Calculate("-99", "/", "1", "-99");
    })

    it('EF: Divide a dividend lesser than a divisor', () => {
        calcHomePg.Calculate("6", "/", "5", "1.2");
    })

    it('Divide 0 by an integer', () => {
        calcHomePg.Calculate("0", "/", "123", "0");
    })

    it('EF: Divide an integer by zero', () => {
        calcHomePg.Calculate("123", "/", "0", "undefined");
    })

    it('EF: Divide 2 fractions', () => {
        calcHomePg.Calculate("3/4", "/", "1/2", "3/2");
    })

    it('EF: Divide 2 decimals', () => {
        calcHomePg.Calculate("1.5", "/", "0.5", "3");
    })

    it('Divide integers each 3 digits long(max input)', () => {
        calcHomePg.Calculate("999", "/", "999", "1");
    })

    it('EF: Divide 2 exponents', () => {
        calcHomePg.Calculate("2^4", "/", "2^3", "2");
    })

    it('EF: Divide 2 complex numbers', () => {
        calcHomePg.Calculate("6i", "/", "2", "3i");
    })

    it('EF: Divide 2 irrational numbers', () => {
        calcHomePg.Calculate("e", "/", "π", "0.86525597943");
    })

    it('EF: Divide 2 algebraic expressions', () => {
        calcHomePg.Calculate("2x", "/", "x", "2");
    })
})
