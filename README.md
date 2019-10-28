# How to Update Entire Row

If the GridControl is bound to server-side data, handle the [GridViewBase.ValidateRow](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ValidateRow) event to check whether a datasource can update a row after you click the Update button. If true, post changes manually; otherwise, the GridControl will allow you to correct values or click the Cancel button to return the previous values.
