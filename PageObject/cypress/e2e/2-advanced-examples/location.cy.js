describe("Login", () => {
  beforeEach(() => {
    cy.visit("http://localhost:3000/dashboard");
  });

  it("Should try to log in with all users", () => {
    cy.fixture("login-data.json").then((loginData) => {
      console.log(loginData); //
      loginData.users.forEach((user) => {
        cy.get('#email').type(user.email); 
        cy.get('input[name="password"]').type(user.password, { log: false }); 
        cy.get('button:contains("Sign In")').click(); 

        if (user.expectSuccess) {
          cy.url().should("include", "/dashboard")
        
        } else {
          cy.get('.Toastify__toast--error .Toastify__toast-body').should('be.visible');
        
          cy.get('body').then(($body) => {
            if ($body.find('#email').length) {
              cy.get('#email').clear()
            }
          })
          
          cy.get('body').then(($body) => {
            if ($body.find('input[name="password"]').length) {
              cy.get('input[name="password"]').clear()
            }
          })
        }
        
      })
    })
  })
})
