/**Multiplication UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/
Cypress.config('defaultCommandTimeout', 3000);

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('Multiplication UI tests', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Multiply 2 positive integers', () => {

        calcHomePg.inputLeftNumber("1");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("2");
    })

    it('Multiply 2 negative integers', () => {
        calcHomePg.inputLeftNumber("-34");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("-58");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("1972");
    })

    it('EF: Multiply 1 positive and 1 negative integer', () => {
        calcHomePg.inputLeftNumber("99");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("-1");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-99");
    })

    it('Multiply 1 positive integer and 0', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("123");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("0");
    })

    it('Multiply 1 negative integer and 0', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("-89");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("0");
    })

    it('EF: Multiply 2 fractions', () => {
        calcHomePg.inputLeftNumber("3/4");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("1/2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3/8");
    })

    it('EF: Multiply 2 decimals', () => {
        calcHomePg.inputLeftNumber("1.52");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("3.67");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("5.5784");
    })

    it('EF: Multiply integers each 3 digits long(max input)', () => {
        calcHomePg.inputLeftNumber("999");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("999");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("998001");
    })

    it('EF: Multiply 2 exponents', () => {
        calcHomePg.inputLeftNumber("2^3");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("2^4");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("128");
    })

    it('EF: Multiply 2 complex numbers', () => {
        calcHomePg.inputLeftNumber("3i");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("7");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("21i");
    })

    it('EF: Multiply 2 irrational numbers', () => {
        calcHomePg.inputLeftNumber("e");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("π");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("8.53973422267");
    })

    it('EF: Multiply 2 algebraic expressions', () => {
        calcHomePg.inputLeftNumber("x");
        calcHomePg.selectOperator("*");
        calcHomePg.inputRightNumber("x");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("x^2");
    })
})
