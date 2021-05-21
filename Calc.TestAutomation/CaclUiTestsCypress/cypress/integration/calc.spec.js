import 'cypress-iframe'

Cypress.config('defaultCommandTimeout', 30000);

context('Calculator', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    it('Add 2 positive numbers', () => {
        cy.visit('/')
        cy.get('#leftNumber').type("1");
        cy.get('#rightNumber').type("2");
        cy.get('#operator').select("*");
        cy.get('#root > div > div:nth-child(2) > iframe').then($iframe => {
            const $body = $iframe.contents().find('body')
            cy.wrap($body)
                .find('button')
                .click()
        })
        cy.get('input.result').should('have.value', '2')
    })




})
