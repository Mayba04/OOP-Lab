import LoginPage from "./LoginPage";

export default class AddUserPage {
  get lastName() {return cy.get("#lastName");}
  get email() {return cy.get("#email");}
  get phoneNumberInput() {return cy.get("#phoneNumber");}
  get password() {return cy.get("#password");}
  get confirmPasswordInput() {return cy.get("#confirmPassword");}
  get submitButton() {return cy.get('button:contains("CreateUser")');}

  constructor() {
    this.loginPage = new LoginPage();
  }

  loginAndVisit() {
    cy.visit("http://localhost:3000/dashboard");
    this.loginPage
      .typeEmail("admi@gmail.com")
      .typePassword("Qwerty-1")
      .clickSignIn();
    return this;
  }

  visit() {
    cy.get('a[href="/dashboard/addUser"]').click();
    return this;
  }

  typeUsername(username) {
    cy.get("input[name=username]").type(username);
    return this;
  }

  typeFirstName(name) {
    cy.get('#firstName').type(name, { force: true });
    return this;
}

  typeLastName(lastName) {
    this.lastName.type(lastName, { log: false });
    return this;
  }

  typeEmail(email) {
    this.email.type(email);
    return this; 
  }

  typePhoneNumber(phoneNumber) {
    this.phoneNumberInput.type(phoneNumber);
    return this; 
  }

  typeRole() 
  {
    cy.get('#role').select('User');
    return this;
  }

  typePassword(password) {
    this.password.type(password);
    return this;
  }

  typeConfirmPassword(confirmPassword) {
    this.confirmPasswordInput.type(confirmPassword);
    return this;
  }

  clickSubmit() {
    this.submitButton.click();
    return this;
  }
}
