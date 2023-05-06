using System.Collections;
using System.Collections.Generic;
using FYP.Transition;

using UnityEngine;

namespace FYP.Save{
    public class DataSlot
    {
        public Dictionary<string,GameSaveData> dataDict=new Dictionary<string, GameSaveData>();
        
    #region
    // public string DataTime
    // {
    //     get{
    //         var key=TimeManager.Instance.GUID;

    //         if(dataDict.ContainsKey(key))
    //         {
    //             var timeData=dataDict[key];
    //             return timeData.timeDict["gameYear"]+"年/"+(Season)timeData.timeDict["gameSeason"]+"/"+timeData.timeDict["gameMonth"]+"月/"+timeData.timeDict["gameDay"]+"日/";
    //         }
    //         else
    //             return string.Empty;
    //     }
    // }
    public string DataScene
    {
        get
        {
            var key=TransitionManager.Instance.GUID;
            if(dataDict.ContainsKey(key))
            {
                var transitionData=dataDict[key];
                return transitionData.dataSceneName switch
                {
                    "00.Start"=>"酒店大堂",
                    "01.Field"=>"酒店房间",
                    "02.House"=>"酒店后院",
                    // "03.Stall"=>"市场",
                    _=>string.Empty
                };
            }
            else return string.Empty;
        }
    }
    #endregion
    }
}

