import LoginPage from "./pageObjects/LoginPage.js";
const loginPage = new LoginPage();

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
});
