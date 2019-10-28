# How to Update Entire Row

When the GridControl is bound to a REST Service, handle the [GridViewBase.ValidateRow](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ValidateRow) event, check whether the service can update a row, and then post changes manually.
