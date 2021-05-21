import 'cypress-iframe'

//Cypress.config('defaultCommandTimeout', 30000);

context('Calculator', () => {
    beforeEach(() => {
        cy.visit('/')
    })

    
    it('Add 2 positive numbers but clicking and choosing the "+" operator dropdown', () => {
        cy.get('#leftNumber').type("1");
        cy.get('#rightNumber').type("2");
        cy.get('#operator').select("+");
        cy.get('#root > div > div:nth-child(2) > iframe').then($iframe => {
            const $body = $iframe.contents().find('body')
            cy.wrap($body)
                .find('button')
                .click()
        })
        cy.get('input.result').should('have.value', '3')
    })
    
    it('Add 2 positive numbers by leaving the default "+" operator dropdown', () => {
        cy.get('#leftNumber').type("1");
        cy.get('#rightNumber').type("2");
        cy.get('#root > div > div:nth-child(2) > iframe').then($iframe => {
            const $body = $iframe.contents().find('body')
            cy.wrap($body)
                .find('button')
                .click()
        })
        cy.get('input.result').should('have.value', '3')
    })







})
