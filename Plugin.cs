using BepInEx;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MTGABepinexPlugin
{
    [BepInPlugin("com.github.mesonimie.mtga-bepinex", "MTGA Plugin", "1.0.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {            
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Task task = new Task(() => getInventory());
            task.Start();

        }

        private void getInventory(){
            Logger.LogInfo("waiting");            
             Thread.Sleep(30000);   
            Logger.LogInfo("end of waiting");            
            
            if (WrapperController.Instance != null) 
            {
                Logger.LogInfo("yay");
                if (WrapperController.Instance.InventoryManager != null){
                    Logger.LogInfo("super");
                    if (WrapperController.Instance.InventoryManager.Cards != null)
                        Logger.LogInfo(WrapperController.Instance.InventoryManager.Cards.Count);
                        Logger.LogInfo(WrapperController.Instance.InventoryManager.Cards);
                    Dictionary<uint, int> cards = WrapperController.Instance.InventoryManager.Cards;
                    StreamWriter f = File.CreateText(Path.Combine(Paths.PluginPath, "cards"));
                    f.Write("{");
                    f.Write(string.Join(",", cards.Select(item=>$"\"{item.Key}\": {item.Value}")));
                    f.WriteLine("}");
                    f.Close();
                }
            }            

        }
    }
}
