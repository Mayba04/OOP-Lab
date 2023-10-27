class EditUserPage {

    get firstName() {return cy.get("#firstName");}
    get lastName() {return cy.get("#lastName");}
    get role() {return cy.get("#role");}
    get phoneNumberInput() {return cy.get("#phoneNumber");}
    get submitButton() {return cy.get('button:contains("Save Changes")');}

    setFirstName(name) {
        this.firstName.clear();
        this.firstName.type(name, { force: true });
        return this;
    }

  
    setLastName(lastName) {
        this.lastName.clear();
        this.lastName.type(lastName);
        return this;
    }

    clearFields() {
        this.passwordInput.clear();
        this.passwordInput.clear();
        return this;
    }
  
    setRole(role) {
        this.role.clear();
        this.role.type(role);
        return this;
    }
  
    setPhoneNumber(phoneNumber) {
        this.phoneNumberInput.clear();
        this.phoneNumberInput.type(phoneNumber);
    }
  
    clickSave() {
        this.submitButton.click();
        return this;
    }
  
  }
  
  export default EditUserPage;