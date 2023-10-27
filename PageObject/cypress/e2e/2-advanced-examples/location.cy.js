import LoginPage from "./pageObjects/LoginPage.js";
import AddUserPage from "./pageObjects/AddUser.js";
import UserTablePage from "./pageObjects/UserTablePage.js";
import EditUserPage from "./pageObjects/EditUserPage.js";
import DeleteUser from "./pageObjects/DeleteUser.js";

const loginPage = new LoginPage();
const addUserPage = new AddUserPage();
const userTablePage = new UserTablePage();
const editUserPage = new EditUserPage();
const deleteUser = new DeleteUser();

describe("Login", () => {
 
  beforeEach(() => {
    cy.visit("http://localhost:3000/dashboard");
  });

  it("Should try to log in with all users", () => {
    cy.fixture("login-data.json").then((loginData) => {
      loginData.users.forEach((user) => {
        loginPage.typeEmail(user.email)
                 .typePassword(user.password)
                 .clickSignIn();

        if (user.expectSuccess) {
          cy.url().should("include", "/dashboard");
          Cypress.env();
        } else {
          loginPage.isErrorToastVisible();
        }

        cy.get('body').then(($body) => {
          if ($body.find('#email').length > 0 && $body.find('input[name="password"]').length > 0) {
              loginPage.clearFields();
          }
      });

      });
    });
  });

  it("Add User", () => {
    addUserPage.loginAndVisit();
    addUserPage.visit();

    cy.url().should("include", "/dashboard/addUser");
  
    addUserPage.typeFirstName('Oleg')
               .typeLastName('Olegovich')
               .typeEmail('email@example.com')
               .typeRole()
               .typePhoneNumber('+xx(xxx)xxx-xx-xx')
               .typePassword('Qassword-123')
               .typeConfirmPassword('Qassword-123')
               .clickSubmit();

  });

  it("Edit User", () => {
    addUserPage.loginAndVisit();
    userTablePage.visit();
    userTablePage.clickEditForUser('Oleg');

    editUserPage.setFirstName('Igor');
    editUserPage.setLastName('Olegovich');
    editUserPage.setRole('User');
    editUserPage.setPhoneNumber('+xx(xxx)xxx-xx-xx');
    editUserPage.clickSave();

  });

  it("Delete User", () => {
    addUserPage.loginAndVisit();
    deleteUser.visit();
    deleteUser.clickDeleteForUser('Igor');
  });

});
