/**General UI tests
 * Prefix EF: Expected failure of a test due to a defect
*/

var calcHomePg = require("../support/calcPageObjects/calcHomepage")

context('General', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('EF: when there is a valid test followed by an invalid input, retains old result', () => {
        calcHomePg.Calculate("3", "+", "4", "7");
        calcHomePg.Calculate("0.5", "+", "0.5", "Decimal input is invalid! Please enter a whole number!");
    })

    it('EF: one input field is left blank', () => {
        calcHomePg.Calculate("3", "+", "", "7");
    })

    it('EF: no regex to prevent input of invalid characters', () => {
        calcHomePg.Calculate("!@#", "+", "$%&", "Error: invalid characters!");
    })
})
