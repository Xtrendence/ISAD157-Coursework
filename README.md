# ISAD157 Coursework (C1/W1)

This is a repo for the ISAD157 module coursework. A sample interface coded in C# with a WinForms based GUI to fetch and display data from a MySQL database.

---

### Please note that in order to use this application, you'll have to be connected to the University of Plymouth network either by physically being there, or by using a VPN.

---

### How do I use it?

When you open up the application, you'll be presented with 3 buttons: "Get Tables", "View Table", and "Apply Filter". There's also an input field with "UserID Filter..." as its placeholder. There's a ListBox on the left, and a DataGridView in the center. To use the application, click on the "Get Tables" button to fetch the tables that the database schema contains. To view a table's content, simply select one of the tables from the ListBox, and click on the "View Table" button. You can view a specific user's records by entering their UserID in the input field, and clicking on the "Apply Filter" button after you've already opened a table. When you click on the "View Table" button, however, it also takes the filter into account, so as long as the input field contains a value, the DataGridView will only contain records with the filter applied.

### What features does this application have?

The sample interface features the ability to select a table from the MySQL database, fetch the content of the chosen table, and display the records in a DataGridView component/control. Optionally, the user can use an input field on the bottom right corner of the interface's UI to only fetch the records of one user. This doesn't simply filter the fetched content, instead, it fetches only the desired records through more targeted SQL queries.

### What does the word "sample" imply?

As mentioned in the coursework briefing, this is only meant to be a sample application, meaning it shouldn't contain all the features that an otherwise completed system would have. As such, this interface can only read data from the database, and it doesn't have any security features or robust exception handling. In a finished application, there'd ideally be a login system, and a way to modify/delete records from the database.

![Sample Interface](https://i.imgur.com/CGm1uf8.png)
