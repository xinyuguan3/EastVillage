using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FYP.Save;

namespace FYP.Transition
{

    public class TransitionManager : Singleton<TransitionManager>,ISaveable
    {
        //[SceneName]
        public string startSceneName = string.Empty;

        private CanvasGroup fadeCanvasGroup;

        private bool isFade;

        public string GUID=>GetComponent<DataGUID>().guid;
        private bool isLoad=false;

        protected override void Awake() {
            base.Awake();
            SceneManager.LoadScene("UI",LoadSceneMode.Additive);   
        }
        private void OnEnable()
        {
            EventHandler.TransitionEvent += OnTransitionEvent;
            EventHandler.StartNewGameEvent+=OnStartNewGameEvent;
                     
        }

        private void OnDisable()
        {
            EventHandler.TransitionEvent -= OnTransitionEvent;
            EventHandler.StartNewGameEvent-=OnStartNewGameEvent;
        }

        private void OnStartNewGameEvent(int obj)
        {
            if(!isLoad)
            {
                isLoad=true;
                StartCoroutine(LoadSaveDataScene(startSceneName));
            }
                
        }



        private void Start()
        {
            ISaveable saveable = this;
            saveable.RegisterSaveable();

            fadeCanvasGroup=FindObjectOfType<CanvasGroup>();
            
        }


        private void OnTransitionEvent(string sceneToGo, Vector3 positionToGo)
        {
            if(!isFade)
            {
                StartCoroutine(Transition(sceneToGo, positionToGo));
            }
        }

        /// <summary>
        /// 场景切换
        /// </summary>
        /// <param name="sceneName">目标场景</param>
        /// <param name="targetPosition">目标位置</param>
        /// <returns></returns>
        private IEnumerator Transition(string sceneName, Vector3 targetPosition)
        {
            EventHandler.CallBeforeSceneUnloadEvent();
            Debug.Log("tran called");
            yield return Fade(1);
            Debug.Log(SceneManager.GetActiveScene());
            yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

            yield return LoadSceneSetActive(sceneName);

            EventHandler.CallMoveToPosition(targetPosition);

            EventHandler.CallAfterSceneLoadedEvent(); 

            yield return Fade(0);

            
        }

        /// <summary>
        /// 加载场景并设置为激活
        /// </summary>
        /// <param name="sceneName">场景名</param>
        /// <returns></returns>
        private IEnumerator LoadSceneSetActive(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            Debug.Log("load scene active");
            Scene newScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);

            object p = SceneManager.SetActiveScene(newScene);
        }

        /// <summary>
        /// 淡入淡出场景
        /// </summary>
        /// <param name="targetAlpha">1是黑，0是透明</param>
        /// <returns></returns>
        private IEnumerator Fade(float targetAlpha)
        {
            isFade = true;
            //fadeCanvasGroup=FindObjectOfType<CanvasGroup>();
            
            fadeCanvasGroup.blocksRaycasts = true;
            

            float speed = Mathf.Abs(fadeCanvasGroup.alpha - targetAlpha) / 0.1f;

            while (!Mathf.Approximately(fadeCanvasGroup.alpha, targetAlpha))
            {
                fadeCanvasGroup.alpha = Mathf.MoveTowards(fadeCanvasGroup.alpha, targetAlpha, speed * Time.deltaTime);
                yield return null;
            }

            fadeCanvasGroup.blocksRaycasts = false;

            isFade = false;
        }

        private IEnumerator LoadSaveDataScene(string sceneName)
        {
            yield return Fade(1f);

            if(SceneManager.GetActiveScene().name!="PrimaryScene")
            {
                EventHandler.CallBeforeSceneUnloadEvent();
                yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
            Debug.Log("load dave data scene");
            yield return LoadSceneSetActive(sceneName);
            
            EventHandler.CallAfterSceneLoadedEvent();
            yield return Fade(0);
        }

        public GameSaveData GenerateSaveData()
        {
            
            GameSaveData saveData=new GameSaveData();
            saveData.dataSceneName=SceneManager.GetActiveScene().name;
            

            return saveData;
        }

        public void RestoreData(GameSaveData saveData)
        {
            Debug.Log("data restored");
            StartCoroutine(LoadSaveDataScene(saveData.dataSceneName));
        }
    }
}
