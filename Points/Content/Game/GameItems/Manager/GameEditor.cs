using Points.Content.Creator;
using Points.Content.Game.GameItems.items;
using Points.Content.Game.Interfaces;

namespace Points.Content.Game.GameItems.Manager
{
    public class GameEditor : EditorExtend
    {
        Page first;
        public void createZone()
        {
            first = ManagerP.createPage<PlanetPage>();
            
        }
        public void startZone()
        {
            ManagerP.goToPage(first);
        }
    }
}