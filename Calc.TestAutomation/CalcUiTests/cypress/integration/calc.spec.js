import 'cypress-iframe'
var calcHomePg = require("../support/calcPageObjects/calcHomepage")

Cypress.config('defaultCommandTimeout', 5000);

context('Calculator', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Add 2 positive numbers but clicking and choosing the "+" operator dropdown', () => {

        calcHomePg.inputLeftNumber("1");
        calcHomePg.inputRightNumber("2");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3");
    })
    
    it('Add 2 positive numbers by leaving the default "+" operator dropdown', () => {
        calcHomePg.inputLeftNumber("1");
        calcHomePg.inputRightNumber("2");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("3");
    })

})
