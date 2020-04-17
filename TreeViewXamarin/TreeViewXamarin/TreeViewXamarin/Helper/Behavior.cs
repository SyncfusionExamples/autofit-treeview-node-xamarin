using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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
