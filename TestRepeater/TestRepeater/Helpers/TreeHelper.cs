using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace TestRepeater.Helpers
{
    public static class TreeHelper
    {
        //public static T FindChildOfType<T>(DependencyObject root) where T : class
        //{
        //    var MyQueue = new Queue<DependencyObject>();
        //    MyQueue.Enqueue(root);
        //    while (MyQueue.Count > 0)
        //    {
        //        DependencyObject current = MyQueue.Dequeue();
        //        if (current != null)
        //        {
        //            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(current); i++)
        //            {
        //                var child = VisualTreeHelper.GetChild(current, i);
        //                var typedChild = child as T;
        //                if (typedChild != null)
        //                {
        //                    return typedChild;
        //                }
        //                MyQueue.Enqueue(child);
        //            }
        //        }
        //    }
        //    return null;
        //}

        public static List<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            List<T> list = new List<T>();
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        list.Add((T)child);
                    }

                    List<T> childItems = FindVisualChildren<T>(child);
                    if (childItems != null && childItems.Count() > 0)
                    {
                        foreach (var item in childItems)
                        {
                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        public static TChild FindVisualChild<TChild>(DependencyObject obj) where TChild : DependencyObject
        {
            if (obj == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is TChild found)
                    return found;
                else
                {
                    TChild childOfChild = FindVisualChild<TChild>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        public static DependencyObject FindChildByName(DependencyObject parant, string ControlName)
        {
            int count = VisualTreeHelper.GetChildrenCount(parant);

            for (int i = 0; i < count; i++)
            {
                var MyChild = VisualTreeHelper.GetChild(parant, i);
                if (MyChild is FrameworkElement && ((FrameworkElement)MyChild).Name == ControlName)
                    return MyChild;

                var FindResult = FindChildByName(MyChild, ControlName);
                if (FindResult != null)
                    return FindResult;
            }

            return null;
        }

        public static List<T> FindChildrenByName<T>(DependencyObject parant, string ControlName) where T : DependencyObject
        {
            List<T> list = new List<T>();
            if (parant != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parant); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(parant, i);
                    if (child != null && child is T && child is FrameworkElement && ((FrameworkElement)child).Name == ControlName)
                    {
                        list.Add((T)child);
                    }

                    List<T> childItems = FindChildrenByName<T>(child, ControlName);
                    if (childItems != null && childItems.Count() > 0)
                    {
                        foreach (var item in childItems)
                        {
                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        public static T FindParentByName<T>(DependencyObject child, string parentName) where T : DependencyObject
        {
            if (child == null) return null;

            T foundParent = null;
            var currentParent = VisualTreeHelper.GetParent(child);

            do
            {
                var frameworkElement = currentParent as FrameworkElement;
                if (frameworkElement.Name == parentName && frameworkElement is T)
                {
                    foundParent = (T)currentParent;
                    break;
                }

                currentParent = VisualTreeHelper.GetParent(currentParent);

            } while (currentParent != null);

            return foundParent;
        }

        public static IEnumerable<DependencyObject> ChildrenBreadthFirst(this DependencyObject obj, bool includeSelf = false)
        {
            if (includeSelf)
            {
                yield return obj;
            }

            var queue = new Queue<DependencyObject>();
            queue.Enqueue(obj);

            while (queue.Count > 0)
            {
                obj = queue.Dequeue();
                var count = VisualTreeHelper.GetChildrenCount(obj);

                for (var i = 0; i < count; i++)
                {
                    var child = VisualTreeHelper.GetChild(obj, i);
                    yield return child;
                    queue.Enqueue(child);
                }
            }
        }
    }
}
