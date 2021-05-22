import 'cypress-iframe'
var calcHomePg = require("../support/calcPageObjects/calcHomepage")

Cypress.config('defaultCommandTimeout', 3000);

context('Subtraction', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Subtract 2 positive integers', () => {

        calcHomePg.inputLeftNumber("1");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-1");
    })

    it('EF: Subtract 2 negative integers', () => {
        calcHomePg.inputLeftNumber("-34");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("-58");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("24");
    })

    it('EF: Subtract 1 positive and 1 negative integer', () => {
        calcHomePg.inputLeftNumber("99");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("-1");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("100");
    })

    it('Subtract 1 positive integer and 0', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("123");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-123");
    })

    it('EF: Subtract 1 negative integer and 0', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("-89");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("89");
    })

    
    it('EF: Subtract 2 fractions', () => {
        calcHomePg.inputLeftNumber("3/4");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("1/2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("1/4");
    })

    it('EF: Subtract 2 decimals', () => {
        calcHomePg.inputLeftNumber("0.5");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("1.3");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-0.8");
    })

    it('Subtract integers each 3 digits long(max input)', () => {
        calcHomePg.inputLeftNumber("999");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("999");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("0");
    })

    it('EF: Subtract 2 exponents', () => {
        calcHomePg.inputLeftNumber("2^3");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("2^4");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-8");
    })
    
    it('EF: Subtract 2 complex numbers', () => {
        calcHomePg.inputLeftNumber("3i");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("7");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3i - 7");
    })

    it('EF: Subtract 2 irrational numbers', () => {
        calcHomePg.inputLeftNumber("e");
        calcHomePg.selectOperator("-");
        calcHomePg.inputRightNumber("π");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-0.42331082513");
    })

    it('EF: Subtract 2 algebraic expressions', () => {
        calcHomePg.inputLeftNumber("2x");
        calcHomePg.inputRightNumber("x");
        calcHomePg.selectOperator("-");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3x");
    })
})
