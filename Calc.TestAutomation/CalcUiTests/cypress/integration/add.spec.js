import 'cypress-iframe'
var calcHomePg = require("../support/calcPageObjects/calcHomepage")

Cypress.config('defaultCommandTimeout', 3000);

context('Addition', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Add 2 positive integers but clicking and choosing the "+" operator dropdown', () => {

        calcHomePg.inputLeftNumber("1");
        calcHomePg.inputRightNumber("2");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3");
    })


    it('EF: Add 2 positive integer by leaving the default "+" operator dropdown', () => {
        calcHomePg.inputLeftNumber("3");
        calcHomePg.inputRightNumber("4");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("7");
    })

    it('EF: Add 2 negative integers', () => {
        calcHomePg.inputLeftNumber("-34");
        calcHomePg.inputRightNumber("-58");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-92");
    })

    it('EF: Add 1 positive and 1 negative integer', () => {
        calcHomePg.inputLeftNumber("99");
        calcHomePg.inputRightNumber("-1");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("98");
    })

    it('Add 1 positive integer and 0', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.inputRightNumber("123");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("123");
    })

    it('EF: Add 1 negative integer and 0', () => {
        calcHomePg.inputLeftNumber("0");
        calcHomePg.inputRightNumber("-89");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("-89");
    })

    
    it('EF: Add 2 fractions', () => {
        calcHomePg.inputLeftNumber("1/2");
        calcHomePg.inputRightNumber("3/4");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("5/4");
    })

    it('EF: Add 2 decimals', () => {
        calcHomePg.inputLeftNumber("0.5");
        calcHomePg.inputRightNumber("1.3");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("1.8");
    })

    it('Add 2 integers each 3 digits long(max input)', () => {
        calcHomePg.inputLeftNumber("999");
        calcHomePg.inputRightNumber("999");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("1998");
    })

    it('EF: Add 2 exponents', () => {
        calcHomePg.inputLeftNumber("2^3");
        calcHomePg.inputRightNumber("2^4");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("24");
    })
    
    it('EF: Add 2 complex numbers', () => {
        calcHomePg.inputLeftNumber("2i");
        calcHomePg.inputRightNumber("3");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("2i + 3");
    })
    it('EF: Add 2 irrational numbers', () => {
        calcHomePg.inputLeftNumber("e");
        calcHomePg.inputRightNumber("π");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("5.85987448205");
    })

    it('EF: Add 2 algebraic expressions', () => {
        calcHomePg.inputLeftNumber("2x");
        calcHomePg.inputRightNumber("x");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3x");
    })
})
