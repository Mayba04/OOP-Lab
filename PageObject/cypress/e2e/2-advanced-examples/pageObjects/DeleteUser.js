class DeleteUser {
    visit() {
        cy.get('a[href="/dashboard/users"]').click();
        return this;
      }

    getUserRowByName(name) {
        return cy.get('table').contains('td', name).parent();
    }

    clickDeleteForUser(name) {
        this.getUserRowByName(name).find('button:contains("Delete")').click();
    }
  
  }
  
  export default DeleteUser;