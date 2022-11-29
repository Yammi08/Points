using Points.Content.Game.GameItems.items;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerPages 
    {

        Dictionary<string, Page> pages;
        Page _currentPage;
        public Page currentPage { get => _currentPage; private set => _currentPage = value; }
        public ManagerPages()
        {
            pages = new Dictionary<string, Page>();
        }
        public T createPage<T>() where T : Page
        {
            T page = (T)Activator.CreateInstance(typeof(T), this);
            pages.Add(page.id, page);
            return page;
        }
        public Page getPage(string id)
        {
            Page page;
            if (!pages.TryGetValue(id, out page))
                throw new Exception("##404 this page not found, ERROR ADD");
            return page;
        }
        public void goToPage(Page page)
        {
            page.init();
            currentPage = page;
            page.enterTree();
        }
        public void removePage(string id)
        {
            if(!pages.Remove(id))
                throw new Exception("##404 this page not found, ERROR REMOVE");
        }
        public void removePage(Page page)=>removePage(page.id);
    }
}
