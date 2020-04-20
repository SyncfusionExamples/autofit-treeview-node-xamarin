# How to AutoFit the nodes based on the content in Xamarin.Forms TreeView (SfTreeView)

You can auto fit the [SfTreeView](https://help.syncfusion.com/xamarin/treeview/overview?) node height based on its content using [QueryNodeSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.SfTreeView~QueryNodeSize_EV.html?) in Xamarin.Forms.

You can also refer th following article.

https://www.syncfusion.com/kb/11418/how-to-autofit-the-nodes-based-on-the-content-in-xamarin-forms-treeview-sftreeview

**C#**

Setting node height based on its content using [GetActualNodeHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.QueryNodeSizeEventArgs~GetActualNodeHeight.html?) method.
``` c#
namespace TreeViewXamarin
{
    public class Behavior : Behavior<SfTreeView>
    {
        protected override void OnAttachedTo(SfTreeView bindable)
        {
            bindable.QueryNodeSize += Bindable_QueryNodeSize;
            base.OnAttachedTo(bindable);
        }
 
        private void Bindable_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
        {
            // Returns item height based on the content loaded.
            e.Height = e.GetActualNodeHeight();
            e.Handled = true;
        }
        protected override void OnDetachingFrom(SfTreeView bindable)
        {
            bindable.QueryNodeSize -= Bindable_QueryNodeSize;
            base.OnDetachingFrom(bindable);
        }
    }
}
```
**Output**

![AutoFitContentTreeView](https://github.com/SyncfusionExamples/autofit-treeview-node-xamarin/blob/master/ScreenShots/AutoFitContentTreeView.png)
