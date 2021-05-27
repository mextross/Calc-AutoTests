/**Multiplication UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/
Cypress.config('defaultCommandTimeout', 3000);

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('Division UI tests', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Divide 2 positive integers with no remainder', () => {

        calcHomePg.inputLeftNumber("99");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("11");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("9");
    })

    it('Divide 2 negative integers with no remainder', () => {

        calcHomePg.inputLeftNumber("-99");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("-11");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("9");
    })

    it('EF: Divide 1 positive and 1 negative integer', () => {
        calcHomePg.inputLeftNumber("99");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("-1");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-99");
    })

    it('EF: Divide a dividend lesser than a divisor', () => {
        calcHomePg.inputLeftNumber("6");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("5");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("1.2");
    })

    it('Divide 0 by an integer', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("123");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("0");
    })

    it('EF: Divide an integer by zero', () => {
        calcHomePg.inputLeftNumber("123");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("0");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("undefined");
    })


    it('EF: Divide 2 fractions', () => {
        calcHomePg.inputLeftNumber("3/4");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("1/2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3/2");
    })

    it('EF: Divide 2 decimals', () => {
        calcHomePg.inputLeftNumber("1.5");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("0.5");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3");
    })

    it('Divide integers each 3 digits long(max input)', () => {
        calcHomePg.inputLeftNumber("999");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("999");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("1");
    })

    it('EF: Divide 2 exponents', () => {
        calcHomePg.inputLeftNumber("2^4");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("2^3");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("2");
    })

    it('EF: Divide 2 complex numbers', () => {
        calcHomePg.inputLeftNumber("6i");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3i");
    })

    it('EF: Divide 2 irrational numbers', () => {
        calcHomePg.inputLeftNumber("e");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("π");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("0.86525597943");
    })

    it('EF: Divide 2 algebraic expressions', () => {
        calcHomePg.inputLeftNumber("2x");
        calcHomePg.selectOperator("/");
        calcHomePg.inputRightNumber("x");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("2");
    })
})
