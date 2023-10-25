export default class LoginPage {
    get emailInput() { return cy.get('#email'); }
    get passwordInput() { return cy.get('input[name="password"]'); }
    get signInButton() { return cy.get('button:contains("Sign In")'); }
    get errorToast() { return cy.get('.Toastify__toast--error .Toastify__toast-body'); }
  
    typeEmail(email) {
      this.emailInput.type(email);
      return this; 
    }
  
    typePassword(password) {
      this.passwordInput.type(password, { log: false });
      return this;
    }
  
    clickSignIn() {
      this.signInButton.click();
      return this;
    }

    clearFields() {
      this.emailInput.clear();
      this.passwordInput.clear();
      return this;
  }
  
    isErrorToastVisible() {
      this.errorToast.should('be.visible');
      return this;
    }
  }
  