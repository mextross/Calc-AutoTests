var calcHomePage = function () {

    var leftNumberInput = '#leftNumber'
    var rightNumberInput = '#rightNumber'
    var operatorDropdown = '#operator'
    var result = 'input.result'
    var calculatorButton = '#calculate'
    var iframe = '#root > div > div:nth-child(2) > iframe'

    this.inputLeftNumber = function (leftNum) {
        cy.get(leftNumberInput).clear().type(leftNum)
    };

    this.inputRightNumber = function (rightNum) {
        cy.get(rightNumberInput).clear().type(rightNum)
    };

    this.selectOperator = function (op) {
        cy.get(operatorDropdown).select(op);
    };

    this.clickCalculatorButton = function () {
        cy.get(iframe).then($iframe => {
            const $body = $iframe.contents().find('body')
            cy.wrap($body)
                .find(calculatorButton)
                .click()
        })
    };

    this.checkResult = function (expectedResult) {
        cy.get(result).should('have.value', expectedResult)
    };

};
module.exports = new calcHomePage();