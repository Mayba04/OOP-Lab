class LoginPage {
    visit() {
      cy.visit('/login.html');
    }
  
    fillUsername(username) {
      cy.get('#username').type(username);
    }
  
    fillPassword(password) {
      cy.get('#password').type(password);
    }
  
    submitForm() {
      cy.get('button[type="submit"]').click();
    }
  
    checkSuccessfulLogin() {
      cy.url().should('include', '/dashboard'); // Перевірте URL після авторизації
    }
  }
  
  export default new LoginPage();