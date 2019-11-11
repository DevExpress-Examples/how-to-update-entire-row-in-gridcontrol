# How to Edit an Entire Row and Post Changes to a Database

The GridControl supports the [Edit Entire Row](https://docs.devexpress.com/WPF/6606/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/inplace-editors#edit-entire-row) mode.

In default mode, changes made via [in-place editors](https://docs.devexpress.com/WPF/6606/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/inplace-editors) are immediately posted to your data source. Unlike default mode, **Edit Entire Row** requires users to press the **Update** button to explicitly post changes to your data source.

To activate **Edit Entire Row** mode, use the [TableView.ShowUpdateRowButtons](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.ShowUpdateRowButtons) / [TreeListView.ShowUpdateRowButtons](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.ShowUpdateRowButtons) property.

When you change cell values within a row, the GridControl “freezes” the UI. You cannot navigate away from the edited row until you record or cancel changes. To post changes made, click the **Update** button. If you click the **Cancel** button, changes will be discarded.

The GridControl in this example is bound to Entity Framework:

```charp
public MainWindow() {
    InitializeComponent();
    var context = new IssuesContext();
    grid.ItemsSource = context.Issues.ToArray();
}

public class IssuesContext : DbContext { 
    // ... 
}
```

When you make changes to grid values, changes are made only to in-memory replicas, not to the actual data in the database. To save changes and intercept possible database errors, handle the [GridViewBase.ValidateRow](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ValidateRow) event and explicitly call **SaveChanges** on the **DataContext**:

```xml
<dxg:TableView ShowUpdateRowButtons="OnCellEditorOpen" 
               ValidateRow="TableView_ValidateRow" />
```

```charp
void TableView_ValidateRow(object sender, GridRowValidationEventArgs e) {
    var issue = (Issue)e.Row;
    using(var context = new IssuesContext()) {
        var result = context.Issues.SingleOrDefault(b => b.Id == issue.Id);
        if(result != null) {
            result.Subject = issue.Subject;
            result.Priority = issue.Priority;
            result.Votes = issue.Votes;
            result.Priority = issue.Priority;
            context.SaveChanges();
        }
    }
}
```

If an error occurs, the GridControl will allow you to correct values or click the Cancel button to return the previous value.
