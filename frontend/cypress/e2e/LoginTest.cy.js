describe('template spec', () => {
    it('Check if login works (invalid login)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('test')
        cy.get('#password').type('test')
        cy.contains('Log in').click()
        cy.contains('Login lukte niet')
    })

    // it('Check if login works (valid login)', () => {
    //     cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
    //     cy.get('#username').type('testuserddddd')
    //     cy.get('#password').type('testwW1!')
    //     cy.contains('Log in').click()
    //     cy.contains('U bent ingelogd')
    // })
    
    // it('Check if login works (Medewerker)', () => {
    //     cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
    //     cy.get('#username').type('test')
    //     cy.get('#password').type('test')
    //     cy.contains('Log in').click()
    //     cy.contains('U bent ingelogd')
    // })

    // it('Check if login works (Admin)', () => {
    //     cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
    //     cy.get('#username').type('test')
    //     cy.get('#password').type('test')
    //     cy.contains('Log in').click()
    //     cy.contains('U bent ingelogd')
    // })

    // it('Check if login works (Artiest)', () => {
    //     cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
    //     cy.get('#username').type('test')
    //     cy.get('#password').type('test')
    //     cy.contains('Log in').click()
    //     cy.contains('U bent ingelogd')
    // })
    
    // it('Check if login works (Donateur)', () => {
    //     cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
    //     cy.get('#username').type('test')
    //     cy.get('#password').type('test')
    //     cy.contains('Log in').click()
    //     cy.contains('U bent ingelogd')
    // })
})