using Points.Content.Creator;
using Points.Content.Game.Interfaces;

namespace Points.Content.Game.GameItems.Manager
{
    public class GameEditor : EditorExtend
    {
        public void createZone()
        {
            ManagerP.goToPage(ManagerP.createPage<PlanetPage>());
        }
    }
}