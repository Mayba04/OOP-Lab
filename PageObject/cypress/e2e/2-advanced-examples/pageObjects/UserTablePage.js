class UserTablePage {

    visit() {
        cy.get('a[href="/dashboard/users"]').click();
        return this;
      }

    getUserRowByName(name) {
        return cy.get('table').contains('td', name).parent();
    }

    clickEditForUser(name) {
        this.getUserRowByName(name).find('button:contains("Edit")').click();
    }
}

export default UserTablePage;