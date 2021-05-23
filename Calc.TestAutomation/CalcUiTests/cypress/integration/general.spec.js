/**General UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/
Cypress.config('defaultCommandTimeout', 3000);

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('General', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('EF: one input field is left blank', () => {
        calcHomePg.inputLeftNumber("3");
        calcHomePg.selectOperator("+");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("Error: One of the fields is empty! Please enter a value.");
    })

    it('EF: no regex to prevent input of invalid characters', () => {
        calcHomePg.inputLeftNumber("!@#");
        calcHomePg.selectOperator("+");
        calcHomePg.inputRightNumber("$%&");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("Error: invalid characters!");
    })

    it('EF: when there is a valid test followed by an invalid input, retains old result', () => {
        calcHomePg.inputLeftNumber("3");
        calcHomePg.selectOperator("+");
        calcHomePg.inputRightNumber("4");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("7");
        calcHomePg.inputLeftNumber("0.5");
        calcHomePg.selectOperator("+");
        calcHomePg.inputRightNumber("0.5");
        calcHomePg.clickCalculatorButton();
        calcHomePg.checkResult("Decimal input is invalid! Please enter a whole number!");
    })

})
